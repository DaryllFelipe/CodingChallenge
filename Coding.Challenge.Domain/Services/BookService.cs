using Coding.Challenge.Domain.Interfaces.Repositories;
using Coding.Challenge.Domain.Interfaces.Services;
using Coding.Challenge.DTO.Result;

namespace Coding.Challenge.Domain.Services
{
    internal class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<List<BookResultDto>> GetBooksBySearch(string query, int size, int page)
            => await _bookRepository.GetBooksBySearch(query, size, page);
    }
}
