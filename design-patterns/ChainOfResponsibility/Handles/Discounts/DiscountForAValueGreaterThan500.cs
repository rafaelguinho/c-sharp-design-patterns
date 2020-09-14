using ChainOfResponsibility.Interfaces;

namespace ChainOfResponsibility.Handles.Discounts
{
    internal class DiscountForAValueGreaterThan500: IDiscount
    {
        public IDiscount Next { get; set; }

        public double Discount(IBudget budget)
        {
            if (budget.GetValue() > 500)
            {
                return budget.GetValue() * 0.07;
            }
            else
            {
                return Next.Discount(budget);
            }
        }
    }
}
