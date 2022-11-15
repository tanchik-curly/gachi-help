using GachiHelp.DAL.Entities;
using GachiHelp.DAL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GachiHelp.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HelpCategoriesController : ControllerBase 
{
    private readonly IRepository<HelpCategory> _repository;

    public HelpCategoriesController(IRepository<HelpCategory> repository)
    {
        _repository = repository;
    }

    [HttpGet]        
    public ActionResult<IEnumerable<HelpCategory>> Get()
    {
        return _repository.GetAll().ToArray();
    }
}