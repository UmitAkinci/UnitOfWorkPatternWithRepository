using UnitOfWorkPattern.Domain.Repository;
using UnitOfWorkPattern.Domain.Uow;
using UnitOfWorkPattern.EntityFrameworkCore;
using UnitOfWorkPattern.EntityFrameworkCore.Repository;

namespace MusicMarket.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UnitOfWorkPatternDbContext context;
        private BookRepository _bookRepository;

        public UnitOfWork(UnitOfWorkPatternDbContext context)
        {
            this.context = context;
        }

        public IBookRepository BookRepository => _bookRepository = _bookRepository ?? new BookRepository(context);

        public async Task<int> CommitAsync()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
