﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GachiHelp.BLL.DTOs.User
{
    public class AuthData
    {
        public string Token { get; set; }
        public long ExpirationTime { get; set; }
        public DAL.Entities.User User { get; set; }
    }
}
