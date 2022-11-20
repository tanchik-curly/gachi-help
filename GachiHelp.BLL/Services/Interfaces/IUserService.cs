using GachiHelp.BLL.DTOs;
using GachiHelp.DAL.Entities;

namespace GachiHelp.BLL.Services.Interfaces;

public interface IUserService
{
    public PaginationList<UserDto> GetAll(int skip = 0, int limit = -1, string searchQuery = "");

    public User? GetUser(int userId);

    public IEnumerable<UserComment> GetUserComments(int userId, int skip = 0, int limit = -1);
}
