using System;

namespace lesweek4
{
    class Program
    {
        static void Main(string[] args)
        {
 
                int a1 = 100;
                int b1 = 7;
                int c1 = 3;
                    int R1 = (a1+b1)*c1;

                int a2 = 5;
                int b2 = 406;
                int c2 = 7367;
                int d2 = 69;
                    int R2 = a2*((b2+c2)/d2);

                int a3 = 73;
                int b3 = 41;
                int c3 = 39;
                    int R3 = (a3*b3)-c3;
                
                int a4 = 7;
                int b4 = 8;
                int c4 = 19;
                    int R4 = (a4*b4)-c4;


                int resultaat2 = optellen(optellen(optellen(maal(optellen(a1,b1),c1) , maal(a2 ,deling(optellen(b2,c2),d2))) , aftrekken(maal(a3,b3), c3 )) , aftrekken(maal(a4,b4), c4));
                Console.WriteLine(resultaat2);

                //resultaat2 = 10000;

                if(resultaat2 == 3872)
                {
                    Console.WriteLine("je hebt de bewerking juist");
                }
                else if(resultaat2 > 3872)
                {
                    Console.WriteLine("het resultaat is te hoog!!");
                }
                else
                {
                    Console.WriteLine("loser!!");
                };

            //FOR LOOP
            for(int counter= 1; counter < 11; counter++)
            {
                Console.WriteLine("De waarden voor " + counter);
                for(int counter2 = 1; counter2 < 11; counter2++)
                {
                    Console.WriteLine(counter + " x " + counter2 + " = " + maal(counter,counter2));
                }
            }

            //DO WHILE LOOP
            int getal3 = 3;
            do
            {
                Console.WriteLine("de waarde van het getal is " + getal3);
                getal3++;
            } while(getal3 < 5);


            //WHILE LOOP
            int getal4 = 3;
            while(getal4 < 5)
            {
                Console.WriteLine("de waarde van het getal is " + getal4);
                getal4++;
            }
            
            //oef FACULTEIT

            //oef RIJ VAN FIBONACCI

        }

        static int optellen(int a, int b)
        {
            return a + b;
        }

        static int deling(int a, int b)
        {
            return a/b;
        } 

        static int aftrekken(int a, int b)
        {
            return a-b;
        }

        static int maal (int a, int b)
        {
            return a*b;
        }

    }
}
