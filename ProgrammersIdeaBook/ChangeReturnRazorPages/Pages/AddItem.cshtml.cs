using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ChangeReturnRazorPages.Data;
using ChangeReturnRazorPages.Models;

namespace ChangeReturnRazorPages.Pages
{
    public class AddItemModel : PageModel
    {
        private readonly ChangeReturnDbContext _context;

        public AddItemModel(ChangeReturnDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var newProduct = new Product();
            if (await TryUpdateModelAsync<Product>(
                newProduct,
                "product",
                s => s.Name, s => s.Price, s => s.Stock))
            {
                _context.Products.Add(Product);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
