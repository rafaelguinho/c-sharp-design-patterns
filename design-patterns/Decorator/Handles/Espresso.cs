using Decorator.Abstract;

namespace Decorator.Handles
{
    public class Espresso : Condiment
    {
        public Espresso(Condiment condiment) : base(condiment)
        {
            _name = "Espresso";
            _price = 3.2;
        }

        public Espresso() : base()
        {
            _name = "Espresso";
            _price = 3.2;
        }
    }
}
