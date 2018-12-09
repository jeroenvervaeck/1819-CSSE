namespace deel2
{
    public class Persoon : Gebruiker, Iinformatie
    {
        //velden
        private string naam;
        private string voornaam;

        //propeties
        public string Naam{
            get;
            set;
        }
        public string VolledigeNaam{
            get{
                return this.naam + " " + this.voornaam;
            }         
        }
        public string GeboorteDatum{
            get;
            set;
        }
        public string Voornaam{
            get
            {
                return this.voornaam;
            }
            set
            {
                this.Voornaam = value;
            }
        }
        //methodes
        public int Leeftijd(){
            return 18;
        }

        public virtual string GenereerWachtwoord(string input){
            return "Persoon - Wachtwoord (parameter string)";
        }
        public string GenereerWachtwoord(int input){
            return "Persoon - Wachtwoord (parameter int)";
        }
        public override string GenereerWachtwoord(){
            return "Persoon - wachtwoord";
        }
        public new int GenereerWachtwoord(){
            return 2;
        }

        public override string ToString(){
            return "waarde van object persoon";
        }
        //constructor
    }
}