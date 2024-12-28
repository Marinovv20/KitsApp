using KitsApp.Data;
using KitsApp.Migrations;
using KitsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace KitsApp.Pages
{
    public class KitModel : PageModel
    {

        public List<KitsModel> fakeKitDb = new List<KitsModel>()
        {
            new Models.KitsModel() { ImageTitle = "ACMilan", KitName = "AC Milan", KitNumber = "10", BasePrice = 50, Badge = true, FinalPrice = 52, League = "SerieA"},
            new Models.KitsModel() { ImageTitle = "Arsenal", KitName = "Arsenal", KitNumber = "8", BasePrice = 50, Badge=true, FinalPrice = 52, League = "PremierLeague" },
            new Models.KitsModel() { ImageTitle = "Barcelona", KitName = "Barcelona", KitNumber = "10", BasePrice = 50, Badge = true, FinalPrice = 52, League = "LaLiga" },
            new Models.KitsModel() { ImageTitle = "BayernMunich", KitName = "Bayern Munich", KitNumber = "10",BasePrice = 50, Badge = true, FinalPrice = 52, League = "Bundesliga" },
            new Models.KitsModel() { ImageTitle = "Inter", KitName = "Inter Milan", KitNumber = "9", BasePrice = 50, Badge = true, FinalPrice = 52, League = "SerieA"},
            new Models.KitsModel() { ImageTitle = "ManCity", KitName = "Manchester City", KitNumber = "9", BasePrice = 50, Badge = true, FinalPrice = 52, League = "PremierLeague" },
            new Models.KitsModel() { ImageTitle = "ManUtd", KitName = "Manchester United", KitNumber = "8", BasePrice = 50, Badge = true, FinalPrice = 52, League = "PremierLeague" },
            new Models.KitsModel() { ImageTitle = "PSG", KitName = "PSG", KitNumber = "10", BasePrice = 50, Badge = true, FinalPrice = 52, League = "Ligue1" },
            new Models.KitsModel() { ImageTitle = "RealMadrid", KitName = "Real Madrid", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "LaLiga" },
            new Models.KitsModel() { ImageTitle = "Juventus", KitName = "Juventus", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "SerieA"},
            new Models.KitsModel() { ImageTitle = "Liverpool", KitName = "Liverpool", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "PremierLeague" },
            new Models.KitsModel() { ImageTitle = "BVB", KitName = "BVB", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "Bundesliga" },
            new Models.KitsModel() { ImageTitle = "BayerLeverkusen", KitName = "Bayer Leverkusen", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "Bundesliga" },
            new Models.KitsModel() { ImageTitle = "Monaco", KitName = "Monaco", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "Ligue1" },
            new Models.KitsModel() { ImageTitle = "AtleticoMadrid", KitName = "Atletico Madrid", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "LaLiga" },
            new Models.KitsModel() { ImageTitle = "Chelsea", KitName = "Chelsea", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "PremierLeague" },
            new Models.KitsModel() { ImageTitle = "Girona", KitName = "Girona", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "LaLiga" },
            new Models.KitsModel() { ImageTitle = "Atalanta", KitName = "Atalanta", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "SerieA" },
            new Models.KitsModel() { ImageTitle = "Tottenham", KitName = "Tottenham", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52, League = "PremierLeague" },
        };

        public void OnGet()
        {
        }

        
    }
}
