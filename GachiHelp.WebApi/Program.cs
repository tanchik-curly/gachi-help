using System.Text;
using GachiHelp.BLL.Services;
using GachiHelp.BLL.Services.Interfaces;
using GachiHelp.DAL.Context;
using GachiHelp.DAL.Entities;
using GachiHelp.DAL.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<GachiContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        o => o.MigrationsAssembly("GachiHelp.DAL")
    )
);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,

            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration.GetValue<string>("JWTSecretKey"))
            )
        };
    });

builder.Services.AddScoped<IRepository<User>, Repository<User>>();

builder.Services.AddSingleton<IAuthService>(
    new AuthService(
        builder.Configuration.GetValue<int>("JWTLifespan"),
        builder.Configuration.GetValue<string>("JWTSecretKey")
    )
);

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(b => b
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
);

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
