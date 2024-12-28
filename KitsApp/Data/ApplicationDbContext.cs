using KitsApp.Models;
using KitsApp.Pages;
using Microsoft.EntityFrameworkCore;

namespace KitsApp.Data
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<KitOrder> KitOrders { get; set; }
        public DbSet<User> Users { get; set; }
      
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
            
        }
    }
}
