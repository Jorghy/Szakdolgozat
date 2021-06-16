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
        public ISaleRepository Sales { get; }
        public IStoreRepository Stores { get; }

        public UnitOfWork(BookStoreContext context, IAuthorRepository Author, IBookAuthorRepository BookAuthor, 
            IBookRepository Book, IJobRepository Job, IPublisherRepository Publisher, ISaleRepository Sale, 
            IStoreRepository Store)
        {
            _context = context;
            Authors = Author;
            BookAuthors = BookAuthor;
            Books = Book;
            Jobs = Job;
            Publishers = Publisher;
            Sales = Sale;
            Stores = Store;
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
