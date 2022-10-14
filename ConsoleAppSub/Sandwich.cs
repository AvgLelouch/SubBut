using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppSub
{
    public class Sandwich:ISandwich
    {
        public Sandwich(string s)
        {
            Sandwichs = s;
        }
        public string Sandwichs { get; protected set; }
        public int GetCost() 
        {
            return 150;
        }

        public void LastAdditionally()
        {
            Console.WriteLine("Ничего не добавлено");
        }
    }
}
