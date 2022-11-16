using GachiHelp.BLL.AutoMapperProfile;
using GachiHelp.BLL.Services;
using GachiHelp.BLL.Services.Interfaces;
using GachiHelp.DAL.Context;
using GachiHelp.DAL.Repository;
using GachiHelp.WebApi;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<GachiContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        o => o.MigrationsAssembly("GachiHelp.DAL")
    )
);
builder.Services.AddJwtAuthentication(builder.Configuration);
builder.Services.AddAutoMapper(typeof(GachiProfile));
builder.Services.AddCors();

// Add custom services

builder.Services.AddSingleton<IAuthService>(
    new AuthService(
        builder.Configuration.GetValue<int>("JWTLifespan"),
        builder.Configuration.GetValue<string>("JWTSecretKey")
    )
);

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IHelpService, HelpService>();
builder.Services.AddScoped<IStatService, StatService>();
builder.Services.AddScoped<IUserService, UserService>();



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

app.UseAuthorization();

app.MapControllers();

app.Run();
