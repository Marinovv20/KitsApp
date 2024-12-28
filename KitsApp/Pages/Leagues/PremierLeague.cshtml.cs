using KitsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KitsApp.Pages.Leagues
{
    public class PremierLeagueModel : PageModel
    {
        public List<KitsModel> Kits { get; private set; }

        private readonly List<KitsModel> fakeKitDb = new List<KitsModel>
        {
            new KitsModel { ImageTitle = "Arsenal", KitName = "Arsenal", KitNumber = "8", BasePrice = 50, Badge = true, FinalPrice = 52, League = "PremierLeague" },
            new KitsModel { ImageTitle = "ManCity", KitName = "Manchester City", KitNumber = "9", BasePrice = 50, Badge = true, FinalPrice = 52, League = "PremierLeague" },
            new KitsModel { ImageTitle = "ManUtd", KitName = "Manchester United", KitNumber = "8", BasePrice = 50, Badge = true, FinalPrice = 52, League = "PremierLeague" },
            new KitsModel { ImageTitle = "Liverpool", KitName = "Liverpool", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "PremierLeague" },
            new KitsModel { ImageTitle = "Chelsea", KitName = "Chelsea", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "PremierLeague" },
        };

        public void OnGet()
        {
            Kits = fakeKitDb.Where(k => k.League == "PremierLeague").ToList();
        }
    }
}
