using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaWeb.Data;
using PizzaWeb.Models;

namespace PizzaWeb.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly PizzaWeb.Data.Pizza2Context _context;

        public IndexModel(PizzaWeb.Data.Pizza2Context context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
