using System.Collections.Generic;

namespace Pizza.Models 
{
    public class Order 
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        public int CustomerId { get; set; } // Foreign key property
        // this represents the FK relationship with the customer table 
        // if we don't have this, EF Core will generate it anw => Shadow property 
        // a shadow property is a property that is not defined in your C# class but is managed by EF Core in the model. 
        // Shadow properties are useful when you want to store data in the database that you do not want to expose in your entity class.

        public Customer Customer { get; set; } = null!; // Navigation property 
        public ICollection<OrderDetail> OrderDetails { get; set; } = null!;

    }
}