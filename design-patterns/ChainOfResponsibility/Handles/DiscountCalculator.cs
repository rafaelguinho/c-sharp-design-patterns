using ChainOfResponsibility.Handles.Discounts;
using ChainOfResponsibility.Interfaces;

namespace ChainOfResponsibility.Handles
{
    internal class DiscountCalculator : ICalculator
    {
        public double Calculate(IBudget budget)
        {
            IDiscount d1 = new DiscountForFiveItems();
            IDiscount d2 = new DiscountForAValueGreaterThan500();
            IDiscount d3 = new NoDiscount();

            d1.Next = d2;
            d2.Next = d3;

            return d1.Discount(budget);
        }
    }
}
