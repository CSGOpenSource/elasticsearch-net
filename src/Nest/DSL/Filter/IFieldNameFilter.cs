namespace Nest_1_7_2
{
	public interface IFieldNameFilter : IFilter
	{
		PropertyPathMarker Field { get; set; }
	}
}