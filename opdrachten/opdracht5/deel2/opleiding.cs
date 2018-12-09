namespace deel2
{
    public class Opleiding : Iinformatie
    {
        // velden
        private string afkortingCampus;
        protected int campusNummer;

        // properties
        public string Campus{
            get;
            set;
        }

        // methodes
        public string Opleidingsnaam{
            get;
            set;
        }

        string GetwifiCode(){
            return "code";
        }

        // functie
        public override string ToString(){
            return string.Format("campus{0} - campusnummer {1}", this.Campus, this.campusNummer);
        }

        // constructor
        public Opleiding(){
            this.afkortingCampus = this.Campus.Substring(0, 3); //.Substring(StartIndex, Lenght)
        }
    }
}