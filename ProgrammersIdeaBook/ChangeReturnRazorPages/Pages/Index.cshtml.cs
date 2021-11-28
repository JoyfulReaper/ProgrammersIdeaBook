using ChangeReturnRazorPages.Data;
using ChangeReturnRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ChangeReturnRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public IList<Product> Products { get; set; }

        private readonly ChangeReturnDbContext _context;

        public IndexModel(ChangeReturnDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnPost(decimal totalChange)
        {
            totalChange = Math.Round(totalChange, 2);
            var units = CurrencyHelper.GetUSDCommonCoins();
            units.AddRange(CurrencyHelper.GetUSDCommonBills());

            var change = CurrencyHelper.CalculateChange(totalChange, units);

            change.All(c => { c.PluralName = char.ToUpper(c.PluralName[0]) + c.PluralName.Substring(1); return true; });
            var result = change.Select(x => new {x.PluralName, x.Quantity});

            return new JsonResult(result);
        }

        public async Task OnGet()
        {
            Products = await _context.Products.ToListAsync();
        }
    }
}