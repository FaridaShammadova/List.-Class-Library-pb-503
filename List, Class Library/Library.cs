using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List__Class_Library
{
    public class Library
    {
        List<Book> books = new List<Book>();

        public Book this[int index]
        {
            get => books[index];
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book>? FindAllBooksByName(string value)
        {
            List<Book> wantedBooks = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Name.Contains(value))
                {
                    wantedBooks.Add(book);
                }
            }
            if (wantedBooks.Count > 0)
            {
                return wantedBooks;
            }
            else
            {
                return null;
            }
        }

        public Book? FindBookByCode(string code)
        {
            foreach (Book book in books)
            {
                if (book.Code == code)
                {
                    return book;
                }
            }
            return null;
        }

        public void RemoveAllBooksByName(string value)
        {
            foreach (Book book in books)
            {
                if (book.Name.Contains(value))
                {
                    books.Remove(book);
                }
            }
        }

        public List<Book>? SearchBooks(string value)
        {
            List<Book> wantedBooks=new List<Book>();
            foreach (Book book in books)
            {
                if (book.Name.Contains(value))
                {
                    wantedBooks.Add(book);
                }
                else if (book.AuthorName.Contains(value))
                {
                    wantedBooks.Add(book);
                }
                else if (book.PageCount.ToString() == value)
                {
                    wantedBooks.Add(book);
                }
            }
            if (wantedBooks.Count > 0)
            {
                return wantedBooks;
            }
            else
            {
                return null;
            }
        }

        public List<Book> FindAllBooksByPageCountRange(int minPageCount, int maxPageCount)
        {
            List<Book> wantedBooks= new List<Book>();
            foreach (Book book in books)
            {
                if (book.PageCount > minPageCount && book.PageCount < maxPageCount)
                {
                    wantedBooks.Add(book);
                }
            }
            if (wantedBooks.Count > 0)
            {
                return wantedBooks;
            }
            else
            {
                return null;
            }
        }

        public void RemoveBookByCode(string value)
        {
            foreach (Book book in books)
            {
                if (book.Code == value)
                {
                    books.Remove(book);
                }
            }
        }

        public List<Book> GetBooks()
        {
            return books;
        }
    }
}
