using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GachiHelp.DAL.Entities;
using GachiHelp.DAL.Enums;
using Microsoft.EntityFrameworkCore;

namespace GachiHelp.DAL.Context
{
    internal static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Login = "admin", Role = Role.Admin, PasswordHash = HashPassword("admin")},
                new User { Id = 2, Login = "tetiana", Role = Role.Worker, PasswordHash = HashPassword("tetiana") },
                new User { Id = 3, Login = "jamal", Role = Role.Worker, PasswordHash = HashPassword("jamal") },
                new User { Id = 4, Login = "mykola", Role = Role.Admin, PasswordHash = HashPassword("mykola") },
                new User { Id = 5, Login = "ivan", Role = Role.Admin, PasswordHash = HashPassword("ivan") },
                new User { Id = 6, Login = "olexandr", Role = Role.Admin, PasswordHash = HashPassword("olexandr") },
                new User { Id = 7, Login = "vitaliy", Role = Role.Admin, PasswordHash = HashPassword("vitaliy") }
            );
        }
        private static string HashPassword(string password) => Convert.ToBase64String(SHA256.HashData(Encoding.Default.GetBytes(password)));
    }
}
