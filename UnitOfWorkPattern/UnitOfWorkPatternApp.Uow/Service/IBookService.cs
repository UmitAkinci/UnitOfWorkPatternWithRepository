using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Domain.Entity;

namespace UnitOfWorkPattern.Domain.Service
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllList();
    }
}
