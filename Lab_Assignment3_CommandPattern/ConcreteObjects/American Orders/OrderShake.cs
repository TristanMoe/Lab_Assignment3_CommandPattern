using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_Assignment3_CommandPattern.ConcreteObjects
{
    public class OrderShake : ICommand
    {
        public AmericanCook Cook { get; set; }

        public OrderShake(AmericanCook cook)
        {
            Cook = cook;
        }

        public void Execute()
        {
            Console.WriteLine("_____________________AmericanCook____________________________");
            Cook.MakeShake();
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine();
        }
    }
}
