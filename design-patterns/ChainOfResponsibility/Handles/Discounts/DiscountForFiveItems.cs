using ChainOfResponsibility.Interfaces;

namespace ChainOfResponsibility.Handles.Discounts
{
    internal class DiscountForFiveItems : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Discount(IBudget budget)
        {
            if(budget.GetItens().Count >= 5)
            {
                return budget.GetValue() * 0.1;
            }
            else
            {
                return Next.Discount(budget);
            }
        }
    }
}
