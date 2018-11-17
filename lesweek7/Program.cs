using System;

namespace lesweek7
{
    class Program
    {
        static void Main(string[] args)
        {
            Voertuig voertuig1 = new Voertuig();
            voertuig1.Laadvermogen = 12;
            voertuig1.Kleur = "blauw";
            Console.WriteLine(voertuig1.ToString());

            Voertuig voertuig2 = new Voertuig(33);
            Console.WriteLine(voertuig2.ToString());


            Auto auto1 = new Auto();
            Console.WriteLine(auto1.ToString());
        }
    }
}
