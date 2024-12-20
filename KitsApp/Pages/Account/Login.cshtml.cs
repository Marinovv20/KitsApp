using KitsApp.Data;
using KitsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography;
using System.Text;

namespace KitsApp.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public LoginModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty] 
        public string Username { get; set; }
        [BindProperty] 
        public string Password { get; set; }

        public IActionResult OnPost()
        {
            var hashedPassword = HashPassword(Password);

            var user = _context.Users.FirstOrDefault(u => u.Username == Username && u.PasswordHash == hashedPassword);

            if (user == null)
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return Page();
            }

            HttpContext.Session.SetString("Username", user.Username);
            return RedirectToPage("/Index");
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                return Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(password)));
            }
        }
    }
}
