﻿using System;
using System.Collections.Concurrent;
using System.Configuration;
using System.Linq;
using Nest.Resolvers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Nest
{
	internal class UnionConverter : JsonConverter
	{
		private static ConcurrentDictionary<Type, UnionConverterBase> KnownTypes = new ConcurrentDictionary<Type, UnionConverterBase>();  

		public override bool CanConvert(Type objectType) => true;
		public override bool CanRead => true;
		public override bool CanWrite => true;

		public static UnionConverterBase CreateConverter(Type t)
		{
			UnionConverterBase conversion;
			if (KnownTypes.TryGetValue(t, out conversion))
				return conversion;

			var genericArguments = t.GetGenericArguments();
			switch (genericArguments.Length)
			{
				case 2:
					conversion = typeof (UnionConverter<,>).CreateGenericInstance(genericArguments) as UnionConverterBase;
					break;
				default:
					throw new Exception($"No union converter registered that takes {genericArguments.Length} type arguments");

			}
			KnownTypes.TryAdd(t, conversion);
			return conversion;
		}

		public override void WriteJson(JsonWriter writer, object v, JsonSerializer serializer)
		{
			var converter = CreateConverter(v.GetType());
			if (converter == null) return;
			converter.WriteJson(writer, v, serializer);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			
			var converter = CreateConverter(objectType);
			if (converter == null) return null;
			return converter.ReadJson(reader, objectType, existingValue, serializer);
		}
	}

	internal abstract class UnionConverterBase
	{
		public bool TryRead<T>(JsonReader reader, JsonSerializer serializer, out T v)
		{
			try
			{
				v = serializer.Deserialize<T>(reader);
				return true;
			}
			catch {}
			v= default(T);
			return false;
		}

		public abstract void WriteJson(JsonWriter writer, object v, JsonSerializer serializer);
		public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);
	}

	internal class UnionConverter<TFirst, TSecond> : UnionConverterBase
	{
		public override void WriteJson(JsonWriter writer, object v, JsonSerializer serializer)
		{
			var union = v as Union<TFirst, TSecond>;
			if (union == null)
			{
				writer.WriteNull();
				return;
			};

			union.Match(
				first => serializer.Serialize(writer, first),
				second => serializer.Serialize(writer, second)
			);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			TFirst first;
			TSecond second;
			Union<TFirst, TSecond> r = null;
			if (this.TryRead<TFirst>(reader, serializer, out first)) r=first;
			else if (this.TryRead<TSecond>(reader, serializer, out second)) r=second;
			return r;
		}

	}
}