using Microsoft.EntityFrameworkCore;
using NT_ApartmenstsEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT_ApartmenstsEFCore.Data
{
    public class DataContext : DbContext
    {
        public DbSet<BrokerModel> Brokers { get; set; }

        public DbSet<CompanyModel> Companies { get; set; }

        public DbSet<ApartmentModel> Houses { get; set; }

        public DbSet<CompanyBroker> CompanyBrokers { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<BrokerModel>()
            //  .Property(b => b.Name)
            //  .HasPrecision(20);

            modelBuilder.Entity<CompanyModel>()
                .HasMany(c => c.Brokers)
                .WithOne(i => i.Company)
                .HasForeignKey(ci => ci.CompanyId);

            modelBuilder.Entity<CompanyBroker>()
                .HasKey(cb => new { cb.CompanyId, cb.BrokerId });

            modelBuilder.Entity<CompanyBroker>()
                .HasOne(bc => bc.Company)
                .WithMany(c => c.CompanyBrokers)
                .HasForeignKey(bc => bc.CompanyId);
        }

    }
}
