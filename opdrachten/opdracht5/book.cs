using System;
class Book{
    //elements
    private string name;
    private Author author;
    private double price;
    private int qtyInStock;

    //constructor
    public Book(string name, Author author, double price, int qtyInStock){
        this.name = name;
        this.author = author;
        this.price = price;
        this.qtyInStock = qtyInStock;
    }

    //functions
    public string getName(){
        return this.name; 
    }
    public Author getAuthor(){
        return this.author;
    }
    public double getPrice(){
        return this.price;
    }
    public void setPrice(double price){
        this.price = price;
    }
    public int getQtyInStock(){
        return this.qtyInStock;
    }
    public void setQtyInStock(int qtyInStock){
        this.qtyInStock = qtyInStock;
    }
    public string getAuthorName(){
        return this.author.getName();
    }

    //printing methode
    public void print(){
        Console.WriteLine(this.name + this.author.getName() + this.price + this.qtyInStock);
    }

}