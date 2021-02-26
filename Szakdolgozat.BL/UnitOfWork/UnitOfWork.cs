using Szakdolgozat.BL.Interfaces;
using Szakdolgozat.DAL;

namespace Szakdolgozat.BL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookStoreContext _context;
        public IAuthorRepository Authors { get; }
        public IBookAuthorRepository BookAuthors { get; }
        public IBookRepository Books { get; }
        public IJobRepository Jobs { get; }
        public IPublisherRepository Publishers { get; }
        public IRoleRepository Roles { get; }
        public ISaleRepository Sales { get; }
        public IStoreRepository Stores { get; }
        public IUserRepository Users { get; }

        public UnitOfWork(BookStoreContext context, IAuthorRepository Author, IBookAuthorRepository BookAuthor, IBookRepository Book,
            IJobRepository Job, IPublisherRepository Publisher, IRoleRepository Role, ISaleRepository Sale, IStoreRepository Store, IUserRepository User)
        {
            _context = context;
            Authors = Author;
            BookAuthors = BookAuthor;
            Books = Book;
            Jobs = Job;
            Publishers = Publisher;
            Roles = Role;
            Sales = Sale;
            Stores = Store;
            Users = User;
        }

        public int Complate()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
