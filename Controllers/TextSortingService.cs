using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using TextAnalyticsService.Enums;

namespace TextAnalyticsService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TextSortingService : ControllerBase
    {

        [HttpPost("{sortOption}")]
        public async Task<IActionResult> Sort(IFormFile file, SortOption sortOption)
        {


            return new OkResult();
        }

        
    }
}
