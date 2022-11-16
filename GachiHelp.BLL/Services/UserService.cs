using AutoMapper;
using GachiHelp.BLL.DTOs;
using GachiHelp.BLL.Services.Interfaces;
using GachiHelp.DAL.Entities;
using GachiHelp.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace GachiHelp.BLL.Services;

public class UserService : IUserService
{
    private readonly IRepository<User> _userRepository;
    private readonly IMapper _mapper;

    public UserService(IRepository<User> userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public PaginationList<UserDto> GetAll(int skip = 0, int limit = -1, string searchQuery = "")
    {
        var foundUsers = _userRepository.FindBy(u => u.Surname.Contains(searchQuery));

        int count = foundUsers.Count();

        var limitedUsers = foundUsers.OrderBy(u => u.Surname.IndexOf(searchQuery))
            .ThenBy(u => u.Surname).ThenBy(u => u.Name).ThenBy(u => u.Patronym)
            .Skip(skip);

        if(limit > 0)
            limitedUsers = limitedUsers.Take(limit);

        return new PaginationList<UserDto> { Items = limitedUsers.Select(u => _mapper.Map<UserDto>(u)), ItemCount = count };
    }

    public User? GetUser(int userId) => _userRepository.GetSingle(userId);
}