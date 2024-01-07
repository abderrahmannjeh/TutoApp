using AutoMapper;
using TutoApp.Dto;
using TutoApp.Entity;

namespace TutoApp.Profiles
{
    public class LigneCommandeProfile: Profile
    {
        public LigneCommandeProfile() { 
        CreateMap<LigneCommande,LigneCommandeDTO>().ReverseMap();
        }
    }
}
