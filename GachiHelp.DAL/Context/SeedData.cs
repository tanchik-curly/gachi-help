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
                new User
                {
                    Id = 1, 
                    Login = "admin", 
                    Email = "admin@gachi.com", 
                    Role = Role.Admin,
                    PasswordHash = HashPassword("admin"),
                    Surname = "Зубенко",
                    Name = "Михайло",
                    Patronym = "Петрович"
                },
                new User
                {
                    Id = 2, 
                    Login = "tetiana",
                    Email = "tetiana@gachi.com",
                    Role = Role.Worker, 
                    PasswordHash = HashPassword("tetiana"),
                    Surname = "Дякун",
                    Name = "Тетяна",
                    Patronym = "Ярославівна"
                },
                new User { 
                    Id = 3, 
                    Login = "jamal",
                    Email = "jamal@gachi.com",
                    Role = Role.Worker, 
                    PasswordHash = HashPassword("jamal"),
                    Surname = "Сталоне",
                    Name = "Джамал",
                    Patronym = "Сільвестрович"
                },
                new User { 
                    Id = 4, 
                    Login = "mykola",
                    Email = "mykola@gachi.com",
                    Role = Role.User, 
                    PasswordHash = HashPassword("mykola"),
                    Surname = "Гірний",
                    Name = "Микола",
                    Patronym = "Олегович"
                },
                new User {
                    Id = 5,
                    Login = "ivan",
                    Email = "ivan@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("ivan"),
                    Surname = "Янович",
                    Name = "Іван",
                    Patronym = "Ігорович"
                },
                new User {
                    Id = 6,
                    Login = "olexandr",
                    Email = "olexandr@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("olexandr"),
                    Surname = "Білан",
                    Name = "Олександр",
                    Patronym = "Юрійович"
                },
                new User
                {
                    Id = 7,
                    Login = "vitaliy",
                    Email = "vitaliy@gachi.com",
                    Role = Role.User, 
                    PasswordHash = HashPassword("vitaliy"),
                    Surname = "Кіндрат",
                    Name = "Віталій",
                    Patronym = "Олегович"
                }
            );
        }
        private static string HashPassword(string password) => Convert.ToBase64String(SHA256.HashData(Encoding.Default.GetBytes(password)));
    }
}
