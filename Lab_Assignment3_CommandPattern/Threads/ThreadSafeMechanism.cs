﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment3_CommandPattern
{
    public class ThreadSafeMechanism
    {
        private Command Task { get; set; }

        public ThreadSafeMechanism(Command commandTask)
        {
            this.Task = commandTask;
        }

        /// <summary>
        /// Encapsulates in try/catch block
        /// </summary>
        public void SafeThread()
        {
            try
            {
                    Task.Execute();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
