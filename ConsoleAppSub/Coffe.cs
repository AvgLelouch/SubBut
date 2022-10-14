using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppSub
{
    class Coffe : Drinks, IDrinks 
    {
        public Coffe(string Name) : base(Name)
        {

        }
        public override void Drink()
        {
            Console.WriteLine("Выпито кофе");
        }

        public int GetCost()
        {
            return 40;
        }

        public void Heating(int i)
        {
            if (i == 0) { Console.WriteLine("Без подогрева"); }
            else if (i == 1) { Console.WriteLine("Тёплое");  }
            else if (i == 2) { Console.WriteLine("Горячее"); }
            else { Console.WriteLine("Не подогревает"); }

        }
    }
}
