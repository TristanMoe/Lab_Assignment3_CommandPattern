using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Assignment3_CommandPattern.Invoker;

namespace Lab_Assignment3_CommandPattern
{
    class Waitress : Invokers
    {
        public ICommand Command { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Waitress()
        {
        }

        /// <summary>
        /// Explicit Constructor
        /// </summary>
        /// <param name="command"></param>
        public Waitress(ICommand command)
        {
            this.Command = command;
        }
    }
}
