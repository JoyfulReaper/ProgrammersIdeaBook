using ChangeReturnRazorPages.Data;
using ChangeReturnRazorPages.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ChangeReturnRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public IList<Product> Products { get; set; }

        private readonly ChangeReturnDbContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;

        public IndexModel(ChangeReturnDbContext context, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> OnPost(decimal totalChange, int productId)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == productId);
            if (product == null)
            {
                return NotFound();
            }

            product.Stock--;
            await _context.SaveChangesAsync();

            totalChange = Math.Round(totalChange, 2);
            var units = CurrencyHelper.GetUSDCommonCoins();
            units.AddRange(CurrencyHelper.GetUSDCommonBills());
            var change = CurrencyHelper.CalculateChange(totalChange, units);

            change.All(c => { c.PluralName = char.ToUpper(c.PluralName[0]) + c.PluralName.Substring(1); return true; });
            var changeOutput = change.Select(x => new {x.PluralName, x.Quantity});

            var result = new {Change = changeOutput, Stock = (await _context.Products.FirstOrDefaultAsync(x => x.Id == productId))?.Stock ?? 0};
            return new JsonResult(result);
        }

        public async Task<IActionResult> OnPostDelete(int productId)
        {
            if(_signInManager.IsSignedIn(User))
            {
                var item = await _context.Products.FirstOrDefaultAsync(x => x.Id == productId);

                if(item == null)
                {
                    return NotFound();
                }

                _context.Products.Remove(item);
                await _context.SaveChangesAsync();
            } 
            else
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }

            return StatusCode(StatusCodes.Status200OK);
        }

        public async Task OnGet()
        {
            if (!_signInManager.IsSignedIn(User))
            {
                Products = await _context.Products.Where(x => x.Stock > 0).ToListAsync();
            }
            else
            {
                Products = await _context.Products.ToListAsync();
            }
        }
    }
}