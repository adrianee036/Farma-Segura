
using Fama_Segura.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fama_Segura.Infrastructure.Persistence.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Medicamentos> Medicamentos { get; set;}
        public DbSet<Laboratorio> laboratorios { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region primary key

            modelBuilder.Entity<Medicamentos>().ToTable("Medicamentos");
            modelBuilder.Entity<Laboratorio>().ToTable("Laboratorio");

            #endregion

            #region primary key

            modelBuilder.Entity<Medicamentos>().HasKey(x => x.IdMedicamento);
            modelBuilder.Entity<Laboratorio>().HasKey(x => x.IdLaboratorio);

            #endregion

            modelBuilder.Entity<Medicamentos>()
                .HasOne(x => x.Laboratorio)
                .WithMany(x => x.Medicamentos)
                .HasForeignKey(x => x.IdLaboratorio)
                .HasConstraintName("fk_Medicamentos_Laboratorio");


        }
    }
}
