using System;

namespace lesweek9
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXAMENVRAAG: wat zal er gecatched worden?
            object o = null;  
            try  
            {  
                int i = (int)o;   // Error  
            }

            catch (Exception e)
            {
                Console.WriteLine(string.Format("Exeption e: "+e.Message));
            }
            catch (InvalidCastException e)   
            {  
                Console.WriteLine(e);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
