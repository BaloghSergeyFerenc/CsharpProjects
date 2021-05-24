using System.Collections;
using System.Collections.Generic;

namespace Generics
{
    internal class Shelf<T> : IEnumerable<T> where T : class, ILibraryItem
    {
        private IList<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public T GetItem(int id)
        {
            T searchedItem = null;
            foreach (ILibraryItem item in items)
            {
                if (item.Id == id)
                {
                    searchedItem = (T)item;
                    break;
                }
            }
            if (searchedItem != null)
            {
                items.Remove(searchedItem);
            }
            return searchedItem;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }

    internal interface ILibraryItem
    {
        int Id { get; }
    }

    internal class Book : ILibraryItem
    {
        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
    }

    internal class ReaderCard : ILibraryItem
    {
        private List<Book> f_Books;
        public ReaderCard(int id, string reader, bool hasDept)
        {
            Id = id;
            Reader = reader;
            HasDept = hasDept;
            f_Books = new List<Book>();
        }

        public int Id { get; private set; }
        public string Reader { get; private set; }

        private IEnumerable<Book> Books => f_Books;
        public bool HasDept { get; set; }
        public void BorrowBook(Book book)
        {
            f_Books.Add(book);
        }
        public void TakeBackBook(Book book)
        {
            f_Books.Remove(book);
        }
    }
}
