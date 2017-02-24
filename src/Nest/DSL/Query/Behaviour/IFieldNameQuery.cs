namespace Nest_1_7_2.DSL.Query.Behaviour
{
	public interface IFieldNameQuery : IQuery
	{
		PropertyPathMarker GetFieldName();
		void SetFieldName(string fieldName);
	}
}