namespace deel2
{
    public class Gebruiker
    {
        //velden
        protected string wachtwoord;

        //properties
        public string gebruikersNaam{
            get;
            set;
        }

        //methodes
        public virtual string GenereerWachtwoord(){
            return "Gebruiker - wachtwoord";
        }

        public void GenereerGebruikersnaam(){
            this.gebruikersNaam = "test";
        }

        //constructor
        public Gebruiker(){
            this.wachtwoord = GenereerWachtwoord();
        }
    }
}