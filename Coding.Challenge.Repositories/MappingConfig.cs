using AutoMapper;
using Coding.Challenge.DTO.Result;
using Coding.Challenge.Repositories.Models;
namespace Coding.Challenge.Repositories;

internal class MappingConfig : Profile
{
    public MappingConfig()
    {
        CreateMap<Book, BookResultDto>();
    }
}
