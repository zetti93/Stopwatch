using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            var time = 10;
            var currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();

                currentTime++;

                Console.WriteLine(currentTime);

                Thread.Sleep(1000);
            }
        }
    }
}