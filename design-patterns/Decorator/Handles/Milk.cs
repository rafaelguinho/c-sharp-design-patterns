using Decorator.Abstract;

namespace Patterns.Decorator
{
    public class Milk : Condiment
    {
        public Milk(Condiment drink)
            : base(drink)
        {
            _name = "Milk";
            _price = 0.19;
        }

        public Milk() : base()
        {
            _name = "Milk";
            _price = 0.19;
        }
    }
}
