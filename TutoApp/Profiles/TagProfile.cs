using AutoMapper;
using TutoApp.Dto;
using TutoApp.Entity;

namespace TutoApp.Profiles
{
    public class TagProfile:Profile
    {
        public TagProfile() { 
        
            CreateMap<Tag,TagDTO>().ReverseMap();
        
        }
    }
}
