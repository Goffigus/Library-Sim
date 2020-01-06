using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace Library_Sim
{
    class Interface
    {
        Library Lib;
        public Interface(Library lib)
        {
            Lib = lib;
        }

        

        public void Start()
        {
            WriteLine("Do you wnat to add or find a book? (please pick one)");
            string choice = ReadLine();
            choice = choice.ToLower();
            if (choice.IndexOf("add") >= 0)
            {
                AddBook();
            } else if (choice.IndexOf("find") >= 0)
            {
                findBook();
            } 
            else
            {
                WriteLine("Not an avaible command");
            }
            Start(); //calls on itself 
        }

        public void AddBook()
        {
            WriteLine("What is the title of the book you are adding?");
            string title = ReadLine();
            Lib.addNewBook(title);

            WriteLine("{0} has been added", title);
        }

        public void findBook()
        {
            Book foundBook;
            WriteLine("What is the title of the book you are searching for?");
            string title = ReadLine();
            foundBook = Lib.SearchShelfs(title);
            WriteLine(foundBook.title);
            WriteLine(foundBook.author);
            if(foundBook.checkedOut)
            {
                WriteLine("The book is checked out");
            }
            
            if(!foundBook.checkedOut)
            {
                WriteLine("Do you want to check this book out?");
                string input = ReadLine();
                input = input.ToLower();

                if (input.IndexOf("y") >= 0)
                {
                    foundBook.checkedOut = true;
                    WriteLine("{0} has been checked out", foundBook.title);
                }
            }

        }


    }
}
