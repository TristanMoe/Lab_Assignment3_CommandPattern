using System;

namespace Lab_Assignment3_CommandPattern
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
            Console.WriteLine("Blending ingredients");
        }

        #endregion 
    }


}