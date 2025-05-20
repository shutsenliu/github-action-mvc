using Web.Interface;

namespace Web.Models
{
    public class Hamburger : IProduct
    {
        private string _size = "普通";

        public Hamburger()
        {
        }

        public Hamburger(string size)
        {
            _size = size;
        }

        public void Describe()
        {
            Console.WriteLine($"這是 {_size} 的漢堡");
        }
    }
}
