using GachiHelp.BLL.DTOs;

namespace GachiHelp.BLL.Services.Interfaces;

public interface IHelpService
{
    PaginationList<HelpDto> GetHelp(int userId = -1, int skip = 0, int limit = -1);
}
