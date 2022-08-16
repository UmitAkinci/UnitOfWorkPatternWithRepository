using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Domain.Entity;

namespace UnitOfWorkPattern.Domain.Repository
{
    public interface IBookRepository:IRepository<Book>
    {
    }
}
