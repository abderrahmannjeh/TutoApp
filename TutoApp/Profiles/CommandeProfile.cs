using AutoMapper;
using TutoApp.Dto;
using TutoApp.Entity;

namespace TutoApp.Profiles
{
    public class CommandeProfile : Profile
    {
        public CommandeProfile() { 
        CreateMap<Commande,CommandeDTO>().ReverseMap();
        }
    }
}
