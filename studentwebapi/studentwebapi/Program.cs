
using studentWebAPI.Models;

namespace studentWebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.Configure<AppSetting>
                (builder.Configuration.GetSection("AppSetting"));
            builder.Services.AddSwaggerGen()
                ;

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI();
            //}
            
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}
