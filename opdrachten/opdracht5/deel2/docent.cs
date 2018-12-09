using System.Collections.Generic;
namespace deel2


{
    public class Docent : Persoon
    {
       //properties
       public string Emailadres{
           get;
           set;
       } 
       public List<Opleiding> Opleiding{
           get;
           set;
       }

       //methodes
       public override string GenereerWachtwoord(){
           return "Docent - wachtwoord";
       }
    }
}