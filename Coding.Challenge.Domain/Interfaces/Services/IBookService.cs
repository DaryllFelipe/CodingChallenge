using Coding.Challenge.DTO.Result;

namespace Coding.Challenge.Domain.Interfaces.Services;
public interface IBookService
{
    Task<List<BookResultDto>> GetBooksBySearch(string query, int size, int page);
}
