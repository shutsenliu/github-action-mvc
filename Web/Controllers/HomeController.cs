using Microsoft.AspNetCore.Mvc;
using Web.Factory;
using Web.Interface;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            FastFoodFactory factory = new FastFoodFactory();
            
            IProduct fries = factory.GetProduct("Fries");
            IProduct noSaltFries = factory.GetProduct("FriesNoSalt");
            IProduct hamburger = factory.GetProduct("Hamburger");
            IProduct bigHamburger = factory.GetProduct("BigHamburger");
            IProduct drink = factory.GetProduct("Drink");
            IProduct orangeJuice = factory.GetProduct("OrangeJuice");

            fries.Describe();          // 我是有鹽巴薯條
            noSaltFries.Describe();    // 我是無鹽的薯條
            hamburger.Describe();      // 我是普通漢堡
            bigHamburger.Describe();   // 我是大份量漢堡
            drink.Describe();          // 我是可樂飲料
            orangeJuice.Describe();    // 我是橙汁飲料

            return View();
        }

    }
}
