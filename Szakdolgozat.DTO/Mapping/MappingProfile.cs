using AutoMapper;
using Szakdolgozat.DTO.Models;
using Szakdolgozat.DTO.ViewModels;

namespace Szakdolgozat.DTO.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AuthorCo, AuthorVm>().ReverseMap();
            CreateMap<BookAuthorCo, BookAuthorVm>().ReverseMap();
            CreateMap<BookCo, BookVm>().ReverseMap();
            CreateMap<JobCo, JobVm>().ReverseMap();
            CreateMap<PublisherCo, PublisherVm>().ReverseMap();
            CreateMap<RoleCo, RoleVm>().ReverseMap();
            CreateMap<SaleCo, SaleVm>().ReverseMap();
            CreateMap<StoreCo, StoreVm>().ReverseMap();
            CreateMap<UserCo, UserVm>().ReverseMap();
        }
    }
}
