using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GachiHelp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GachiHelp.DAL.Context
{
    public class GachiContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public GachiContext(DbContextOptions<GachiContext> options) : base(options) { }
    }
}
