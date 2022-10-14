using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppSub
{
     class Address
    {
        private static Address instance;
        public string Name { get; private set; }

        protected Address(string name)
        {
            this.Name = name;
        }

        public static Address getInstance(string name)
        {
            if (instance == null)
            
                instance = new Address(name);
            
            return instance;
        }
    }
}
