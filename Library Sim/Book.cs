using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Sim
{
    class Book
    {
        public string title;
        public string author;
        public int size;

        public bool checkedOut;

        public int chDateMonth;
        public int chDateYear;
        public int chDateDay;

        public int rtDateMonth;
        public int rtDateYear;
        public int rtDateDay;

        public Book(string Title)
        {
            title = Title;
            author = "NA";
            size = 300;
            checkedOut = false;
        }

        public Book(string Title, string Author)
        {
            title = Title;
            author = Author;
            size = 300;
            checkedOut = false;
        }

        public Book(string Title, string Author, int Size)
        {
            title = Title;
            author = Author;
            size = Size;
            checkedOut = false;
        }

    }
}
