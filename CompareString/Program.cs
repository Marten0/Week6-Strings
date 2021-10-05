using System;

namespace CompareString
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm võrdleb sisestatud andmeid omavahel
            //programm kuvab konsoolis, kumb on pikem - eesnimi või perekonnanimi

            Console.WriteLine("Siesta oma eesnimi");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi");
            string perekonnanimi = Console.ReadLine();

            if(eesnimi.Length > perekonnanimi.Length)
            {
                Console.WriteLine("eesnimi on suurem kui perekonnanimi");
            }
            else if (eesnimi.Length < perekonnanimi.Length)
            {
                Console.WriteLine("eesnimi on väiksem kui perekonnanimi");
            }
            else
            {
                Console.WriteLine("On sama pikkusega");
            }
        }
    }
}
