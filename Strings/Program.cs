using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tema eesnime?
            //programm kuvab kasutaja eesnime esimest tähte
            //programm kuvab kasutaja viimast tähte

            Console.WriteLine("Sisesta oma eesnimi.");
            string firstName = Console.ReadLine();
            Console.WriteLine(firstName[0]);


            int Firstnamelength = firstName.Length;
            Console.WriteLine($"Teie nimi on {Firstnamelength} sümbolit pikk");

            //viimase tähe indeks = Firstnamelength - 1
            Console.WriteLine(firstName[Firstnamelength-1]);
        }
    }
}
