using System;

namespace KymmenenKertaaLuku
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Anna luku väliltä 1-10: ");
            int luku = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++) // Huom! luku alkaa 1 ja päättyy 10
            {
                int tulos = i * luku; // Tällä saadaan kertotaulujen tulokset
                Console.WriteLine(luku + " * " + i + " = " + tulos);
            }
        }
    }
}

