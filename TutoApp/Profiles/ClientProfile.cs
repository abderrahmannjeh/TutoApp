using AutoMapper;
using TutoApp.Dto;
using TutoApp.Entity;

namespace TutoApp.Profiles
{
    public class ClientProfile: Profile
    {
        public ClientProfile() { 
        CreateMap<Client,ClientDTO>().ReverseMap();
        }
    }
}
