namespace deel3{
    class Factory{
        //methode
        public IVorm MaakTekenaar(string type){
            if(type == "vierkant"){
              return new VierkantTekenaar();
            }
            else if(type == "cirkel"){
              return new CirkelTekenaar();
            }
            else{
                throw new System.Exception();
            }
        }
        //constructor
        public Factory(){
            
        }
    }
}