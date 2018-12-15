namespace deel4{
    public class KoffieBuilder
    {
        public Koffie Koffie{get;set;}

        public void MaakNieuweKoffie(){
            Koffie = new Koffie();
            Koffie.Melk = false;
            Koffie.Slagroom = false;
            Koffie.Suiker = false;
            Koffie.Type = "basic";
        }
        public void VoegMelkToe(){
            Koffie.Melk = true;
        }
        public void VoegSlagroomToe(){
            Koffie.Slagroom = true;
        }
        public void VoegSuikerToe(){
            Koffie.Suiker = true;
        }

        public void TypeKoffie(string type){
            Koffie.Type = type;
        }
    }
}
