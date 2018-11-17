class Prijs
{
    //velden
    public double Waarde{get; set;}
    public string Valuta{get; set;}

    //properties
    //methodes

    public Prijs(double w, string v)
    {
        this.Waarde = w;
        this.Valuta = v;
    }

    public Prijs()
    {
        this.Waarde = 0;
        this.Valuta = "EUR";
    }

    public Prijs(double w)
    {
        this.Waarde = w;
        this.Valuta = "EUR";
    }

    public string ToString()
    {
        return Waarde + " " + Valuta;
    }
}