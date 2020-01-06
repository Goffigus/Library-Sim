using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Sim
{
    class Library
    {
        List<Book> Books = new List<Book>();

        public Library()
        {
            addNewBook("Redwall", "Brian");
            addNewBook("Moby Dick");
            addNewBook("X-rays and seeing inside yourself", "Dr Rip");
            addNewBook("How to Land a Plane in 5 Minutes", "Captain May Day");
        }
        
        public void addNewBook(string Title)
        {
            Book book = new Book(Title);
            Books.Add(book);
        }

        public void addNewBook(string Title, string author)
        {
            Book book = new Book(Title, author);
            Books.Add(book);
        }

        public void addNewBook(string Title, string author, int size)
        {
            Book book = new Book(Title, author, size);
            Books.Add(book);
        }

        public Book SearchShelfs(string Title)
        {
            Book foundBook = new Book("NOT FOUND", "Try another search");

            for(int i = 0; i < Books.Count; ++i)
            {
                if(Books[i].title.Contains(Title))
                {
                    foundBook = Books[i];
                }
            }

            return foundBook;
        }
    }
}
