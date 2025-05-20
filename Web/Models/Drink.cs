using Web.Interface;

namespace Web.Models
{
    public class Drink : IProduct
    {
        private string _type = "可樂";

        public Drink()
        {
        }

        public Drink(string type)
        {
            _type = type;
        }

        public void Describe()
        {
            Console.WriteLine($"這是{_type}");
        }
    }
}
