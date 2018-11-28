class Author{
    //element
    private string name;
    private string email;
    private char gender;

    //constructor
    public Author(string name, string email, char gender){
        this.name = name;
        this.email = email;
        this.gender = gender;
    }

    //function
    public string getName(){
        return this.name;
    }
}