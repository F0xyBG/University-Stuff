namespace Books;

class Book
{
    //заглавие, автор, брой страници, цена.

    private string title;
    private string author;
    private int pages;
    private double price;

    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages 
    { 
        get { return pages; } 
        set { if (value > 0) pages = value; } 
    }

    public double Price 
    { 
        get { return price; } 
        set { if (value > 0) price = value; } 
    }

    public Book()
    {
        Title = "Unknown";
        Author = "Unknown";
        Pages = 0;
        Price = 0.0;
    }

    public Book(string title, string author, int pages, double price)
    {
        Title = title;
        Author = author;
        Pages = pages;
        Price = price;
    }

    public override string ToString()
    {
        return $"Zaglavie: {Title}, Avtor: {Author}, Cena: {Price}";
    }
}