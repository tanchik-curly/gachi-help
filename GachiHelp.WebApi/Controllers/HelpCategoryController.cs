using GachiHelp.BLL.DTOs;
using GachiHelp.BLL.Services.Interfaces;
using GachiHelp.DAL.Entities;
using GachiHelp.DAL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GachiHelp.WebApi.Controllers
{
    [ApiController]
    public class HelpCategoryController : ControllerBase 
    {
        private IRepository<HelpCategory> _repository;

        public HelpCategoryController(IRepository<HelpCategory> repository)
        {
            _repository = repository;
        }

        [HttpGet("/requested-help/categories")]        
        public ActionResult<IEnumerable<HelpCategory>> Get()
        {
            return _repository.GetAll().ToArray();
        }
    }
}