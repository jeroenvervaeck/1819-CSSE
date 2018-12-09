namespace deel2
{
    public class Student : Persoon
    {
        //properties
        public string Emailadress{
            get;
            set;
        }
        public Opleiding Opleiding{
            get;
            set;
        }

        //methodes
        public override string GenereerWachtwoord(){
            return "Student - wachtwoord";
        }
    }
}