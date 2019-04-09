using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Assignment3_CommandPattern.Invoker;

namespace Lab_Assignment3_CommandPattern
{
    public class ExceptionHandling
    {
        private Invokers Invoker { get; set; }

        public ExceptionHandling(Invokers invoker)
        {
            this.Invoker = invoker;
        }

        /// <summary>
        /// Encapsulates in try/catch block
        /// </summary>
        public void InvokeCommand()
        {
            try
            {
                Invoker.Command.Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
