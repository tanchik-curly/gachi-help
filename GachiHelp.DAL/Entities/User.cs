﻿using GachiHelp.DAL.Enums;

namespace GachiHelp.DAL.Entities;

public class User : IEntity
{
    public int Id { get; set; }

    public string Login { get; set; }

    public string Email { get; set; }

    public Role Role { get; set; }

    public string PasswordHash { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public string Patronym { get; set; }
}