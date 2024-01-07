using TutoApp.Entity;

namespace TutoApp.DBAccess.IRepository
{
    public interface IClientRepository<Tentity> : IGenericRepository<Tentity> where Tentity :Client
    {
    }
}
