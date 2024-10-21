using Microsoft.EntityFrameworkCore;
using TrainingDemo.Services;
using TraininingDemo.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IUserService, UserService>();

// MS SQL
//builder.Services.AddDbContext<TrainingDemoDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("MsSqlConnection")));

// For MySQL
builder.Services.AddDbContext<TrainingDemoDbContext>(options =>
                options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnection"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MySqlConnection"))));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
