/* A delegate is a type used to reference a method. This allows methods to be
assigned to variables and passed as arguments. The delegate’s declaration
specifies the method signature to which objects of the delegate type
can refer. */

#nullable disable

using static System.Console;

namespace Delegates
{
    class DelegateLab
    {
        public static void PrintMess() => WriteLine("Maybe we'll play tennis tomorrow?");
    }

    class DelegateLab2
    {
        public void PrintMess() => WriteLine("Great idea!");
    }

    class Color
    {
        public string colorName => "Green";
        public void PrintColorName() => WriteLine(colorName);
    }

    // delegate signature
    class Parents { }

    class Children : Parents { }

    class Program
    {
        delegate void MessageDelegate(); // declare a delegate

        delegate void MyMessageDelegate(string mymessage);

        delegate void NewMail(string message);

        delegate int LambdaDelegate(int number);

        static int numberID = 999; // capturing outer variables

        delegate void MulticastDelegate();

        static void FirstMethod() { WriteLine("First Line"); }
        static void SecondMethod() { WriteLine("Second Line"); }

        // delegate signature
        delegate Parents ChildrenDelegate(Children children);

        static Children DSMethod(Parents name)
        {
            return new Children();
        }

        // delegates as parameters

        static void DoMathOperation(int a, int b, MathOperations oper)
        {
            WriteLine(oper(a, b));
        }

        static int Add(int x, int y) => x + y;
        static int Subtract(int x, int y) => x - y;
        static int Multiply(int x, int y) => x * y;

        delegate int MathOperations(int x, int y);

        static void Main()
        {
            WriteLine("--- Delegate Syntax ---");

            void InboxMessage() => WriteLine("Hello! What are you doing?");
            MessageDelegate message = InboxMessage;
            message();

            MessageDelegate print1 = new DelegateLab2().PrintMess;
            MessageDelegate print2 = DelegateLab.PrintMess;

            print1(); // Maybe we'll play tennis tomorrow?
            print2(); // Great idea!

            void InboxMessage2(string mymess) => WriteLine(mymess);

            MyMessageDelegate message2 = InboxMessage2;

            message2("I'm already hungry!");

            WriteLine("--- Anonymous Methods ---");

            NewMail newmail = delegate (string mes)
            {
                WriteLine(mes);
            };

            newmail("Let's order pizza.");

            WriteLine("--- Lambda Expressions ---");

            // anonymous method
            LambdaDelegate anonymMet = delegate (int num)
            {
                return num * num;
            };

            // lambda expression
            LambdaDelegate lambdaEx = (int num2) => num2 * num2;

            WriteLine(anonymMet(9)); // 81
            WriteLine(lambdaEx(7)); // 49

            WriteLine("--- Expression Body Members ---");

            Color color = new Color();
            color.PrintColorName();

            WriteLine("--- Type Inference ---");

            /* As of C# 10, it became possible to use type inference to have the compiler
            automatically infer a delegate type for a lambda. */

            var varType = (int num3) => num3 + num3;
            WriteLine(varType(11)); // 22

            var varType2 = object (bool trueOrFalse) => trueOrFalse ? "TRUE" : "FALSE";
            WriteLine(varType2(false)); // false

            WriteLine("--- Capturing Outer Variables ---");

            int xyz = 77;
            var newXYZ = (int integer) => xyz = integer; // capture local var xyz
            WriteLine(xyz); // 99
            newXYZ(40);
            WriteLine(xyz); // 40

            var id = static (int ID) => ID + Program.numberID;
            WriteLine(id(345)); // 1344

            WriteLine("--- Multicast Delegates ---");

            MulticastDelegate multicast = FirstMethod;

            multicast = multicast + FirstMethod;
            multicast();
            multicast += SecondMethod;
            multicast();

            // remove a method from the invocation list

            multicast -= FirstMethod;
            multicast();

            WriteLine("--- Delegate Signature ---");

            ChildrenDelegate signature = DSMethod;

            WriteLine("--- Delegates As Parameters ---");

            DoMathOperation(11, 4, Add);         // 15
            DoMathOperation(5, 9, Subtract);    // -4
            DoMathOperation(8, 21, Multiply);    // 168
        }
    }
}
