class Product
{
    //velden
    public string Naam {get; set;}
    public string Type {get; set;}
    
    //properties
    //methodes

    public Product(string n, string t)
    {
        this.Naam = n;
        this.Type = t;
    }

    public Product(string n)
    {
        this.Naam = n;
        this.Type = "Onbepaald";
    }

    public Product()
    {
        this.Naam = "Appel";
        this.Type = "Fruit";
    }

    public string ToString()
    {
        return Naam + " is type " + Type;
    }
}