using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Domain.Repository;

namespace UnitOfWorkPattern.Domain.Uow
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository BookRepository { get; }
        Task<int> CommitAsync();
    }
}
