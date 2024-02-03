using Coding.Challenge.DTO.Result;

namespace Coding.Challenge.Domain.Interfaces.Repositories;
public interface IBookRepository
{
    Task<List<BookResultDto>> GetBooksBySearch(string query, int size, int page);
}
