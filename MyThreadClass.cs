using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Agustin
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {

            for (int LoopCount = 0; LoopCount < 3; LoopCount++)
            {

                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + LoopCount);
                Thread.Sleep(500); // 0.5 second.
            }
        }
        public static void Thread2()
        {

            for (int x = 0; x <= 5; x++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + x);
                Thread.Sleep(1500); //1.5 second.
            }
        }
    }
}
