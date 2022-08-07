/* Operator overloading allows operators to be redefined and used where one
or both of the operands are of a certain class. */

using static System.Console;

namespace OperatorOverloading
{
    class Program
    {
        static void Main()
        {
            WriteLine("--- Operator Overloading Example ---");

            Operators a = new Operators(7);
            Operators b = new Operators(9);
            Operators c = Operators.Add(a, b);
            WriteLine(c);

            WriteLine("--- Binary Operator Overloading ---");

            int d = a.number + b.number;
            WriteLine("Operands: a = {0}, b = {1}", a.number, b.number);
            WriteLine("d = " + d);

            WriteLine("--- Unary Operator Overloading ---");

            Operators unary = new Operators(12);
            WriteLine(unary.number++);
            WriteLine(++unary.number);

            WriteLine("--- Return Types and Parameters ---");

            Operators returnParam = new Operators(19);
            returnParam.g = 3;
            WriteLine(returnParam.number + returnParam.g);

            WriteLine("--- True and False Operator Overloading ---");

            Operators operators = new Operators(44);
            if (operators)
                WriteLine("True"); // 44 != 0
            else
                WriteLine("False");

        }
    }

    class Operators
    {
        public int number;
        public Operators(int x)
        {
            number = x;
        }
        public static Operators Add(Operators a, Operators b)
        {
            return new Operators(a.number + b.number);
        }

        // binary operator overloading
        public static Operators operator +(Operators a, Operators b)
        {
            return new Operators(a.number + b.number);
        }

        // unary operator overloading
        public static Operators operator ++(Operators a)
        {
            return new Operators(a.number + 1);
        }

        // return types and parameters
        public int g;
        public static Operators operator +(Operators a, int g)
        {
            return new Operators(a.number + g);
        }

        // true and false operator overloading
        public static bool operator true(Operators a)
        {
            return (a.number != 0);
        }
        public static bool operator false(Operators a)
        {
            return (a.number == 0);
        }
    }
}
