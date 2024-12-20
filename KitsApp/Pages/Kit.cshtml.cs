using KitsApp.Data;
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
            new Models.KitsModel() { ImageTitle = "ACMilan", KitName = "AC Milan", KitNumber = "10", BasePrice = 50, Badge = true, FinalPrice = 52 },
            new Models.KitsModel() { ImageTitle = "Arsenal", KitName = "Arsenal", KitNumber = "8", BasePrice = 50, Badge=true, FinalPrice = 52 },
            new Models.KitsModel() { ImageTitle = "Barcelona", KitName = "Barcelona", KitNumber = "10", BasePrice = 50, Badge = true, FinalPrice = 52 },
            new Models.KitsModel() { ImageTitle = "BayernMunich", KitName = "Bayern Munich", KitNumber = "10",BasePrice = 50, Badge = true, FinalPrice = 52 },
            new Models.KitsModel() { ImageTitle = "Inter", KitName = "Inter Milan", KitNumber = "9", BasePrice = 50, Badge = true, FinalPrice = 52 },
            new Models.KitsModel() { ImageTitle = "ManCity", KitName = "Manchester City", KitNumber = "9", BasePrice = 50, Badge = true, FinalPrice = 52 },
            new Models.KitsModel() { ImageTitle = "ManUtd", KitName = "Manchester United", KitNumber = "8", BasePrice = 50, Badge = true, FinalPrice = 52 },
            new Models.KitsModel() { ImageTitle = "PSG", KitName = "PSG", KitNumber = "10", BasePrice = 50, Badge = true, FinalPrice = 52 },
            new Models.KitsModel() { ImageTitle = "RealMadrid", KitName = "Real Madrid", KitNumber = "7", BasePrice = 50, Badge = true, FinalPrice = 52 },
        };

        public void OnGet()
        {
        }

        
    }
}
