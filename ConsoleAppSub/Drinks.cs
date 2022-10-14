using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppSub
{
    public abstract class Drinks
    {
        string name;
        protected string Name { get; set; }
        public Drinks(string Name) 
        {
            name = Name; 
        }
        public abstract void Drink();
    }
}
