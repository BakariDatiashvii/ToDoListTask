using Microsoft.EntityFrameworkCore;
using Todo.Domain.Contracts;
using Todo.Domain.Contracts.Repositories;
using Todo.Infrastructure;
using Todo.Infrastructure.Database;
using Todo.Infrastructure.Repo;

var builder = WebApplication.CreateBuilder(args);




builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer(); //qondA
builder.Services.AddHttpContextAccessor();

builder.Services.AddDbContext<ToDoTaskDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("ToDoTaskDbContext")));
builder.Services.AddScoped<RepositoryProvider>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IToDoTaskRepository,ToDoTaskRepository>();
builder.Services.AddSwaggerGen();

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
app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());


app.Run();
