using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Interfaces
{
    public interface ICalculator
    {
        double Calculate(IBudget budget);
    }
}
