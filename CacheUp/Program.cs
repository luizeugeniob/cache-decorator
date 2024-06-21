using CacheUp.Entities;
using CacheUp.Repositories;
using CacheUp.Services;

namespace CacheUp;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddScoped<IRepository<Hobby>, HobbyRepository>();
        builder.Services.AddScoped<IRepository<Traveler>, TravelerRepository>();
        
        builder.Services.AddScoped<IHobbyService, HobbyService>();
        builder.Services.AddScoped<ITravelerService, TravelerService>();

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
    }
}
