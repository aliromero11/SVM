using Microsoft.EntityFrameworkCore;
using SVM.Models;

namespace SVM.Data
{
    public class ProductosDbContext : DbContext
    {
        public DbSet<ProductosModel> ProductosModel { get; set; }
        public DbSet<MaterialPolo> MaterialPolo { get; set; }
        public DbSet<ModeloPolo> ModeloPolo { get; set; }
        public DbSet<TallaPolo> TallaPolo { get; set; }
        public DbSet<ColeccionPolo> ColeccionPolo { get; set; }
        public DbSet<ColorPolo> ColorPolo { get; set; }

        public ProductosDbContext(DbContextOptions<ProductosDbContext> o) : base(o) 
        {

        }
    }
}