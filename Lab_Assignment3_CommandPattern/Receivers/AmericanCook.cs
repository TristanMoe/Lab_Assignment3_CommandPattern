using System;
using System.Threading;

namespace Lab_Assignment3_CommandPattern
{
    public class AmericanCook 
    {
        #region Methods

        public void MakeShake()
        {
            Console.WriteLine("Blending ingredients...");
            Console.WriteLine("Adding ice cream...");
            Console.WriteLine("Mixing . . .");
            Thread.Sleep(1000);
            Console.WriteLine("Finished shake!");
            Console.WriteLine("Shake is ready to be served");
        }

        public void MakeBurger()
        {
            Console.WriteLine("Slicing tomatoes, cucumber and salad");
            Console.WriteLine("Grills burger patty . . .");
            Thread.Sleep(3000);
            Console.WriteLine("Adds seasoning");
            Console.WriteLine("Adds content between two buns");
            Console.WriteLine("Burger is ready to be served");
        }

        public void MakePizza()
        {
            Console.WriteLine("Slices tomatoes & peppers");
            Console.WriteLine("Grates cheese");
            Console.WriteLine("Rolls dough");
            Console.WriteLine("Adds content on pizza dough");
            Console.WriteLine("Cooks in oven . . .");
            Thread.Sleep(5000);
            Console.WriteLine("Pizza is ready to be served");
        }
        #endregion 
    }


}