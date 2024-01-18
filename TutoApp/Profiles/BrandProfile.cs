using AutoMapper;
using TutoApp.Entity;

namespace TutoApp.Profiles
{
    public class BrandProfile:Profile
    {
        public BrandProfile() { 
        
            CreateMap<Brand,Brand>().ReverseMap();
        }
    }
}
