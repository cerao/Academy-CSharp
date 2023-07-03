using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Book
    {
        public int _bookNumber { get; set; }
        public string _tittle { get; set; }
        public string _author { get; set; }
        public Book(int bookNumber, string tittle, string author)
        {
            try
            {
                if (bookNumber == 0 || tittle == "" || author == "")
                    throw new ArgumentNullException();

                this._bookNumber = bookNumber;
                this._tittle = tittle;
                this._author = author;
            }
            catch (ArgumentNullException ex) 
            {
                Console.WriteLine("Argument Null Exception");
            }
        }
    }
}
