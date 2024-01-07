using TutoApp.Entity;

namespace TutoApp.DBAccess.IRepository
{
    public interface ILigneCommandeRepository<TEntity> : IGenericRepository<TEntity> where TEntity :LigneCommande
    {
    }
}
