using ChainOfResponsibility.Interfaces;
using ChainOfResponsibility.Models;
using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibility.Handles.Budgets
{
    public class DefaultBudget : IBudget
    {
        private double valor = 0;
        private IList<Item> itens = new List<Item>();

        public void AddItem(Item item)
        {
            itens.Add(item);
        }

        public IList<Item> GetItens()
        {
            return itens;
        }

        public double GetValue()
        {
            return itens.Sum(i => i.Value);
        }
    }
}
