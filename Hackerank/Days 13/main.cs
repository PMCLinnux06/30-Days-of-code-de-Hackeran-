using System;

abstract class Book
{
    protected string title;
    protected string author;

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    public abstract void display();
}

class MyBook : Book
{
    private int price;

    public MyBook(string title, string author, int price)
        : base(title, author)
    {
        this.price = price;
    }

    public override void display()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}

class Solution
{
    static void Main(string[] args)
    {
        string title = Console.ReadLine();
        string author = Console.ReadLine();
        int price = Convert.ToInt32(Console.ReadLine());

        Book book = new MyBook(title, author, price);
        book.display();
    }
}