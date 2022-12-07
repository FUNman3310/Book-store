using Book_Store;

Book book1 = new Book("name","mane",12);
Book book2 = new Book("ame","Kurio Sato",18);
Book book3 = new Book("atohara","Makima Makihara",12.5);
Book book4 = new Book("makimahara","Sakura Mashima",25);
Book book5 = new Book("anatama","Hitoshi Eruto",52.7);
Library library = new Library();
library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);
library.AddBook(book4);
library.AddBook(book5);
Order order = new Order();
order.AddToBasket(library.GetAllBooks());
order.SellBooks();



