namespace GachiHelp.BLL.DTOs;

public class PaginationList<T>
{
    public IEnumerable<T> Items { get; set; } = null!;
    public int ItemCount { get; set; }
}
