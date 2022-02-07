using Domain.Models;
using InfraData.Mapping;
using Microsoft.EntityFrameworkCore;

namespace InfraData.DataContext
{
    public  class PetsDataContext : DbContext
    {
        public PetsDataContext(DbContextOptions<PetsDataContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PetsDataContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }


    }
}
