using KitsApp.Data;
using KitsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KitsApp.Pages.Leagues
{
    public class BundesligaModel : PageModel
    {
        public List<KitsModel> Kits { get; private set; }

        private readonly List<KitsModel> fakeKitDb = new List<KitsModel>
        {
            new KitsModel { ImageTitle = "BayernMunich", KitName = "Bayern Munich", KitNumber = "10", BasePrice = 50, Badge = true, FinalPrice = 52, League = "Bundesliga" },
            new KitsModel { ImageTitle = "BVB", KitName = "BVB", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "Bundesliga" },
            new KitsModel { ImageTitle = "BayerLeverkusen", KitName = "Bayer Leverkusen", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "Bundesliga" },
        };

        public void OnGet()
        {
            Kits = fakeKitDb.Where(k => k.League == "Bundesliga").ToList();
        }
    }
}
