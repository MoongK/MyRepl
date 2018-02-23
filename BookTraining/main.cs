using System;

class MainClass {
  public static void Main (string[] args) {
    
    Book lor = new Book("The Lord of the Rings", 30000, "J.R.R.Tolkien");
    Book hobbit = new Book("The Hobbit", 20000, "J.R.R.Tolkien");
    
    Book[] books = new Book[2];
    books[0] = lor;
    books[1] = hobbit;
    
    for(int i=0;i<books.Length;i++){
      Console.WriteLine(books[i].title + ": " + books[i].GetSalePrice(0.1f));
    }
    
  }
}

class Book {
  
  public string title;
  public int price;
  public string author;
  // public double sale_price;
  
  public Book(string title, int price, string author){
    this.title = title;
    this.price = price;
    this.author = author;
  }
  public Book(){
    this.title = "";
    this.price = 0;
    this.author = "";
  }
  
  
  public float GetSalePrice(float x){
      // this.sale_price = this.price*x;
    // return (this.price-this.sale_price);
    
    return this.price-(this.price*x);
  }
  
}