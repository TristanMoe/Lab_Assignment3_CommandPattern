using System;

namespace Lab_Assignment3_CommandPattern.Receivers
{
    public class AmericanCook : Cooks
    {
        #region Methods

        public void MakeItem1()
        {
            MakeShake();
        }

        public void MakeItem2()
        {
            MakePizzaBurger();
        }

        public void MakeItem3()
        {
            MakeRibs();
        }

        public void MakeShake()
        {
            Console.WriteLine("Blending ingredients...");
            Console.WriteLine("Adding ice cream...");
            Console.WriteLine("Mixing...");
            Console.WriteLine("Finished shake!");
        }

        public void MakePizzaBurger()
        {
            Console.WriteLine("Toasting bread...");
            Console.WriteLine("Adding cheese and salami...");
            Console.WriteLine("Cook until melted...");
            Console.WriteLine("Finished pizzaburger!");
        }

        public void MakeRibs()
        {
            Console.WriteLine("Clean ribs...");
            Console.WriteLine("Marinate meat...");
            Console.WriteLine("Grill meat...");
            Console.WriteLine("Finished ribs!");
        }

        #endregion 
    }


}