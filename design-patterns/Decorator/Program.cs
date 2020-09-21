using Decorator.Handles;
using Decorator.Interfaces;
using Patterns.Decorator;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IDrink espresso = new Espresso(new Chocolate(new Milk()));

            Console.WriteLine(espresso.GetDescription());
            Console.WriteLine(espresso.GetCost());
        }
    }
}
