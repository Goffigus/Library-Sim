using System;
using static System.Console;

namespace Library_Sim
{
    class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library();
            Interface facey = new Interface(lib);

            facey.Start();
           
        }
    }
}
