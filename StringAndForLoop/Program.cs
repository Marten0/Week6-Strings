using System;

namespace StringAndForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta eesnimi:");
            string Firstname = Console.ReadLine();

            for(int i = 0; i < Firstname.Length; i++)
            {
                Console.WriteLine(Firstname[i]);
            }
        }
    }
}
