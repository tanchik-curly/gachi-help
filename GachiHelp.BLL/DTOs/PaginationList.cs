using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GachiHelp.BLL.DTOs
{
    public class PaginationList<T>
    {
        public IEnumerable<T> Items { get; set; }
        public int ItemCount { get; set; }
    }
}
