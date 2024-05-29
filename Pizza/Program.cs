using Pizza.Data; 
using Pizza.Models;

using PizzaContext context = new PizzaContext();
// use a 'using' declaration to create a new instance of PizzaContext 
// this 'using' declaration ensures that the PizzaContext is disposed off properly when we're done using it

// =================================================================================
// ADD NEW ENTITY TO THE TABLE 
// Product veggieSpecial = new Product()
// {
//     Name = "Veggie Special Pizza",
//     Price = 9.99M
// };
// context.Products.Add(veggieSpecial);

// Product deluxeMeat = new Product() 
// {
//     Name = "Deluxe Meat Pizza",
//     Price = 12.99M
// };
// context.Add(deluxeMeat); // EF Core can infer it's a Product based on its type 

// =================================================================================
// QUERY 
// FLUENT API SYNTAX
// var products = context.Products.Where(p => p.Price > 10.00M).OrderBy(p => p.Name);

// LINQ SYNTAX 
// var products = from product in context.Products
//                where product.Price > 10.00M
//                orderby product.Name
//                select product;

// =================================================================================
// UPDATE AN ENTITY 
// var veggieSpecial = context.Products.Where(p => p.Name == "Veggie Special Pizza").FirstOrDefault();
// if (veggieSpecial is Product) 
// {
//     veggieSpecial.Price = 10.99M;
// }

// =================================================================================
// DELETE AN ENTITY 
// var veggieSpecial = context.Products.Where(p => p.Name == "Veggie Special Pizza").FirstOrDefault();
// if (veggieSpecial is Product) 
// {
//     context.Products.Remove(veggieSpecial);
// }

// =================================================================================

context.SaveChanges();

var products = from product in context.Products
               where product.Price > 10.00M
               orderby product.Name
               select product;

foreach(Product p in products) 
{
    Console.WriteLine($"{p.Name, -20} {p.Price, 10:C}");
}

