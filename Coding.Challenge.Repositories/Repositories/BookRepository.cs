using AutoMapper;
using Coding.Challenge.Domain.Interfaces.Repositories;
using Coding.Challenge.DTO.Result;

namespace Coding.Challenge.Repositories.Repositories;
internal class BookRepository : IBookRepository, IDisposable
{
    private readonly Context MyContext;
    private readonly IMapper _mapper;
    public BookRepository(IMapper mapper)
    {
        _mapper = mapper;
        MyContext = new();
    }


    public Task<List<BookResultDto>> GetBooksBySearch(string query, int size, int page)
    {
        try
        {
            var allBooks = MyContext.Books.ToList() ?? [];

            if (allBooks != null && allBooks.Count > 0)
            {
                var result = allBooks.Where(b => b.Title.Contains(query, StringComparison.OrdinalIgnoreCase)
                            || b.Description.Contains(query, StringComparison.OrdinalIgnoreCase))
                                .Skip(size * (page - 1)).Take(size).ToList() ?? [];
                if (result != null && result.Count > 0)
                {
                    var books = _mapper.Map<List<BookResultDto>>(result);
                    var categories = MyContext.Categories.ToList();
                    if (categories != null && categories.Count > 0)
                    {
                        foreach (var book in books)
                        {
                            book.Category = categories.FirstOrDefault(c => c.Id == book.CategoryId).Name ?? string.Empty;
                        }
                    }
                    return Task.FromResult(books);
                }
            }
        }
        catch (Exception ex)
        {

            throw ex;
        }

        return Task.FromResult(new List<BookResultDto>());
    }

    public void Dispose()
    {
        MyContext.Dispose();
    }
}