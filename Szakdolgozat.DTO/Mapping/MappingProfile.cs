using AutoMapper;
using Szakdolgozat.DTO.Models;
using Szakdolgozat.DTO.ViewModels;

namespace Szakdolgozat.DTO.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Author, AuthorVm>().ReverseMap();
            CreateMap<BookAuthor, BookAuthorVm>().ReverseMap();
            CreateMap<Book, BookVm>().ReverseMap();
            CreateMap<Job, JobVm>().ReverseMap();
            CreateMap<Publisher, PublisherVm>().ReverseMap();
            CreateMap<Sale, SaleVm>().ReverseMap();
            CreateMap<Store, StoreVm>().ReverseMap();
        }
    }
}
