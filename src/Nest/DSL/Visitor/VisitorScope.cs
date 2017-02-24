namespace Nest_1_7_2.DSL.Visitor
{
	public enum VisitorScope
	{
		Unknown,
		Filter,
		Query,
		Must,
		MustNot,
		Should,
		PositiveQuery,
		NegativeQuery,
		NoMatchQuery,

	}
}