using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppSub
{
    class Cola : Drinks, IDrinks
    {
        public Cola (string Name): base(Name) 
        {
            
        }
        public override void Drink()
        {
            Console.WriteLine("Выпита кола");
        }
        public int GetCost()
        {
            return 50;
        }

        public void Heating(int i)
        {
            Console.WriteLine("Подогревать нельзя");
        }
    }
}
