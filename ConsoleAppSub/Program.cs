using System;

namespace ConsoleAppSub
{
    class Program
    {
        static void Main(string[] args)
        {
            //Проверка декоратора
            ISandwich sandwich = new Sandwich("One");
            sandwich = new SandwichCheese(sandwich);
            sandwich = new SandwichTomato(sandwich);
            sandwich = new Sandwich("One");
            sandwich.LastAdditionally();
            Sandwich[] sa = new Sandwich[1] { (Sandwich)sandwich };
           Console.WriteLine( sandwich.GetCost());
            //Проверка стратегии
            Drinks drinks = new Coffe("sas");
            drinks.Drink();
            Drinks m = new Cola("bad");
            m.Drink();
            Drinks[] dri = new Drinks[2]
            {
                (Drinks)drinks,
                m
            };
            //Проверка синглтона
            Order order = new Order(sa, dri);
            order.GetAddress("ул.А");
            order.Addresses = Address.getInstance("Ул.Б");
            Console.WriteLine(order.Addresses.Name);
            
        }
    }
}
