using GachiHelp.DAL.Entities;
using GachiHelp.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GachiHelp.BLL.DTOs
{
    public class HelpDto
    {
        public int Id { get; set; }

        public HelpCategory? HelpCategory { get; set; }

        public UserDto? Author { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Status { get; set; }
    }
}
