using Web.Interface;

namespace Web.Models
{
    public class FrenchFries : IProduct
    {
        private string _state = "有鹽巴";

        public FrenchFries()
        {

        }

        public FrenchFries(string state)
        {
            _state = state;
        }

        public void Describe()
        {
            Console.WriteLine($"這是 {_state} 的薯條");
        }
    }
}
