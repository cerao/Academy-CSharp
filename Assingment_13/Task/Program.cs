

using Task;
//Book book1 = new Book(10, "Tittle", "");
//Book book2 = new Book(10, "", "Name surname");
//Book book3 = new Book(0, "Tittle", "Name surname");

Book book = new Book(10, "Tittle", "Name surname");
Book book1 = new Book(10, "Tittle", "Name surname");

book1 = null;
Library library = new Library();

//library.AddBook(new Book[] { book, book1 });

library.AddBook(new Book[] { book, book });
library.AddBook(new Book[] { book, book });
library.AddBook(new Book[] { book, book });

