using System.Data.Entity;
using Szakdolgozat.DTO.Models;

namespace Szakdolgozat.DAL
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext() : base("Data Source=localhost;Initial Catalog=BookStoreDB;Integrated Security=True;")
        {
            Database.SetInitializer(new BookStoreInitializer());
        }

        public DbSet<AuthorCo> Authors { get; set; }
        public DbSet<BookCo> Books { get; set; }
        public DbSet<BookAuthorCo> BookAuthors { get; set; }
        public DbSet<JobCo> Jobs { get; set; }
        public DbSet<PublisherCo> Publishers { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<RoleCo> Roles { get; set; }
        public DbSet<SaleCo> Sales { get; set; }
        public DbSet<StoreCo> Stores { get; set; }
        public DbSet<UserCo> Users { get; set; }

    }
}
