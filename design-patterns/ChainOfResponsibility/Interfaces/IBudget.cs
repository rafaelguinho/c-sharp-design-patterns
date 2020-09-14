using ChainOfResponsibility.Models;
using System.Collections.Generic;

namespace ChainOfResponsibility.Interfaces
{
    public interface IBudget
    {
        double GetValue();

        IList<Item> GetItens();

        void AddItem(Item item);
    }
}
