using System;
    
    namespace KäyttäjänTervehtiminen
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kerro nimesi ");
            string nimi = Console.ReadLine();

            Console.WriteLine("Hei " + nimi);
        }
    }
}
