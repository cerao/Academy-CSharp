using System.Net.WebSockets;
using System.Xml.Linq;

namespace LibrarySystem
{
    public class Book
    {
        private string _Title;
        private string _Author;
        private DateTime _Year;
        private DateTime _birthDate;
        private int _count;


        public string Tittle
        {

            get { return _Title; }
            set { _Title = value; }
        }
        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }
        public DateTime Year
        {
            get { return _Year; }
            set { _Year = value; }
        }
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
    }


    class Library
    {
        private Book[] _book;
        private int _count;

        public Book this[int index]
        {
            get {  return _book[index];  }
            set {  _book[index] = value; }
        }
        public int count
        {
            get { return _book.Length; }
        }

        public bool searchinArry(string name)
        {
           foreach (Book book in _book)
            {
                if(book.Tittle == name)
                {
                    return true;
                }
            }
           return false;
        }

        public int searchinArry(int index)
        {
            for(int i = 0; i < _book.Length; i++)
            {
                if (i == index)
                {
                    return i;
                }
            }
            return -1;
        }

        public void addBook(Book[] book)
        {
            _book = book;
        }
        public void removeBook(int i)
        {
            _book = _book.Where((val, idx) => idx == i).ToArray();
        }

        public void print()
        {
            foreach(Book book in _book) 
            {
                Console.WriteLine(book.Tittle + " ");
            }
        }
    }
}