using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using TutoApp.Entity;

namespace TutoApp.DBAccess
{
    public class TutoContext:IdentityDbContext<User>
    {

        public TutoContext(DbContextOptions<TutoContext> options) :base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<LigneCommande> LignesCommandes { get;set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<Brand> Brands { get; set; }



    }
}
