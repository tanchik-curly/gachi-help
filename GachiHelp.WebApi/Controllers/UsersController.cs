using AutoMapper;
using GachiHelp.BLL.DTOs;
using GachiHelp.DAL.Entities;
using GachiHelp.DAL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GachiHelp.WebApi.Controllers
{
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IRepository<User> _userRepository;
        private IMapper _mapper;

        public UsersController(IRepository<User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet("users")]
        public ActionResult<IEnumerable<UserDto>> Index() 
        {
            return _userRepository.AllIncluding().Select(u => _mapper.Map<UserDto>(u))
                .OrderBy(u=>u.Surname).ThenBy(u=>u.Name).ThenBy(u=>u.Patronym).ToArray();
        }
    }
}