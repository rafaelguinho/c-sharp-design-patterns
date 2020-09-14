using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Interfaces
{
    public interface IDiscount
    {
        double Discount(IBudget budget);

        IDiscount Next { get; set; }
    }
}
