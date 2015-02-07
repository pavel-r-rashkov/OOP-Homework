using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Problem02_Asynchronous_Timer
{
    class TimerTest
    {
        static void Main(string[] args)
        {
            AsynchronousTimer timer = new AsynchronousTimer(TestAction, 10, 1000);
            timer.StartTimer();
            Fibonacci(0, 1, 1, 1000);
        }

        public static void TestAction(int i) 
        {
            Console.WriteLine("Test action called {0} times!", i);
        }


        // Method for simulating execution
        public static void Fibonacci(int a, int b, int counter, int number)
        {
            Console.WriteLine(a);
            if (counter < number)
            {
                Thread.Sleep(250);
                Fibonacci(b, a + b, counter + 1, number);
            }
        }
    }
}
