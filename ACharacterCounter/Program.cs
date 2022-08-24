using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada oma ees- ja perekonnanimi;
            //programm kuvab mitu "a" tähte on kasutaja ees- ja perekonnanimes

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();

            Console.WriteLine(fullName);

            int aCounter = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'a')
                {
                    aCounter++;
                }
            }

            if (aCounter != 1)
            {
                Console.WriteLine($"Sinu ees- ja perekonnanimes on {aCounter} 'a' tähte.");
            }
            else
            {
                Console.WriteLine($"Sinu ees- ja perekonnanimes on {aCounter} 'a' täht.");
            }
        }
    }
}