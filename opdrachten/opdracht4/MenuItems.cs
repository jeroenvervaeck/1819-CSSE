using System;
class MenuItem
{
    //velden
    //properties
    //methodes

    public Prijs Prijs{get; set;}
    public Product Product{get; set;}

    public MenuItem(string naam, string type, double waarde, string valuta)
    {
        this.Product = new Product(naam, type);
        this.Prijs = new Prijs(waarde, valuta);
        Console.WriteLine("Constructor met x aantal parameters: " + this.ToString());
    }

    public MenuItem(string naam, double waarde)
    {
        this.Product = new Product(naam);
        this.Prijs = new Prijs(waarde);
        Console.WriteLine("Constructor met y aantal parameters: " + this.ToString());
    }

    public MenuItem()
    {
        this.Prijs = new Prijs();
        this.Product = new Product();
        Console.WriteLine("Constructor met 0 parameters: " + this.ToString());

    }
    
    public string ToString()
    {
        return this.Product.ToString() + " kost " + this.Prijs.ToString();
    }
}