using Microsoft.EntityFrameworkCore;
using Sistema.Hello.Business.Entities;

namespace Sistema.Hello.Data.Context
{
    public class HelloContext : DbContext
    {
        public HelloContext() { }

        public HelloContext(DbContextOptions<HelloContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }


        /// <summary>
        /// --- DbSets ---
        /// ---
        /// Assuntos
        /// Agendamentos
        /// Atendimentos
        /// Cargos
        /// Cidadaos
        /// Colaboradores
        /// Historicos
        /// Setores
        /// Secretarias
        /// ---
        /// </summary>
        public DbSet<AssuntoAtendimento> Assuntos { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Atendimento> Atendimentos { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Cidadao> Cidadaos { get; set; }
        public DbSet<Colaborador> Calaboradores { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Secretaria> Secretarias { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Resolve o mapeamento do DbContext
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HelloContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
