using Assign4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assign4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> food = new List<string>();
            foreach (Restaurants b in Restaurants.GetRestaurant())
            {
                food.Add($"{b.Ranking}. {b.Name}  Favorite Dish:{b.FavDish}  Address:{b.Address} Phone Number: {b.Phone}  Website:{b.Website}");
                //for reference
                //bandList.Add(string.Format("#{0}: {1} ({2})", b.BandRanking, b.BandName, b.BandPoints);
                //or normal concatenate
            }

            return View(food);
        }
        [HttpGet("List")]
        public IActionResult SuggestionBox()
        {
            return View();
        }
        [HttpPost("List")]
        public IActionResult SuggestionBox(Suggestions appResponse)
        {
            TempStorage.AddApplication(appResponse);
            return View("Confirmation", appResponse);

        }
        public IActionResult SuggestedList()
        {
            return View(TempStorage.Suggestions);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
