using System;

namespace deel3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dbconnection s1 = Dbconnection.Instance();
            Dbconnection s2 = Dbconnection.Instance();
        
            if (s1 == s2)
            {
                Console.WriteLine("de objecten zijn de zelfde instanstie");
            }
        
            Console.ReadKey();
        }
    }
}
