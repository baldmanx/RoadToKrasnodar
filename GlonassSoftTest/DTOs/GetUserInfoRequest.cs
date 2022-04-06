using System;

namespace GlonassSoftTest.DTOs
{
	public class GetUserInfoRequest 
	{
		public Guid Id { get; set; }
		public DateTime From { get; set; }
		public DateTime To { get; set; }
	}
}
