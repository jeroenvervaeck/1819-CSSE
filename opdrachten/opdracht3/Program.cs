using System;
using System.Collections.Generic;

namespace opdracht3
{

    public class Part
	{
        public string PartName { get; set; }
        public double PartPrice { get; set; }

        public override string ToString()
        {
            return PartName + " kost € " + PartPrice;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OPDRACHT MENU");


            //List<Part> parts = new List<Part>();

            //parts.Add(new Part() {PartName="Plat water", PartPrice=1});
            //parts.Add(new Part() {PartName="Cola 25cl", PartPrice=1.5});
            //parts.Add(new Part() {PartName="Cola 33cl", PartPrice=2});
            //parts.Add(new Part() {PartName="Witte wijn", PartPrice=3});
			//parts.Add(new Part() {PartName="Pils", PartPrice=2});
            //parts.Add(new Part() {PartName="Toast", PartPrice=5});
            //parts.Add(new Part() {PartName="Kaasplank", PartPrice=4});

		/* 	SortedList<double, string> parts = new SortedList<double, string>();

			parts.Add(1, "Plat water");
			parts.Add(1.5, "Cola 25cl");
			parts.Add(2, "Cola 33cl");
			parts.Add(3, "Witte wijn");
			//parts.Add(2, "Pils"); werkt niet omdat er 2x "2" is.
			parts.Add(5, "Toast");
			parts.Add(4, "Kaasplank");


	        foreach (Double prijs in parts.Keys)
        {
            Console.WriteLine(parts[prijs] + " kost €" + prijs);
        }                                                                           */


            Console.WriteLine("Welk element van de list?");
            string index = Console.ReadLine();
            int x = Convert.ToInt32(index);

			SortedList<double, string> parts = new SortedList<double, string>();

			parts.Add(1, "Plat water");
			parts.Add(1.5, "Cola 25cl");
			parts.Add(2, "Cola 33cl");
			parts.Add(3, "Witte wijn");
			//parts.Add(2, "Pils"); werkt niet omdat er 2x "2" is.
			parts.Add(5, "Toast");
			parts.Add(4, "Kaasplank");

            Console.WriteLine(parts[x] + " kost €" + x);
    
        }

    }

}
