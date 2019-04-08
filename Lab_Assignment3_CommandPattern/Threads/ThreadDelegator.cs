﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_Assignment3_CommandPattern
{
    public class ThreadDelegator
    {
        public static void StartThread(ThreadSafeMechanism threadSafeClient)
        {
            var thread = new Thread(threadSafeClient.SafeThread);
            thread.Start();
        }
    }
}