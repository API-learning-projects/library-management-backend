using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using LibraryManagement.Data;
using LibraryManagement.Services;
using LibraryManagement.Services.Book;

namespace LibraryManagement
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>();
            services.AddControllers();

            // TODO: interface voor dependency injection

            /* Services */
            services.AddSingleton<AccountService>();
            services.AddSingleton<AuthorService>();
            services.AddSingleton<BookService>();
            services.AddSingleton<GenreService>();

            // book
            services.AddSingleton<BorrowService>();
            services.AddSingleton<BuyService>();
            services.AddSingleton<FilterService>();
            services.AddSingleton<SellService>();

            // utils
            services.AddSingleton<BCryptService>();
            services.AddSingleton<JWTService>();

            // test
            services.AddSingleton<TestService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Forces HTTPS
            app.UseHttpsRedirection();

            // Enables routing so the API can handle different URLs and HTTP methods
            app.UseRouting();

            // Enables authentication and authorization
            app.UseAuthorization();

            // Maps the endpoints to the controller folder
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
