using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Assignment3_CommandPattern.Invoker;
using Lab_Assignment3_CommandPattern.Receivers;

namespace Lab_Assignment3_CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Cooks AmericanCook = new AmericanCook();
            Command OrderShakeCommand = new OrderShakeCommand(AmericanCook);
            Invokers Waitress = new Waitress(OrderShakeCommand);
            ExceptionHandling ExceptionHandling = new ExceptionHandling(Waitress);
            ExceptionHandling.InvokeCommand();

            Console.ReadKey();

        }
    }
}
