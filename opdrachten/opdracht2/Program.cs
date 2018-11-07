using System;

namespace opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            //oef Tafel van vermeningvuldigen
            Console.WriteLine("TAFELS");
            int n_ver = 10;
            for(int i_verm = 1; i_verm <= n_ver; i_verm++)
            {
                Console.WriteLine("tafel van "+ i_verm);
                vermeningvuldigen(i_verm);
            }
            
            //oef tafels van x getal
            Console.WriteLine("TAFELS VAN GETAL");
            Console.WriteLine("Geef een input");
            
            vermeningvuldigen_ingeven(int.Parse(Console.ReadLine()));

        
            //oef FACULTEIT
            Console.WriteLine("FACULTEIT");
            Console.WriteLine("geef een input");
            int n_fac = int.Parse(Console.ReadLine());

            for (int i_fac = 0; i_fac < n_fac; i_fac++)  
            {  
                Console.Write(faculteit(i_fac) +" ");  
            } 
          
            Console.Write("\n");

            //oef RIJ VAN FIBONACCI
            Console.WriteLine("FIBONACCI");
            int n_fibo = 21;

            for (int i_fibo = 0; i_fibo < n_fibo; i_fibo++)  
            {  
                Console.Write( fibonachi(i_fibo) +" ");  
            } 

            Console.Write("\n");

        }

    static void vermeningvuldigen (int verm)
    {
        for(int i = 1; i<=10; i++)
        {
            Console.WriteLine(verm + " * " + i + " = " + i*verm);
        }
    }

        static void vermeningvuldigen_ingeven (int verm)
    {
        for(int i = 1; i<=10; i++)
        {
            Console.WriteLine(verm + " * " + i + " = " + i*verm);
        }
    }

    static int faculteit (int facu)
    {
        int result = facu;
        for(int i = facu-1; i > 1; i--)
        {
           result = result * i;
        }

        return result;
    }


    static int fibonachi (int n_fibo)
    {

        int firstnumber = 0;
        int secondnumber = 1;
        int result = 0;

        for(int i_fibo = 1; i_fibo <= n_fibo; i_fibo++)
        {
            result = firstnumber + secondnumber;
            firstnumber = secondnumber;
            secondnumber = result;
        }

        return result;
    }


    }

}
