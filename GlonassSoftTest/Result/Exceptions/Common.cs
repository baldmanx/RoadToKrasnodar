using System;

namespace GlonassSoftTest.Result.Exceptions
{
	public class ResultIsNullOrEmptyException : Exception
	{
		public ResultIsNullOrEmptyException() : base("There is no such worker, employed between input dates!") { }
	}
}
