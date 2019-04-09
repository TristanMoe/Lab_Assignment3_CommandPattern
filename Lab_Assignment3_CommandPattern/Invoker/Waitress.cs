using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment3_CommandPattern.Invoker
{
    class Waitress : Invokers
    {
        public Command Command { get; set; }

        public Waitress(Command command)
        {
            this.Command = command;
        }
    }
}
