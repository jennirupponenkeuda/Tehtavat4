using System;
namespace Yhteenlasku
{
    class Progmram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ensimmäinen numero: ");
            int ekanumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna toinen luku: ");
            int tokanumero = int.Parse(Console.ReadLine());

            int summa = ekanumero + tokanumero;

            Console.WriteLine("Lukujen summa on " + summa);
        }
    }
}
