using TutoApp.Entity;

namespace TutoApp.DBAccess.IRepository
{
    public interface ICommandeRepository<Tentity> : IGenericRepository<Tentity> where Tentity : Commande
    {
    }
}
