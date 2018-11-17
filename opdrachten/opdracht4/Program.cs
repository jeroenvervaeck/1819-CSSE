using System;
using System.Collections.Generic;

namespace opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MenuItem> lijst = new List<MenuItem>();
            lijst.Add(new MenuItem());
            lijst.Add(new MenuItem("Stoofvlees met friet", 18.50));
            lijst.Add(new MenuItem("Biefstuk", "Vlees", 22.50, "EUR"));
            lijst.Add(new MenuItem("Spaghettie", "Pasta", 14, "USD"));
            lijst.Add(new MenuItem("Croque Monsieur", "Snack", 10, "EUR"));
            lijst.Add(new MenuItem("Vispannetje", "Vis", 24.50, "EUR"));
            lijst.Add(new MenuItem("Zalm met sla", "Vis", 20, "EUR"));
            lijst.Add(new MenuItem("Dunne Lende", "Vlees", 19.50, "EUR"));
            lijst.Add(new MenuItem("Scampi's met looksaus", "Vis", 18.50, "USD"));
            lijst.Add(new MenuItem("Vol au vent", "Vlees", 18, "EUR"));
            lijst.Add(new MenuItem("Kaaskrokket", "Snack", 14, "EUR"));
            
            foreach(MenuItem item in lijst)
            {
                Console.WriteLine(item.ToString());
            }

            /*Vragen
            - In de opgave staat dat klasse MenuItem bestaat uit een prijs en een product, dan moet er toch niet afgeleid worden?
            De oplossing heeft dus enkel basisklassen. Zie commentaar verder voor een afgeleide klasse:
            class Kat : Dier
            {
                public bool Snorharen{get; set;}

                public Kat()
                {
                    this.Snorharen = true;
                    this.Poten = 4; //Poten komt van de basisklasse Dier
                }
            } 
            Basisklasse is Dier en subklasse is Kat
             */
        }
    }
}
