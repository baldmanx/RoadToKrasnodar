using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GlonassSoftTest;
using Microsoft.Extensions.Logging;
using GlonassSoftTest.DTOs;
using GlonassSoftTest.Services;

namespace GlonassSoftTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserStatsController : Controller
    {
		readonly IUserStatsService _userStatsService;
		readonly ILogger<UserStats> _logger;

        public UserStatsController(IUserStatsService userStatsService, ILogger<UserStats> logger)
        {
			_userStatsService = userStatsService;
            _logger = logger;
        }

		[ResponseCache(CacheProfileName = "Default30")]
		[HttpPost(Name = "GetUserInfo")]
		public async Task<ActionResult> GetUserStatsAsync(GetUserInfoRequest request)
		{
			_logger.LogInformation($"GET REQUEST: {request}");

			var result =  await _userStatsService.GetUserInfo(request.Id, request.From, request.To);

			if (result.Status == Result.ResultStatus.Error)
			{
				return BadRequest(new
				{
					status = result.Status.ToString(),
					result.Errors
				});
			}

			return Ok(new
			{
				status = result.Status.ToString(),
				result.Value
			});
		}

		//[HttpPost(Name = "GetUserStats")]
		//public async Task<List<UserStats>> GetUserStatsAsync(Guid id, DateTime from, DateTime to)
		//{
		//	return await _context.UserStats.Where(us => us.DateFrom == from).ToListAsync();
		//}
	}
}
