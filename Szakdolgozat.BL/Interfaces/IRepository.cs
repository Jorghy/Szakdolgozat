using System.Collections.Generic;
using Szakdolgozat.DTO.Models;

namespace Szakdolgozat.BL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T GetById(int ID);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

    public interface IAuthorRepository : IRepository<Author> { }
    public interface IBookAuthorRepository : IRepository<BookAuthor> { }
    public interface IBookRepository : IRepository<Book> { }
    public interface IJobRepository : IRepository<Job> { }
    public interface IPublisherRepository : IRepository<Publisher> { }
    public interface ISaleRepository : IRepository<Sale> { }
    public interface IStoreRepository : IRepository<Store> { }
}
