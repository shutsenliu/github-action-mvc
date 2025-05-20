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

            fries.Describe();          // �ڬO���Q������
            noSaltFries.Describe();    // �ڬO�L�Q������
            hamburger.Describe();      // �ڬO���q�~��
            bigHamburger.Describe();   // �ڬO�j���q�~��
            drink.Describe();          // �ڬO�i�ֶ���
            orangeJuice.Describe();    // �ڬO��Ķ���

            return View();
        }

    }
}
