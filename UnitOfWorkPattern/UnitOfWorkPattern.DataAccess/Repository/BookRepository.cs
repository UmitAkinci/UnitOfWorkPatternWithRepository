using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Domain.Entity;
using UnitOfWorkPattern.Domain.Repository;

namespace UnitOfWorkPattern.EntityFrameworkCore.Repository
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(UnitOfWorkPatternDbContext context) : base(context)
        {
        }

    }
}
