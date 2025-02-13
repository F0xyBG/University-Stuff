using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_1___Students
{
    public class Library
    {
        private Dictionary<Book, int> bookInventory = new Dictionary<Book, int>();
        private Dictionary<Book, List<(Student, DateTime)>> bookLoans = new Dictionary<Book, List<(Student, DateTime)>>();

        public Library(List<(Book, int)> books)
        {
            foreach (var (book, quantity) in books)
            {
                bookInventory[book] = quantity;
                bookLoans[book] = new List<(Student, DateTime)>();
            }
        }

        public void AddBook(Book book, int quantity)
        {
            if (bookInventory.ContainsKey(book))
            {
                bookInventory[book] += quantity;
            }
            else
            {
                bookInventory[book] = quantity;
                bookLoans[book] = new List<(Student, DateTime)>();
            }
        }

        public DateTime BorrowBook(Student student, Book book)
        {
            if (bookInventory.ContainsKey(book) && bookInventory[book] > 0)
            {
                bookInventory[book]--;
                DateTime returnDate = DateTime.Now.AddMonths(-2);
                bookLoans[book].Add((student, returnDate));
                return returnDate;
            }
            else
            {
                throw new InvalidOperationException("Book is not available.");
            }
        }

        public void ReturnBook(Student student, Book book)
        {
            if (bookLoans.ContainsKey(book))
            {
                var loan = bookLoans[book].FirstOrDefault(l => l.Item1 == student);
                if (loan != default)
                {
                    bookLoans[book].Remove(loan);
                    bookInventory[book]++;
                }
                else
                {
                    throw new InvalidOperationException("This student did not borrow this book.");
                }
            }
            else
            {
                throw new InvalidOperationException("Book not found in the library.");
            }
        }

        public List<Book> GetBooksWithLowStock()
        {
            return bookInventory.Where(b => b.Value <= 1).Select(b => b.Key).ToList();
        }

        public List<Book> GetBooksSortedByPopularity()
        {
            return bookLoans.OrderByDescending(b => b.Value.Count).Select(b => b.Key).ToList();
        }

        public List<(Book, DateTime)> GetBorrowedBooksByStudent(Student student)
        {
            return bookLoans.SelectMany(b => b.Value.Where(l => l.Item1 == student).Select(l => (b.Key, l.Item2)))
                            .OrderBy(b => b.Item2).ToList();
        }

        public List<(Book, Student, DateTime)> GetOverdueBooks()
        {
            DateTime now = DateTime.Now;
            return bookLoans.SelectMany(b => b.Value.Where(l => l.Item2 < now).Select(l => (b.Key, l.Item1, l.Item2)))
                            .OrderBy(b => b.Item3).ToList();
        }
    }
}