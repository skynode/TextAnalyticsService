using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using TextAnalyticsService.Enums;
using TextAnalyticsService.Services;

namespace TextAnalyticsService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TextStatisticsService
    {
        [HttpGet]
        public async Task<IActionResult> GenerateStatistics(string text)
        {

            return await new JsonResult()
        }
    }
}
