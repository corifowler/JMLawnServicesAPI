using Microsoft.EntityFrameworkCore;
using JMLawnServicesAPI.Data.Entities;

namespace JMLawnServicesAPI.Data.DatabaseContexts
{
    public class JMLawnServicesAPIDbContext  : DbContext
    {
        public DbSet<Estimate> Estimates { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\John Monarchik\\Desktop\\Projects\\JMLawnServicesAPI\\src\\Database\\JMLawnServicesEntities.db");
            // optionsBuilder.UseSqlite("Data Source=D:\\Projects\\Matrix-ServicesAPI\\src\\Database\\MyMatrixEntities.db");
        }

    }
}