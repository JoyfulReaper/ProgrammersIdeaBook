using FractionCalcRazorPages.Helpers;
using FractionCalcRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FractionCalcRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<string> Fractions { get; set; } = new List<string>();

        [BindProperty]
        public string Option { get; set; } = string.Empty;

        public string Result { get; set; } = String.Empty;

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            var models = new List<Fraction>();
            foreach (var fraction in Fractions)
            {
                if (FractionHelper.TryParseFraction(fraction, out Fraction res))
                {
                    models.Add(res);
                } 
                else
                {
                    throw new Exception("Invalid Fraction!");
                }
            }

            Fraction output = models[0];
            for(int i = 1; i< models.Count; i++)
            {
                switch (Option)
                {
                    case "Add":
                        output += models[i];
                        break;
                    case "Subtract":
                        output -= models[i];
                        break;
                    case "Divide":
                        output /= models[i];
                        break;
                    case "Multiply":
                        output *= models[i];
                        break;
                    case "LCDGCD":
                        var dens = models.Select(x => x.Denominator);
                        Result = $"LCD: {FractionHelper.FindGreatestCommonFactor(dens.ToArray())} GCD: {FractionHelper.FindGreatestCommonFactor(dens.ToArray())}";
                        break;
                    default:
                        Result = "Something went wrong :(";
                        break;
                }
            }
            if (Option != "LCDGCD")
            {
                Result = output.ToString();
            }

            return Page();
        }
    }
}