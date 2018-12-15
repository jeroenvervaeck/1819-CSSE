namespace deel4{
    class Barista{
        public KoffieBuilder koffieBuilder;

        public Koffie MaakKoffie(string  type, bool melk, bool slagroom, bool suiker){
            koffieBuilder.MaakNieuweKoffie();
            koffieBuilder.TypeKoffie(type);
            if(melk){
                koffieBuilder.VoegMelkToe();
            }
            if(slagroom){
                koffieBuilder.VoegSlagroomToe();
            }
            if(suiker){
                koffieBuilder.VoegSuikerToe();
            }
            return koffieBuilder.Koffie;
        }
 
        public Barista(){
            koffieBuilder = new KoffieBuilder();
        }
    }
}