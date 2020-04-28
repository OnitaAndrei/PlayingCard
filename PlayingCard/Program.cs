using System;

namespace Playingcarte
{
    class Program
    {
        static void Main(string[] args)
        {
                while (true)
                {

                    Random rnd = new Random();
                    carte carte = new carte(rnd.Next(1,14), rnd.Next(1,5));
                    int nrcarte = carte.getnr();
                    int culoarecarte = carte.getculoare();
                    Console.WriteLine("Numarul cartii este {0}.", nrcarte);
                    Console.WriteLine("Numarul culorii cartii este {0}.", culoarecarte);
                    Console.WriteLine("Cartea este {0} {1}.", carte.nrToString(nrcarte), carte.culoareToString(culoarecarte));
                    Console.ReadKey();
                }           
        }
    }
}
