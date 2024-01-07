using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TutoApp.DBAccess.IRepository;
using TutoApp.Entity;

namespace TutoApp.DBAccess.Repository
{
    public class LigneCommandeRepositoy<TEntity> : GenericRepository<TEntity>,ILigneCommandeRepository<TEntity> where TEntity : LigneCommande
    {
        public LigneCommandeRepositoy(TutoContext dbContext) : base(dbContext)
        {
        }
    }
}
