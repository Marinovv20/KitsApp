using Microsoft.AspNetCore.Mvc;
using KitsApp.Data;
using KitsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KitsApp.Pages.Leagues
{
    public class Ligue1Model : PageModel
    {
        public List<KitsModel> Kits { get; private set; }

        private readonly List<KitsModel> fakeKitDb = new List<KitsModel>
        {
            new KitsModel { ImageTitle = "PSG", KitName = "PSG", KitNumber = "10", BasePrice = 50, Badge = true, FinalPrice = 52, League = "Ligue1" },
            new KitsModel { ImageTitle = "Monaco", KitName = "Monaco", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "Ligue1" },
            new KitsModel { ImageTitle = "OlympiquedeMarseille", KitName = "Olympique de Marseille", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "Ligue1" },
            
        };

        public void OnGet()
        {
            Kits = fakeKitDb.Where(k => k.League == "Ligue1").ToList();
        }
    }
}
