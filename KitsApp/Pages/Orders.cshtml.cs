using KitsApp.Data;
using KitsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KitsApp.Pages
{
	public class OrdersModel : PageModel
	{
        public List<KitOrder> KitOrders { get; private set; }

        private readonly ApplicationDbContext _context;

		public OrdersModel(ApplicationDbContext context)
		{
			_context = context;
		}

        public void OnGet()
        {
            var username = HttpContext.Session.GetString("Username");

            if (!string.IsNullOrEmpty(username))
            {
                KitOrders = _context.KitOrders.Where(order => order.Username == username).ToList();
            }
            else
            {
                KitOrders = new List<KitOrder>(); 
            }
        }
    }
}
