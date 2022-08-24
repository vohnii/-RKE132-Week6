using System;

namespace HolCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu 'h', 'o', 'l' tähte on lauses "Hello World!";

            string helloWorld = "Hello World!".ToLower();

            int hCounter = 0;

            for (int i = 0; i < helloWorld.Length; i++)
            {
                if (helloWorld[i] == 'h')
                {
                    hCounter++;
                }
            }

            if (hCounter != 1)
            {
                Console.WriteLine($"Lauses Hello World! on {hCounter} 'h' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses Hello World! on {hCounter} 'h' täht.");
            }

            int oCounter = 0;

            for (int i = 0; i < helloWorld.Length; i++)
            {
                if (helloWorld[i] == 'o')
                {
                    oCounter++;
                }

                if (oCounter != 1)
                {
                    Console.WriteLine($"Lauses Hello World! on {oCounter} 'o' tähte.");
                }
                else
                {
                    Console.WriteLine($"Lauses Hello World! on {oCounter} 'o' täht.");
                }
            }

            int lCounter = 0;

            for (int i = 0; i < helloWorld.Length; i++)
            {
                if (helloWorld[i] == 'l')
                {
                    lCounter++;
                }
            }
            if (oCounter != 1)
            {
                Console.WriteLine($"Lauses Hello World! on {lCounter} 'l' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses Hello World! on {lCounter} 'l' täht.");
            }

        }
    }
}