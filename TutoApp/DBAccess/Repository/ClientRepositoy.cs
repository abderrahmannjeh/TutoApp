using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TutoApp.DBAccess.IRepository;
using TutoApp.Entity;

namespace TutoApp.DBAccess.Repository
{
    public class ClientRepositoy<TEntity> : GenericRepository<TEntity> ,IClientRepository<TEntity> where TEntity : Client
    {
        public ClientRepositoy(TutoContext dbContext) : base(dbContext)
        {
        }
    }
}
