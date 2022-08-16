using Microsoft.AspNetCore.Mvc;
using UnitOfWorkPattern.Domain.Entity;
using UnitOfWorkPattern.Domain.Uow;

namespace UnitOfWorkPattern.UI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IEnumerable<Book>> GetAllListAsync()
        {
            return await _unitOfWork.BookRepository.GetAllAsync();

        }

        public async Task MyTestMethodAsync()
        {
            await _unitOfWork.BookRepository.AddAsync(new Book { Id = Guid.NewGuid(), Name = "Çalıkuşu" });
            await _unitOfWork.CommitAsync();
        }
    }
}
