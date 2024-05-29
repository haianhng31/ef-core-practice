using Pizza.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Pizza.Data 
{ 
    public class PizzaContext: DbContext 
    // think of DbContext as representing a session within the db 
    { 
        public DbSet<Customer> Customers { get; set; } = null!;
        // each DbSet maps to a table that will be created in the DB 
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            // optionsBuilder.UseMySql("server=localhost;port=3306;database=mydatabase;uid=root;pwd=Iamamazing313.",
            //                  new MySqlServerVersion(new Version(8, 0, 26)));

             
            // optionsBuilder.UseSqlServer(@"Server=172.17.0.2;Port=1433;Database=Pizza;User Id=haianhng31;Password=Iamamazing313.;Trusted_Connection=True;");
            // optionsBuilder.UseSqlServer(@"Server=172.17.0.2;Database=Pizza;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Pizza;User Id=SA;Password=Iamamazing313.;TrustServerCertificate=true;");

        }
    }
}