
using KitsApp.Data;
using KitsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KitsApp.Pages.Checkout
{
	[BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
		public string KitName { get; set; }
		public string KitNumber { get; set; }
		public float KitPrice { get; set; }
		public string ImageTitle { get; set; }


		private readonly ApplicationDbContext _context;

		public CheckoutModel(ApplicationDbContext context)
		{
			_context = context;
		}

		public void OnGet()
        {
            var username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrWhiteSpace(username))
            {
                Response.Redirect("/Account/Login");
                return;
            }

            if (string.IsNullOrWhiteSpace(KitName))
			{
				KitName = "Custom";
			}
			if (string.IsNullOrWhiteSpace(ImageTitle))
			{
				ImageTitle = "Custom";
			}

            var kitOrder = new KitOrder
            {
                KitName = KitName,
                KitNumber = KitNumber,
                BasePrice = KitPrice,
                Username = username 
            };

            _context.KitOrders.Add(kitOrder);
			_context.SaveChanges();
		}
    }
}
