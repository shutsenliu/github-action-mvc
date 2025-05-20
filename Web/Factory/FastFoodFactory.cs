using Web.Interface;
using Web.Models;

namespace Web.Factory
{
    public class FastFoodFactory
    {
        public IProduct GetProduct(string productType)
        {
            if (productType == "Fries")
            {
                return new FrenchFries();
            }
            else if (productType == "FriesNoSalt")
            {
                return new FrenchFries("無鹽的");
            }
            else if (productType == "Hamburger")
            {
                return new Hamburger();
            }
            else if (productType == "BigHamburger")
            {
                return new Hamburger("大份量");
            }
            else if (productType == "Drink")
            {
                return new Drink();
            }
            else if (productType == "OrangeJuice")
            {
                return new Drink("橙汁");
            }
            else
            {
                throw new ArgumentException("不支援的產品類型");
            }
        }
    }
}
