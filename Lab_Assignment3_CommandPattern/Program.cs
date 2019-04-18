using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Assignment3_CommandPattern.ConcreteObjects;
using Lab_Assignment3_CommandPattern.ConcreteObjects.Japanese;
using Lab_Assignment3_CommandPattern.Invoker;

namespace Lab_Assignment3_CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var americanCook = new AmericanCook();
            var sushiMaster = new SushiMaster();

            ICommand orderShakeCommand = new OrderShake(americanCook);
            ICommand orderBurgerMenuCommand = new OrderBurgerMenu(americanCook); 
            ICommand orderPizzaMenuCommand = new OrderPizzaMenu(americanCook);
            ICommand[] orders = {orderPizzaMenuCommand, orderBurgerMenuCommand, orderShakeCommand};
            MacroCommand entireTableOrder = new MacroCommand(orders);

            //Set toppings
            string[] toppings = {"Octopus", "Shrimp", "Salmon"};
            ICommand orderRunningSushi = new OrderRunningSushi(sushiMaster, toppings);

            //American cook orders
            Invokers americanWaitress = new Waitress();
            Invokers japaneseWaitress = new Waitress();
            americanWaitress.Command = entireTableOrder;
            japaneseWaitress.Command = orderRunningSushi;

            var orderQueue = new Queue<Invokers>();
            orderQueue.Enqueue(americanWaitress);
            orderQueue.Enqueue(japaneseWaitress);

            var threadQueue = new ThreadQueue(orderQueue);
            threadQueue.StartComputation();

            Console.ReadKey();

        }
    }
}
