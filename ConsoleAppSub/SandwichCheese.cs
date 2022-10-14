using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppSub
{
    class SandwichCheese : ISandwich
    {
        public SandwichCheese(ISandwich s)
        {
            Sandwich = s;
        }
        public ISandwich Sandwich { get; protected set; }
        public void LastAdditionally()
        {
            Console.WriteLine("Добавлен сыр");
        }
        public int GetCost() 
        {
            return Sandwich.GetCost() + 5;
        }
    }
}
