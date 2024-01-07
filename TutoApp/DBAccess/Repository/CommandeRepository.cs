using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TutoApp.DBAccess.IRepository;
using TutoApp.Entity;

namespace TutoApp.DBAccess.Repository
{
    public class CommandeRepository<TEntity> : GenericRepository<TEntity> ,ICommandeRepository<TEntity>  where TEntity : Commande
    {
        public CommandeRepository(TutoContext dbContext) : base(dbContext)
        {
        }
    }
}
