using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Assignment3_CommandPattern.Receivers;

namespace Lab_Assignment3_CommandPattern.ConcreteObjects
{
    public class OrderShake : Command
    {
        public Cooks Cook { get; set; }

        public OrderShake(Cooks cook)
        {
            Cook = cook;
        }

        public void Execute()
        {
            Cook.MakeItem1();
        }
    }
}
