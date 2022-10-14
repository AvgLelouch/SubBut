using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppSub
{
    class SandwichTomato : ISandwich
    {
        public SandwichTomato(ISandwich s)
        {
            Sandwich = s;
        }
        public ISandwich Sandwich { get; protected set; }
        public int GetCost()
        {
            return Sandwich.GetCost() + 8;
        }

        public void LastAdditionally()
        {
            Console.WriteLine("Добавлены томаты");
        }
    }
}
