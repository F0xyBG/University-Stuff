namespace Exercise_1___Students;

class Program
{
    static void Main(string[] args)
    {
        // Initialize books
        Book book1 = new Book("C# Programming", "John Doe", "1234567890");
        Book book2 = new Book("Introduction to Algorithms", "Thomas H. Cormen", "0987654321");
        Book book3 = new Book("Data Structures and Algorithms", "Erich Gamma", "1122334455");

        // Initialize library
        Library library = new Library(new List<(Book, int)>
        {
            (book1, 2),
            (book2, 1),
            (book3, 3)
        });

        // Initialize students
        Student student1 = new Student("Alice", "F12345");
        Student student2 = new Student("Bob", "F67890");

        // Borrow books
        DateTime returnDate1 = library.BorrowBook(student1, book1);
        Console.WriteLine($"\n{student1.Name} borrowed {book1.Title}, return by {returnDate1}");

        DateTime returnDate2 = library.BorrowBook(student2, book2);
        Console.WriteLine($"\n{student2.Name} borrowed {book2.Title}, return by {returnDate2}");

        // Return books
        library.ReturnBook(student1, book1);
        Console.WriteLine($"\n{student1.Name} returned {book1.Title}");

        // Get reports
        List<Book> lowStockBooks = library.GetBooksWithLowStock();
        Console.WriteLine("\nBooks with low stock:");
        foreach (var book in lowStockBooks)
        {
            Console.WriteLine(book.Title);
        }

        List<Book> popularBooks = library.GetBooksSortedByPopularity();
        Console.WriteLine("\nBooks sorted by popularity:");
        foreach (var book in popularBooks)
        {
            Console.WriteLine(book.Title);
        }

        List<(Book, DateTime)> borrowedBooks = library.GetBorrowedBooksByStudent(student2);
        Console.WriteLine($"\n{student2.Name} borrowed books:");
        foreach (var (book, date) in borrowedBooks)
        {
            Console.WriteLine($"{book.Title}, return by {date}");
        }

        List<(Book, Student, DateTime)> overdueBooks = library.GetOverdueBooks();
        Console.WriteLine("\nOverdue books:");
        foreach (var (book, student, date) in overdueBooks)
        {
            Console.WriteLine($"{book.Title} borrowed by {student.Name}, was due on {date}");
        }
    }
}
