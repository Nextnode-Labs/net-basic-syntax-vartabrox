/* An enumeration is a special kind of value type consisting of a list of named
constants. To create one, you use the enum keyword followed by a name
and a code block containing a comma-separated list of constant elements */

using static System.Console;

namespace Enums
{
    class Program
    {
        static void Main()
        {
            WriteLine("--- Enum Example ---");
            
            Genres genres = Genres.Thriller;

            if(genres == Genres.Thriller)
                WriteLine("I like thrillers");
            else
                WriteLine("But i dont lile comedy");

            PrintGenre(genres);
            PrintGenre(Genres.Detective);
            PrintGenre(Genres.Comedy);
            PrintGenre(Genres.Horror);
            PrintGenre(Genres.Adventure);

            void PrintGenre(Genres cinema)
            {
                switch (cinema)
                {
                    case Genres.Thriller:
                        WriteLine("The best thriller is a \"Wind River\"");
                        break;
                    case Genres.Detective:
                        WriteLine("The best detective is a \"True detective\"");
                        break;
                    case Genres.Comedy:
                        WriteLine("The best comedy is a \"Eurotrip\"");
                        break;
                    case Genres.Horror:
                        WriteLine("The best horror is a \"I don't watch horror\"");
                        break;
                    case Genres.Adventure:
                        WriteLine("The best adventure is a \"Six days, seven nights\"");
                        break;
                }
            }

            WriteLine("--- Enum Constant Values ---");

            WriteLine((int) Genres.Adventure);
            WriteLine((int) Genres.Comedy);
            WriteLine((int) Genres.Detective);
            WriteLine((int) Genres.Horror);
            WriteLine((int) Genres.Thriller);

            WriteLine("--- Enum Methods ---");

            string title = genres.ToString();

            WriteLine(title); // Thriller

            // using GetNames() method in System.Enum class
            foreach (string title2 in Enum.GetNames(typeof(Genres)))
                WriteLine(title2);
        }
            
        enum Genres : byte
        {
            Thriller = 2,
            Detective,
            Comedy,
            Horror,
            Adventure
        }
    }
}
