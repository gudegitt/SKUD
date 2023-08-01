using ClassLibrary_1.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_1
{
    public class EFDBContext : DbContext
    {
        public DbSet<Entityes.Directory> Directory { get; set; }
        public DbSet<Material> Material { get; set; }

        public EFDBContext(DbContextOptions<EFDBContext>options) : base(options) { }
    }

    public class EFDBContextFactory : IDesignTimeDbContextFactory<EFDBContext>
    {
        public EFDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EFDBContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SKUDNumberBase;Trusted_Connection=True;MultipleActiveResultSets=True", b => b.MigrationsAssembly("ClassLibrary_1"));

            return new EFDBContext(optionsBuilder.Options);
        }
    }
}
