using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Library
    {
        private Book[] _books = new Book[5];
        private int _Count = 0;
        public void AddBook(Book[] Book)
        {
            if ((_Count + Book.Length) > this._books.Length)
                        throw new IndexOutOfRangeException();

            foreach (var book in Book)
            {
                if (book == null)
                    throw new ArgumentNullException();
                _books[this._Count++] = book;
            }
        }
        public Book GetBook(int BookNumber)
        {
            var Exception = new Exception("Book Number isnt library");
            foreach (var book in _books)
            {
                if(book._bookNumber == BookNumber)
                {
                    return book;
                }
            }
            throw Exception;
        }
    }
}
