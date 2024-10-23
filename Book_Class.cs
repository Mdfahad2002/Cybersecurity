//Practice set - 2

//1. Create a class “Book” with relevant data and methods. (e.g. Each book will have book name, author, edition, price, ISBN etc. User can create a book, get
// information about the book, update the information timely). Create instance of the class using default constructor.
// a. Keep all data members public (i.e. accessible outside the class)
// b. Write a method showBookInfo() to show all information of the book.
/*using System;

public class Book                    //Declare class in public to access from outside the class.
{                                    //Data member
    public string BookName,Author,Edition,ISBN;        
    public double Price;            //Abstraction
    public Book()           //Default Constructor
    {
        BookName = "Oldname of Book";
        Author = "Oldname of Author";
        Edition = "Old Edition";
        Price = 10;
        ISBN = "0000000000000";
    }
    public void ShowBookInfo()      //Show data method
    {
        Console.WriteLine("Book Name:"+BookName);
        Console.WriteLine("Author:"+Author);
        Console.WriteLine("Edition:"+Edition);
        Console.WriteLine("Price:"+Price);
        Console.WriteLine("ISBN:"+ISBN);
    }
}

public class UpdatedBookInfo
{
    public static void Main()
    {
        
        Book defaultBook = new Book();              //Instance of class Book using the default constructor

        
        Console.WriteLine("Default Book Info:");        //Call the function to show default book information
        defaultBook.ShowBookInfo();

        defaultBook.BookName = "2018";              
        defaultBook.Author = "Nagel, Christian";
        defaultBook.Edition = "1st";
        defaultBook.Price = 36.0;
        defaultBook.ISBN = "9781119449270";

        
        Console.WriteLine("\nUpdated Book Info:");      //Call the function to show the updated book information
        defaultBook.ShowBookInfo();
    }
}*/







