

using Decorator.Interfaces;

namespace Decorator.Abstract
{
    public abstract class Condiment : IDrink
    {
        IDrink _drink;

        protected string _name = "";
        protected double _price = 0.0;

        public Condiment(IDrink drink)
        {
            _drink = drink;
        }

        public Condiment()
        {
            _drink = null;
        }

        public string GetDescription()
        {
            if(_drink != null)
            {
                return $"{_drink.GetDescription()} {_name}";
            }
            else
            {
                return $"{_name}";
            }

        }

        public double GetCost()
        {
            if (_drink != null)
            {
                return _drink.GetCost() + _price;
            }
            else
            {
                return  _price;
            }
        }
    }
}
