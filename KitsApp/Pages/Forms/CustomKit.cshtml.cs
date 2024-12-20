using KitsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KitsApp.Pages.Forms
{
    public class CustomKitModel : PageModel
    {
        [BindProperty]
        public KitsModel Kit { get; set; }
		public float KitPrice { get; set; }
		public void OnGet()
        {
        }

		public IActionResult OnPost()
		{
			KitPrice = Kit.BasePrice + 10;

			if (Kit.Badge) KitPrice += 2;

			return RedirectToPage("/Checkout/Checkout", new { Kit.KitName, Kit.KitNumber, KitPrice });
		}
	}
}
