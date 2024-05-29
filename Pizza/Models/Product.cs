using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pizza.Models 
{
    public class Product 
    {
        [Key] // indicates this is the primary key
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        // in .NET 6, all projects enable nullable references by default 
        // The null! is a null-forgiving operator that tells the compiler to ignore nullability checks for this assignment. 
        // It indicates that you, the developer, are certain that Name will be initialized to a non-null value before it is accessed.

        // If you have a property that should not be null in the database, 
        // but you want to allow the compiler to recognize it as nullable in the code, 
        // you can use the [Required] attribute. 
        // This attribute ensures that the property is required and must have a value before the entity is saved to the database.

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        // [Column(...)]: This attribute is used to specify column-specific properties for the Price field in the database.
        // 1. It provides precise control over how your property is represented in the database. 
        // By specifying decimal(6, 2), you ensure that the column will be created with the exact precision and scale you need.
        // 2. It helps maintain data integrity by ensuring that only values with the specified precision and scale are stored in the database. 
        // 3. It ensures consistency between your C# code and the database schema, 
        // reducing the risk of discrepancies and bugs that can arise from mismatched data types.

    }
}