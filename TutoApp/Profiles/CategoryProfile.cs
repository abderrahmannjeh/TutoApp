using AutoMapper;
using TutoApp.Dto;
using TutoApp.Entity;

namespace TutoApp.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile() { 
        
            CreateMap<Category,CategoryDTO>().ReverseMap();
        
        }
    }
}
