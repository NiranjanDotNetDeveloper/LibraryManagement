using LibraryInfra.RepositoryImpl;
using LibraryInfra.SqlConnection;
using LibraryManagementCore.ServiceImpl;
using LibraryManagementCore.ServiceInterface;
using LibraryManagementUI.Middleware;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<DbContextImpl>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection")));
            builder.Services.AddTransient<ExceptionHandlerMiddleware>();
            builder.Services.AddTransient<IBookRepository, BookRepository>();
            builder.Services.AddTransient<IMemberRepository, MemberRepository>();
            builder.Services.AddTransient<ITransactionRepository, TransactionRepository>();
            builder.Services.AddTransient<IBookService, BookService>();
            builder.Services.AddTransient<IMemberService, MemberService>();
            builder.Services.AddTransient<ITransactionService, TransactionService>();
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseExceptionHandler("/Home/Error");
            app.UseStaticFiles();
            app.UseExceptionHandlerMiddleware();
            app.MapControllers();
            app.Run();
        }
    }
}
