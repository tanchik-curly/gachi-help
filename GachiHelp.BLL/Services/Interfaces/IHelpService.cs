using GachiHelp.BLL.DTOs;
using GachiHelp.DAL.Entities;

namespace GachiHelp.BLL.Services.Interfaces;

public interface IHelpService
{
    IEnumerable<Help> GetHelp(int userId = -1, DateTime from = default, DateTime to = default);
}
