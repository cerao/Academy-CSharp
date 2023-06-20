using LibrarySystem;

Book book = new Book() { Author = "rouling gvari", Tittle = "1", Year = DateTime.Now };

Library library = new Library { };

library.addBook(new Book[] { new Book { Author = "gvari", Tittle = "saxeli", Year = DateTime.Now }, book });

library.print();

library.removeBook(0);

library.print();

Console.WriteLine(library.searchinArry(0));

Console.WriteLine(library.searchinArry("saxeli"));