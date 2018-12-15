namespace deel4{
    using System;
    public class Koffie{
        //objecten
        public bool Melk{get;set;}
        public bool Slagroom{get;set;}
        public bool Suiker{get;set;}
        public string Type{get;set;}

        public Koffie(){

        }

        //methode
        public void smaak(){
            Console.Write("Deze koffie smaakt naar: ");
            if(Melk){
                Console.Write("melk ");
            }
            if(Slagroom){
                Console.Write("slagroom ");
            }
            if(Suiker){
                Console.Write("suiker ");
            }
            if(!Melk && !Slagroom && !Suiker){
                Console.Write("niks ");
            }
            Console.WriteLine("en is van het type " + Type);
        }
    }
}