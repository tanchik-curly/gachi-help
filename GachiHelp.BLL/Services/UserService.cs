using AutoMapper;
using GachiHelp.BLL.DTOs;
using GachiHelp.BLL.Services.Interfaces;
using GachiHelp.DAL.Entities;
using GachiHelp.DAL.Repository;

namespace GachiHelp.BLL.Services;

public class UserService : IUserService
{
    private readonly IRepository<User> _userRepository;
    private readonly IRepository<UserComment> _commentsRepository;
    private readonly IMapper _mapper;

    public UserService(IRepository<User> userRepository, IRepository<UserComment> commentsRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _commentsRepository = commentsRepository;
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

    public IEnumerable<UserComment> GetUserComments(int userId, int skip = 0, int limit = -1)
    {
        var comments = _commentsRepository.AllIncluding(c => c.Author!)
                                          .Where(c => c.Author.Id == userId)
                                          .Skip(skip)
                                          .OrderByDescending(c => c.CreateDateTime)
                                          .ToList();

        if (limit != -1)
            comments = comments.Take(limit).ToList();

        return comments;
    }
}