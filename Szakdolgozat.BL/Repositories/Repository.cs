using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Szakdolgozat.BL.Interfaces;
using Szakdolgozat.DAL;
using Szakdolgozat.DTO.Models;

namespace Szakdolgozat.BL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BookStoreContext _context;

        public Repository(BookStoreContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int ID)
        {
            return _context.Set<T>().Find(ID);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }

    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(BookStoreContext context): base(context) { }
    }
    public class BookAuthorRepository : Repository<BookAuthor>, IBookAuthorRepository
    {
        public BookAuthorRepository(BookStoreContext context) : base(context) { }
    }
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(BookStoreContext context) : base(context) { }
    }
    public class JobRepository : Repository<Job>, IJobRepository
    {
        public JobRepository(BookStoreContext context) : base(context) { }
    }
    public class PublisherRepository : Repository<Publisher>, IPublisherRepository
    {
        public PublisherRepository(BookStoreContext context) : base(context) { }
    }
    public class SaleRepository : Repository<Sale>, ISaleRepository
    {
        public SaleRepository(BookStoreContext context) : base(context) { }
    }
    public class StoreRepository : Repository<Store>, IStoreRepository
    {
        public StoreRepository(BookStoreContext context) : base(context) { }
    }

}
