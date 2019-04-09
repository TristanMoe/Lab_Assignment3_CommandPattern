using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Assignment3_CommandPattern.Invoker;

namespace Lab_Assignment3_CommandPattern
{
    public class ThreadQueue
    {
        public Queue<Invokers> InvokersQueue { get; private set; }
        public ThreadQueue(Queue<Invokers> invokersQueue)
        {
            this.InvokersQueue = invokersQueue;
        }

        public void StartComputation()
        {
            foreach (var invoker in InvokersQueue)
            {
                var safeThread = new ExceptionHandling(invoker);
                ThreadDelegator.StartThread(safeThread);
            }
        }
    }
}
