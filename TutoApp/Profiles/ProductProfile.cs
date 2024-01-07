using AutoMapper;
using TutoApp.Dto;
using TutoApp.Entity;

namespace TutoApp.Profiles
{
    public class ProductProfile: Profile
    {
        public ProductProfile() { 
        CreateMap<Product,ProductDTO>().ReverseMap();
        }
    }
}
