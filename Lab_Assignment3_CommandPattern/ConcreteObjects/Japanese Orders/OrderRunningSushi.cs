using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_Assignment3_CommandPattern.ConcreteObjects.Japanese
{
    public class OrderRunningSushi : ICommand
    {
        private  SushiMaster SushiMaster { get; set; }
        private string[] ToppingSelection { get; set; }
        public OrderRunningSushi(SushiMaster sushiMaster, string[] toppingSelection)
        {
            this.SushiMaster = sushiMaster;
            this.ToppingSelection = toppingSelection; 
        }
        public void Execute()
        {
            //Endless sushi, a true SushiMaster is tireless 
            while (true)
            {
                foreach (var topping in ToppingSelection)
                {
                    Console.WriteLine("_____________________SushiMaster_____________________________");
                    SushiMaster.MakeRice();
                    SushiMaster.AddTopping(topping);
                    Console.WriteLine("_____________________________________________________________");
                    Console.WriteLine();
                    Thread.Sleep(2000);
                }
            }
            
        }
    }
}
