// Namespaces provide a way to group related top-level members into
// a hierarchy. They are also used to avoid naming conflicts.

global using System;
using G = General; // using alias notation
using static System.Console;
using Base.Country.Brazil;

// top-level statements
Console.WriteLine("--- Namespace Access ---");
Town brasilia = new("Brasilia");
brasilia.Print();

Console.WriteLine("--- File-Scoped Namespaces ---");
G.River riverName = new("Preto");
riverName.Print();

Console.WriteLine("--- Using Directive ---");
WriteLine("--- A using static directive ---");

namespace Base
{
    namespace FirstNamespace
    {
        class Program
        {
            /*  static void Main()
            {
                Console.WriteLine("--- Namespace Access ---");
                Country.Brazil.Town brasilia = new("Brasilia");
                brasilia.Print();

                Console.WriteLine("--- File-Scoped Namespaces ---");
                G.River riverName = new("Preto");
                riverName.Print();

                Console.WriteLine("--- Using Directive ---");
            } */
        }
    }

    // nested namespaces
    namespace Country
    {
        namespace Brazil
        {
            /*             public class Town
                        {
                            string title;
                            public Town(string title) => this.title = title;
                            public void Print() => Console.WriteLine($"Town name: {title}");
                        } */
        }
    }

    // a more concise way to write this is to separate the namespaces
    // with a dot
    namespace Country.Brazil
    {
        public class Town
        {
            string title;
            public Town(string title) => this.title = title;
            public void Print() => Console.WriteLine($"Town name: {title}");
        }
    }
}
