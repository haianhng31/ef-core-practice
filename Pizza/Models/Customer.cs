using System.Collections.Generic;

namespace Pizza.Models 
{
    public class Customer 
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public ICollection<Order> Orders { get; set; } = null!;
        // Navigation Property: indicates that a customer can have a 0 or more orders 
        // Create 1 - Many relationship in the db 
        // Navigation properties are used to define the relationships between different entity classes in your data model.

        // Unlike IEnumerable<T>, which only supports enumeration, ICollection<T> supports adding and removing items.
        // It includes a Count property to get the number of items in the collection.
        
    }
}