using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Invoker 
            var Remote = new RemoteControl();

            //Receiver 
            var Light = new Light();

            //Command object 
            var LightOnCommand = new LightOnCommand(Light);

            //Pass command object 
            Remote.SetCommand(LightOnCommand);

            //Stimulate button press
            Remote.ButtonWasPressed();

        



            Console.ReadKey();
        }
    }
}
