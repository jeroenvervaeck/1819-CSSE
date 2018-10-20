using System;

namespace opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            //oef FACULTEIT
            int n_fac = 10;

            for (int i_fac = 0; i_fac < n_fac; i_fac++)  
            {  
                Console.Write( faculteit(i_fac) +" ");  
            } 
          
            Console.Write("\n");

            //oef RIJ VAN FIBONACCI
            int n_fibo = 20;

            for (int i_fibo = 0; i_fibo < n_fibo; i_fibo++)  
            {  
                Console.Write( fibonachi(i_fibo) +" ");  
            } 

            Console.Write("\n");


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
