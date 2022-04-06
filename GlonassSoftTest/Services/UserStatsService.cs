using GlonassSoftTest.Result;
using GlonassSoftTest.Result.Exceptions;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlonassSoftTest.Services
{
	public class UserStatsService : IUserStatsService
	{
		readonly DbInteractor _context;

		public UserStatsService(DbInteractor context)
		{
			_context = context;
		}

		public async Task<Result<Guid>> GetUserInfo(Guid id, DateTime from, DateTime to)
		{
			try
			{
				List<UserStats> userStats = await _context.UserStats.Where(us => us.Id == id && us.EmploymentDate >= from && us.EmploymentDate <= to).ToListAsync();
				if (userStats == null || !userStats.Any())
				{
					throw new ResultIsNullOrEmptyException();
				}
			}
			catch(Exception ex)
			{
				return Result<Guid>.Error(
					new List<Error>()
					{
						new Error()
						{
							Message = $"Original Message: {ex.Message}."
						}
					});
			}

			return new Result<Guid>(Guid.NewGuid());
		}
	}
}
