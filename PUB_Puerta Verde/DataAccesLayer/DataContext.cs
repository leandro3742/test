using DataAccesLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class DataContext: IdentityDbContext<IdentityUser>
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=tcp:facubauza.database.windows.net,1433; Initial Catalog=PencaNet; Persist Security Info=False; User ID=facubauza; Password=FacundoBauza25; MultipleActiveResultSets=False; Encrypt=True; TrustServerCertificate=False; Connection Timeout=30;");
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-O6DTQ45\\ROOT;Initial Catalog=Pub_PuertaVerde;Encrypt=False;User ID=sa;Password=FacundoBauza25");
            }
        }

        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<ClientesPreferenciales> ClientesPreferenciales { get; set; }
        public DbSet<Ingredientes> Ingredientes { get; set; }
        public DbSet<Mesas> Mesas { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Pedidos_Productos> Pedidos_Productos { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Productos_Ingredientes> Productos_Ingredientes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
