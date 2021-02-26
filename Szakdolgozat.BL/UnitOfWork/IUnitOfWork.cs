using System;
using Szakdolgozat.BL.Interfaces;

namespace Szakdolgozat.BL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthorRepository Authors { get; }
        IBookAuthorRepository BookAuthors { get; }
        IBookRepository Books { get; }
        IJobRepository Jobs { get; }
        IPublisherRepository Publishers { get; }
        IRoleRepository Roles { get; }
        ISaleRepository Sales { get; }
        IStoreRepository Stores { get; }
        IUserRepository Users { get; }

        int Complate();
    }
}
