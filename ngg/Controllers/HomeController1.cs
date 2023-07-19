using Microsoft.AspNetCore.Mvc;

namespace ngg.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Random()
        {
            var house = new HouseModel() { Name = " VILA " };
            return View(house);
           
        }
    }
}