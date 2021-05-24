using System;

namespace Generics
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Shelf<Book> bookShelf = CreateBookShelf();
            WriteBooks(bookShelf);
        }

        private static void WriteBooks(Shelf<Book> bookShelf)
        {
            foreach (Book book in bookShelf)
            {
                Console.WriteLine($"Book: {book.Id} --- {book.Title} --- {book.Author}");
            }
        }

        private static Shelf<Book> CreateBookShelf()
        {
            //Shelf<ReaderCard> readerCards = new Shelf<ReaderCard>();
            //readerCards.AddItem(new ReaderCard(8, "Feri", false));



            Shelf<Book> bookShelf = new Shelf<Book>();
            bookShelf.AddItem(new Book(1, "Harry Potter 1", "J.K.Rowling"));
            bookShelf.AddItem(new Book(2, "Harry Potter 2", "J.K.Rowling"));
            bookShelf.AddItem(new Book(3, "Harry Potter 3", "J.K.Rowling"));
            bookShelf.AddItem(new Book(4, "Harry Potter 4", "J.K.Rowling"));
            bookShelf.AddItem(new Book(5, "Harry Potter 5", "J.K.Rowling"));
            bookShelf.AddItem(new Book(6, "Harry Potter 6", "J.K.Rowling"));
            bookShelf.AddItem(new Book(7, "Harry Potter 7", "J.K.Rowling"));
            return bookShelf;
        }
    }
}
