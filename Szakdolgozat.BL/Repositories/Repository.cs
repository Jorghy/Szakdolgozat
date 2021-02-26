using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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

    public class AuthorRepository : Repository<AuthorCo>, IAuthorRepository
    {
        public AuthorRepository(BookStoreContext context): base(context) { }
    }
    public class BookAuthorRepository : Repository<BookAuthorCo>, IBookAuthorRepository
    {
        public BookAuthorRepository(BookStoreContext context) : base(context) { }
    }
    public class BookRepository : Repository<BookCo>, IBookRepository
    {
        public BookRepository(BookStoreContext context) : base(context) { }
    }
    public class JobRepository : Repository<JobCo>, IJobRepository
    {
        public JobRepository(BookStoreContext context) : base(context) { }
    }
    public class PublisherRepository : Repository<PublisherCo>, IPublisherRepository
    {
        public PublisherRepository(BookStoreContext context) : base(context) { }
    }
    public class RoleRepository : Repository<RoleCo>, IRoleRepository
    {
        public RoleRepository(BookStoreContext context) : base(context) { }
    }
    public class SaleRepository : Repository<SaleCo>, ISaleRepository
    {
        public SaleRepository(BookStoreContext context) : base(context) { }
    }
    public class StoreRepository : Repository<StoreCo>, IStoreRepository
    {
        public StoreRepository(BookStoreContext context) : base(context) { }
    }
    public class UserRepository : Repository<UserCo>, IUserRepository
    {
        public UserRepository(BookStoreContext context) : base(context) { }
    }

}
