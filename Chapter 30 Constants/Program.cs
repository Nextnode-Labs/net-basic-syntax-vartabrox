/* A variable in C# can be made into a compile-time constant by adding the
const keyword before the data type. This modifier means that the variable
cannot be changed and it must therefore be assigned a value at the same
time as it is declared.  */

using static System.Console;

namespace Constants
{
    class City
    {
        public const string cityAbbr = "LA";

        public readonly int year = 2020; // run-time constant field

        public readonly int date = DateTime.Now.Minute;

        // unlike const, readonly can be applied to any data type
        public readonly string[] names = { "Tiberiy", "Kaligula", "Klavdiy" };

        /* Additionally, a readonly field cannot only be initialized when it is
        declared. It can also be assigned a value in the constructor. */

        public readonly string capital;

        public City()
        {
            capital = "Rome";
        }
    }

    class Program
    {
        static void Main()
        {
            WriteLine("--- Local Constants ---");

            const int abc = 99; // compile-time constant
            WriteLine($"Variable abc has a constant value of {abc}");

            WriteLine("--- Constant Fields ---");
            WriteLine($"The largest city in California is {City.cityAbbr}");

            WriteLine("--- Readonly ---");

            City x = new City();

            int date = x.date;
            int year = x.year;
            string[] names = x.names;
            string capital = x.capital;

            WriteLine(date);
            WriteLine(year);
            WriteLine(capital);

            foreach (string n in names)
                WriteLine(n);
        }
    }
}
