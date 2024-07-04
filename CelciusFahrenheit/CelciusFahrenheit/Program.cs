using System;
namespace CelciusFahrenheit
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kuinka monta celsius-astetta?: ");
            int celsius = int.Parse(Console.ReadLine());

            double fahrenheit = MuunnosCelsius(celsius); // Tässä viittaat metodiin (aliohjelmaan), jonka nimi on MuunnosCelsius

            Console.WriteLine("Antamasi celsius-asteet ovat fahrenheit -asteina: " + fahrenheit);

        }
        static double MuunnosCelsius(int celsius) //Tässä metodi eli aliohjelma huom! double eli desimaalit tarpeelliset!
        {
            double fahrenheit = celsius * 1.8 + 32;
            return fahrenheit; //Palautus fahrenheit -asteina pääohjelmaan
        }

    }

}
