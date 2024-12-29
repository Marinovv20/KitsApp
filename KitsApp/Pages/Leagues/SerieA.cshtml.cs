using KitsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KitsApp.Pages.Leagues
{
    public class SerieAModel : PageModel
    {
        public List<KitsModel> Kits { get; private set; }

        private readonly List<KitsModel> fakeKitDb = new List<KitsModel>
        {
            new KitsModel { ImageTitle = "Juventus", KitName = "Juventus", KitNumber = "8", BasePrice = 50, Badge = true, FinalPrice = 52, League = "SerieA" },
            new KitsModel { ImageTitle = "ACMilan", KitName = "ACMilan", KitNumber = "9", BasePrice = 50, Badge = true, FinalPrice = 52, League = "SerieA" },
            new KitsModel { ImageTitle = "Inter", KitName = "Inter", KitNumber = "8", BasePrice = 50, Badge = true, FinalPrice = 52, League = "SerieA" },
            new KitsModel { ImageTitle = "Atalanta", KitName = "Atalanta", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "SerieA" },
            new KitsModel { ImageTitle = "Fiorentina", KitName = "Fiorentina", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "SerieA" },
        };

        public void OnGet()
        {
            Kits = fakeKitDb.Where(k => k.League == "SerieA").ToList();
        }
    }
}
