using KitsApp.Data;
using KitsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KitsApp.Pages.Leagues
{
    public class LaLigaModel : PageModel
    {
        public List<KitsModel> Kits { get; private set; }

        private readonly List<KitsModel> fakeKitDb = new List<KitsModel>
        {
            new KitsModel { ImageTitle = "RealMadrid", KitName = "Real Madrid", KitNumber = "10", BasePrice = 50, Badge = true, FinalPrice = 52, League = "LaLiga" },
            new KitsModel { ImageTitle = "Barcelona", KitName = "Barcelona", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "LaLiga" },
            new KitsModel { ImageTitle = "AtleticoMadrid", KitName = "Atletico Madrid", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "LaLiga" },
            new KitsModel { ImageTitle = "Girona", KitName = "Girona", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "LaLiga" },
        };

        public void OnGet()
        {
            Kits = fakeKitDb.Where(k => k.League == "LaLiga").ToList();
        }
    }
}
