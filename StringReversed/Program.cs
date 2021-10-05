using System;

namespace StringReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string Firstname = Console.ReadLine();

            for(int i = Firstname.Length-1; i >= 0; i--)
            {
                Console.WriteLine(Firstname[i]);
            }
        }
    }
}
