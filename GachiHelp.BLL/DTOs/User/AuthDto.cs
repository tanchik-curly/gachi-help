using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GachiHelp.BLL.DTOs.User
{
    public class AuthDto
    {
        public string Token { get; set; }
        public long ExpirationTime { get; set; }
        public int UserId { get; set; }
    }
}
