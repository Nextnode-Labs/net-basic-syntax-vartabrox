/* A user-defined type can define a custom implicit or explicit conversion from or to another type.
Implicit conversions don't require special syntax to be invoked and can occur in a variety of situations, 
for example, in assignments and methods invocations. Predefined C# implicit conversions always succeed 
and never throw an exception. User-defined implicit conversions should behave in that way as well. 
If a custom conversion can throw an exception or lose information, define it as an explicit conversion. */

using static System.Console;

namespace CustomConversions
{
    class Year
    {
        public int Days
        {
            get;
            set;
        }

        public static implicit operator Year(int y)
        {
            return new Year { Days = y };
        }
        public static explicit operator int(Year counter)
        {
            return counter.Days;
        }
    }

    class Program
    {
        static void Main()
        {
            WriteLine("--- Implicit Conversion ---");

            Year dayCounterImp = new Year { Days = 365 };

            int y = (int)dayCounterImp;
            WriteLine("Implicit conversion result: " + y);

            WriteLine("--- Explicit Conversion ---");

            Year dayCounterExp = y;
            WriteLine("Explicit conversion result: " + dayCounterExp.Days);
        }
    }
}
