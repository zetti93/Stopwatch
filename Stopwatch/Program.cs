using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start(6);
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo - Exemplo 10s => 10 segundos");
            Console.WriteLine("M = Minuto - Exemplo 1m => 1 Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("");
            Console.WriteLine("Quanto tempo deseja contar?");

            string date = Console.ReadLine().ToLower();
            char type = char.Parse(date.Substring(date.Length - 1, 1));
            int time = int.Parse(date.Substring(0, date.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2000);

            Start(time);
        }

        static void Start(int time)
        {
            var currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();

                currentTime++;

                Console.WriteLine(currentTime);

                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}