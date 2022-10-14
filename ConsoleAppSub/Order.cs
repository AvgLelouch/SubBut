using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppSub
{
    class Order
    {
        public Order(Sandwich[] sa,Drinks[] dr)  
        {
            Sandwiches = sa;
            Drink = dr;
        }
        public Sandwich[] Sandwiches { protected set; get; }
        public Drinks[] Drink { protected set; get; }
        public int id;
        public Address Addresses { get;  set; }
        public void GetAddress(string osName)
        {
            Addresses = Address.getInstance(osName);
        }
    }
}
