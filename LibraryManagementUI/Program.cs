using LibraryInfra.RepositoryImpl;
using LibraryInfra.SqlConnection;
using LibraryManagementCore.ServiceImpl;
using LibraryManagementCore.ServiceInterface;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<DbContextImpl>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection")));
            builder.Services.AddTransient<IBookRepository, BookRepository>();
            builder.Services.AddTransient<IMemberRepository, MemberRepository>();
            builder.Services.AddTransient<ITransactionRepository, ITransactionRepository>();
            builder.Services.AddTransient<IBookService, BookService>();
            builder.Services.AddTransient<IMemberService, MemberService>();
            builder.Services.AddTransient<ITransactionService, TransactionService>();
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(x=>x.MapControllers());
            app.Run();
        }
    }
}
