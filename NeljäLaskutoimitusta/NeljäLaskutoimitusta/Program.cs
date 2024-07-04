using System;
namespace NeljäLaskutoimitusta
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Anna ensimmäinen luku: ");
            int ekaluku = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna toinen luku: ");
            int tokaluku = int.Parse(Console.ReadLine());

            int summa = ekaluku + tokaluku;
            int erotus = ekaluku - tokaluku;
            int kerto = ekaluku / tokaluku;
            double jako = (double) ekaluku / tokaluku; // Näin saamme jakolaskun toimimaan oikein, eli desimaaliluvuin
            Console.WriteLine("Lukujen neljän peruslaskutoimituksen tulokset ovat:" + summa + "/" + erotus + "/" + kerto +
                "/" + jako);
        }
    }
}