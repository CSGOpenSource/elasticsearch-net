namespace Nest_1_7_2
{
	public class DslException : System.Exception
	{
		public DslException(string msg) : base(msg)
		{
		}

		public DslException(string msg, System.Exception exp) : base(msg, exp)
		{
		}
	}
}