using GachiHelp.BLL.DTOs;
using GachiHelp.BLL.Services.Interfaces;
using GachiHelp.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GachiHelp.WebApi.Controllers
{
    [ApiController]
    public class HelpController : ControllerBase 
    {
        private IHelpService _helpService;

        public HelpController(IHelpService helpService)
        {
            _helpService = helpService;
        }

        [HttpGet("/requested-help")]
        public ActionResult<IEnumerable<Help>> Get([FromQuery] int? skip, [FromQuery] int? limit)
        {
            return _helpService.GetHelp(skip ?? 0, limit ?? -1).ToArray();
        }

        [HttpGet("/requested-help/{userId}")]        
        public ActionResult<IEnumerable<Help>> GetByUser(int userId, [FromQuery]int? skip, [FromQuery]int? limit)
        {
            return _helpService.GetHelpByUser(userId, skip??0, limit??-1).ToArray();
        }

        [HttpGet("/stat/help-requests")]
        public ActionResult<IEnumerable<HelpStatAggregateDto>> GetHelpStats([FromQuery] string by, [FromQuery] DateTime? from, [FromQuery] DateTime? to, [FromQuery] int? categoryId) 
        {
            return by switch
            {
                "period" => _helpService.GetHelpStatsByPeriod(from, to).ToArray(),
                "category" => _helpService.GetHelpStatsByCategory(categoryId).ToArray(),
                _ => BadRequest()
            };
        }

        [HttpGet("/stat/{userId}/help-requests")]
        public ActionResult<IEnumerable<HelpStatAggregateDto>> GetUsersHelpStats(int userId, [FromQuery] string by, [FromQuery] DateTime? from, [FromQuery] DateTime? to, [FromQuery] int? categoryId)
        {
            return by switch
            {
                "period" => _helpService.GetUserHelpStatsByPeriod(userId, from, to).ToArray(),
                "category" => _helpService.GetUserHelpStatsByCategory(userId, categoryId).ToArray(),
                _ => BadRequest()
            };
        }
    }
}