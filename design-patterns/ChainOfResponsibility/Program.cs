using ChainOfResponsibility.Handles;
using ChainOfResponsibility.Handles.Budgets;
using ChainOfResponsibility.Interfaces;
using ChainOfResponsibility.Models;
using System;

namespace ChainOfResponsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new DiscountCalculator();

            IBudget budget = new DefaultBudget();
            budget.AddItem(new Item("Brick", 700));
            budget.AddItem(new Item("Cement", 400));
            budget.AddItem(new Item("Pavement", 200));
            budget.AddItem(new Item("Wood", 800));
            budget.AddItem(new Item("Sand", 150));

            double discount = calculator.Calculate(budget);

            Console.WriteLine(discount);
        }
    }
}
