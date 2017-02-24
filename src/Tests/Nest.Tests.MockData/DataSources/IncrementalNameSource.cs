﻿using System;
using System.Collections.Generic;
using System.Linq;
using AutoPoco.Engine;

namespace Nest_1_7_2.Tests.MockData.DataSources
{
	/// <summary>
	/// Generator of random ints.
	/// </summary>
	public class IncrementalNameSource : DatasourceBase<string>
	{
		private int _currentId;
		private readonly string _prefix;

		public IncrementalNameSource(string prefix = "a")
		{
			this._prefix = prefix;
		}

		public override string Next(IGenerationSession session)
		{
			var name = this._prefix + this._currentId++;
			return name;
		}
	}
}
