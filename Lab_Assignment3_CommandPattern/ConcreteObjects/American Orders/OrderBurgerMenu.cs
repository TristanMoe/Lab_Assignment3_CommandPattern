using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment3_CommandPattern.ConcreteObjects
{
    class OrderBurgerMenu : ICommand
    {
        private AmericanCook Cook { get; set; }

        public OrderBurgerMenu(AmericanCook cook)
        {
            this.Cook = cook;
        }
        public void Execute()
        {
            Console.WriteLine("_____________________AmericanCook____________________________");
            Cook.MakeShake();
            Cook.MakeBurger();
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine();
        }
    }
}
