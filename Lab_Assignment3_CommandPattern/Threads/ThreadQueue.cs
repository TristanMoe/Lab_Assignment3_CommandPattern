using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment3_CommandPattern
{
    public class ThreadQueue
    {
        public Queue<Command> CommandQueue { get; private set; }
        public ThreadQueue(Queue<Command> commandQueue)
        {
            this.CommandQueue = commandQueue;
        }

        public void StartComputation()
        {
            foreach (var command in CommandQueue)
            {
                var safeThread = new ThreadSafeMechanism(command);
                ThreadDelegator.StartThread(safeThread);
            }
        }
    }
}
