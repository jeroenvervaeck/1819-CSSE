using System;

namespace deel3
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Factory c = new Factory();
                IVorm tekenaar1 = c.MaakTekenaar("cirkel");
                tekenaar1.teken();

                Factory v = new Factory();
                IVorm tekenaar2 = c.MaakTekenaar("vierkant");
                tekenaar2.teken();
            }
            catch(Exception e){
                Console.WriteLine(e);
            }

            
        }
    }
}
