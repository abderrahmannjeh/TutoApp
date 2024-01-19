using AutoMapper;
using TutoApp.Dto;
using TutoApp.Entity;

namespace TutoApp.Profiles
{
    public class BrandProfile:Profile
    {
        public BrandProfile() { 
        
            CreateMap<Brand,BrandDTO>().ReverseMap();
        }
    }
}
