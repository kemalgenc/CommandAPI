using CommandAPI.Data;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);
var connStringBuilder = new NpgsqlConnectionStringBuilder();
connStringBuilder.ConnectionString = builder.Configuration.GetConnectionString("PostgreSqlConnection");
connStringBuilder.Username = builder.Configuration["UserID"];
connStringBuilder.Password = builder.Configuration["Password"];
builder.Services.AddControllers();
builder.Services.AddDbContext<CommandContext>(opt => opt.UseNpgsql(connStringBuilder.ConnectionString));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
//builder.Services.AddScoped<ICommandRepo, MockCommandRepo>();
builder.Services.AddScoped<ICommandRepo, SqlCommandRepo>();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapControllers();

app.Run();
