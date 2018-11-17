class Voertuig
{
    //velden
    //properties
    //methodes

    private int laadvermogen;
    public int Laadvermogen
    {
        get
        {
            return laadvermogen;
        }

        set
        {
            laadvermogen = value;
        }
    }

    public string Kleur {get; set;}

    public Voertuig(int laadvermogen)
    {
        this.laadvermogen = laadvermogen;
        Kleur = Kleur;
    }

    public Voertuig()
    {
    }
    
    public string ToString()
    {
        return "voortuig met laadvermogen " + this.laadvermogen + ", met kleur " + Kleur;
    }

}