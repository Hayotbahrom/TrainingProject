
using Microsoft.EntityFrameworkCore;
using TrainingProject.Api.Extentions;
using TrainingProject.Domain.Interfaces.Repositories;
using TrainingProject.Infrastructure.DbContexts;
using TrainingProject.Repositories.Repositories;
using TrainingProject.UseCase.Contracts;
using TrainingProject.UseCase.Mappings;
using TrainingProject.UseCase.Services;

namespace TrainingProject.Api
{
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

            builder.Services.AddSwaggerService();
            builder.Services.AddJwtService(builder.Configuration);

            //Register DbContext
            builder.Services.AddDbContext<AppDbContext>(option
                => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
                );

            //register repositories
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
            builder.Services.AddScoped<IContactRepository, ContactRepository>();

            //register services
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<ICompanyService, CompanyService>();
            builder.Services.AddScoped<IContactService, ContactService>();
            builder.Services.AddScoped<IAuthService, AuthService>();

            //register automapper
            builder.Services.AddAutoMapper(typeof(MappingProfile));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
