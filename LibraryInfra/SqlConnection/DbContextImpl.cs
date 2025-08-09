using LibraryCore.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInfra.SqlConnection
{
    public class DbContextImpl:DbContext
    {
        public DbContextImpl(DbContextOptions<DbContextImpl>options):base(options)
        {
            
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>().HasMany(x => x.Transactions).WithOne(x => x.Books).HasForeignKey(t => t.BookId); ;
            modelBuilder.Entity<Member>().HasMany(x => x.Transactions).WithOne(x => x.Members).HasForeignKey(t => t.MemberId);
        }
    }
}
