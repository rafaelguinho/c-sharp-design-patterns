using ChainOfResponsibility.Interfaces;

namespace ChainOfResponsibility.Handles.Discounts
{
    public class NoDiscount : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Discount(IBudget budget)
        {
            return 0;
        }
    }
}
