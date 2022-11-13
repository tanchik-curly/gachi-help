﻿using System;
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
        public DbSet<HelpCategory> HelpCategories { get; set; }
        public DbSet<Help> Helps { get; set; }

        public GachiContext(DbContextOptions<GachiContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(u => u.Login).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();

            modelBuilder.Seed();
            
            base.OnModelCreating(modelBuilder);
        }

    }
}
