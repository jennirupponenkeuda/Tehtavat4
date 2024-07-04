using System;
namespace Jakojäännös
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Anna luku: ");
            int ekaluku = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna toinen luku: ");
            int tokaluku = int.Parse(Console.ReadLine());

            int jakojaannos = laskeJaannos(ekaluku, tokaluku);
            Console.WriteLine("Antamiesi lukujen jakojäännös on: " + jakojaannos);
        }

        static int laskeJaannos(int ekaluku, int tokaluku)
        {
            return(ekaluku % tokaluku);
        }
    }

}
