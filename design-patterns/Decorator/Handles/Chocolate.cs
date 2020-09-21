using Decorator.Abstract;

namespace Decorator.Handles
{
    public class Chocolate : Condiment
    {
        public Chocolate(Condiment condiment) : base(condiment)
        {
            _name = "Chocolate";
            _price = .6;
        }

        public Chocolate() : base()
        {
            _name = "Chocolate";
            _price = .6;
        }
    }
}
