using GeographicalApp.Business.Definitions.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace GeographicalApp.Business.Implementations
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions <DatabaseContext> options) : base(options)
        {

        }

        // Migrations via: dotnet ef migrations add NAME --project GeographicalApp.Business.Implementations --startup-project GeographicalApp.Web

        public DbSet<GeographicalDistrict> GeographicalDistrict { get; set; }
        public DbSet<Shape> Shape { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<GeographicalDistrict>()
                .HasOne<Shape>(it => it.Shape)
                .WithOne(it => it.GeographicalDistrict)
                .HasForeignKey<Shape>(it => it.GeographicalDistrict_Id);

        }
    }
}
