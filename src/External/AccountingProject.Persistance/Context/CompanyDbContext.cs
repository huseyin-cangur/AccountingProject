
using AccountingProject.Domain.Abstraction;
using AccountingProject.Domain.App.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AccountingProject.Persistance.Context
{
    public class CompanyDbContext : DbContext
    {
        private string _connectionString = "";

        public CompanyDbContext(Company? company = null)
        {
            if (company != null)
            {
                if (company.DatabaseUserId == "")
                {
                    _connectionString = $"Data Source={company.DatabaseServerName}; Initial Catalog={company.DatabaseName};Integrated Security=True;TrustServerCertificate=True";
                }
                else
                {
                    _connectionString = $"Data Source={company.DatabaseServerName}; Initial Catalog={company.DatabaseName}; User Id={company.DatabaseUserId}; Password={company.DatabasePassword} Integrated Security=True;TrustServerCertificate=True";
                }
            }


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReference).Assembly);
        }

        public class CompanyDbContextFactory : IDesignTimeDbContextFactory<CompanyDbContext>
        {

            public CompanyDbContext CreateDbContext(string[] args)
            {
                return new CompanyDbContext();
            }
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<Entity>();
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                  
                    entry.Property(p => p.CreatedDate).CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property(p => p.UpdatedDate).CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);

        }
    }
}