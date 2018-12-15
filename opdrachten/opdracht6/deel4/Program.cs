using System;

namespace deel4
{
    class Program
    {
        static void Main(string[] args)
        {
            Barista katrien = new Barista();
            Koffie k1 = katrien.MaakKoffie("Espresso", true, true, true);
            Koffie k2 = katrien.MaakKoffie("Macchiato", false, true, false);
            Koffie k3 = katrien.MaakKoffie("Ristretto", true, true, false);
            Koffie k4 = katrien.MaakKoffie("Mocha", false, true, false);
            Koffie k5 = katrien.MaakKoffie("Irish", false, false, false);
            Koffie k6 = katrien.MaakKoffie("Frappe", false, true, false);
            Koffie k7 = katrien.MaakKoffie("Latte", true, false, true);
            Koffie k8 = katrien.MaakKoffie("Glace", true, true, false);
            Koffie k9 = katrien.MaakKoffie("Americano", true, true, false);
            Koffie k10 = katrien.MaakKoffie("Cappuccino", false, true, true);                                                           
            k1.smaak();
            k2.smaak();
            k3.smaak(); 
            k4.smaak(); 
            k5.smaak(); 
            k6.smaak(); 
            k7.smaak(); 
            k8.smaak();  
            k9.smaak(); 
            k10.smaak();            
        }
    }
}
