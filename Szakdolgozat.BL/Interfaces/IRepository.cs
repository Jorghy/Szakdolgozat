using System;
using System.Collections.Generic;
using System.Text;
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

    public interface IAuthorRepository : IRepository<AuthorCo> { }
    public interface IBookAuthorRepository : IRepository<BookAuthorCo> { }
    public interface IBookRepository : IRepository<BookCo> { }
    public interface IJobRepository : IRepository<JobCo> { }
    public interface IPublisherRepository : IRepository<PublisherCo> { }
    public interface IRoleRepository : IRepository<RoleCo> { }
    public interface ISaleRepository : IRepository<SaleCo> { }
    public interface IStoreRepository : IRepository<StoreCo> { }
    public interface IUserRepository : IRepository<UserCo> { }
}
