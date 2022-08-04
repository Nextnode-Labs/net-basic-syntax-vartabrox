/* Exception handling allows programmers to deal with unexpected
situations that may occur in programs.  */

using static System.Console;

public class Person : IDisposable
{
    public string Name { get; }
    public Person(string name) => Name = name;

    public void Dispose() => Console.WriteLine($"{Name} has been disposed");
}

namespace ExceptionHandling
{

    class Program
    {
        static void Main()
        {
            WriteLine("--- Try-Catch Statement ---");

            try
            {
                StreamReader streamReader = new StreamReader("lost.avi");
            }
            catch
            {
                WriteLine("Error: file not found");
            }

            WriteLine("--- Catch Block ---");

            try
            {
                int x = 1;
                int y = x / 0;
            }
            catch (Exception ex)
            {
                WriteLine("Error: " + ex.Message);
            }

            WriteLine("--- Exception Filters ---");

            int a = 9;
            int d = 0;

            try
            {
                int result1 = a / d;
                int result2 = d / a;
            }
            catch (DivideByZeroException) when (d == 0)
            {
                Console.WriteLine("D must not be equal to 0");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            WriteLine("--- Finally Block ---");

            try
            {
                Console.WriteLine("Enter a number: ");


                var num = Convert.ToInt32(ReadLine());

                Console.WriteLine($"Squre of {num} is {num * num}");
            }
            catch (Exception ex)
            {
                Console.Write("Error info: " + ex.Message);
            }
            finally
            {
                Console.Write("Re-try with a different number.");
            }

            WriteLine("--- The using Statement ---");

            Test();

            void Test()
            {
                using (Person tom = new Person("Mr. Anderson"))
                {
                    Console.WriteLine($"Name: {tom.Name}");
                }
                Console.WriteLine("The end of Test method");
            }

            WriteLine("--- Throwing Exceptions ---");

            try
            {
                Console.Write("Enter your name: ");
                string? name = Console.ReadLine();
                if (name == null || name.Length < 3)
                {
                    throw new Exception("Name length is less than 3 characters");
                }
                else
                {
                    Console.WriteLine($"Your name: {name}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
