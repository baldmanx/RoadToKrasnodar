using GlonassSoftTest.Result;
using System;
using System.Threading.Tasks;

namespace GlonassSoftTest.Services
{
	public interface IUserStatsService
	{
		Task<Result<Guid>> GetUserInfo(Guid id, DateTime from, DateTime to);
	}
}
