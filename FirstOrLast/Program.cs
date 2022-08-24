using System;

namespace FirstOrLast
{
    class Program
    {


        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada ees- ja perekonnanime;
            //programm kontrollib andmete pikkust eraldi;
            //programm kuvab kumb nendes on pikem

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstNameLength} sümbolit.");

            int lastNameLength = lastName.Length;
            Console.WriteLine($"Sinu perekonnanimes on {lastNameLength} sümbolit.");

            if (firstName.Length < lastName.Length)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem kui eesnimi.");
            }
            else if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("Sinu eesnimi on pikem kui perekonnanimi.");
            }
            else
            {
                Console.WriteLine("Mõlemad nimed on sama pikad.");
            }
        }
    }
        
 } 