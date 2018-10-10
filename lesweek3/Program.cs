using System;

namespace lesweek3
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("yuuu");
                //1 regel commentaar

                /*
                Codeblok
                */

                //Rekenmachine
                //int c = 4;
                int a = 10;
                int b = 5;
                
                int resultaat1 = optellen(a, b);
                int resultaat2 = deling(a, b);
                int resultaat3 = verhogen(a);

                Console.WriteLine(resultaat1);
                Console.WriteLine(resultaat2);
                Console.WriteLine(resultaat3);
            }

        static int optellen(int a, int b)
        {
            return a + b;
        }

        static int verhogen(int a)
        {
            return a++;
        }
        static int deling(int a, int b)
        {
            return a/b;
        }



    }
}
