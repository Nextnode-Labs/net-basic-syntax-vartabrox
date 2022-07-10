/* The static keyword can be used to declare fields and methods that can
be accessed without having to create an instance of the class. */

using System;

class Circle
{
    public Circle() {}

    // accesing sstatic members
    public float r = 15F;

    public static float pi = 3.14F;

    public float GetArea()
    {
        return ComputeArea(r);
    }

    public static float ComputeArea(float a)
    {
        return pi*a*a;
    }

    // static fields
    int age;
    public static int retirementAge = 65;
    public Circle(int age)
    {
        this.age = age;
    }
    public void CheckAge()
    {
        if (age >= retirementAge)
            Console.WriteLine("Already retired");
        else
            Console.WriteLine($"How many years until retirement?: {retirementAge - age}");

    }
}

static class Operations
    {
        public static int Add(int x, int y) => x + y;
        public static int Subtract(int x, int y) => x - y;
        public static int Multiply(int x, int y) => x * y;
    }

class Person
{
    static int retirementAge2;
    public static int RetirementAge2 => retirementAge2;
    static Person() // static constructor
    {
        if (DateTime.Now.Year == 2022)
            retirementAge2 = 70;
        else
            retirementAge2 = 65;
    }

}

static class ExtMetgods
{
    public static int Count(this string str, char c) // extension method
    {
        int counter = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == c)
                counter++;
        }
        return counter;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Accessing Static Members ---");

        float f = Circle.ComputeArea(Circle.pi);
        Console.WriteLine(f);

        Circle areaCircle = new Circle();
        float b = areaCircle.GetArea();
        
        Console.WriteLine(b);
        
        Console.WriteLine("--- Static Methods ---");

        // static methods (static void Main())
        double pi2 = System.Math.PI;
        Console.WriteLine(pi2);

        Console.WriteLine("--- Static Fields ---");
        
        Circle manOne = new Circle(71);
        manOne.CheckAge(); // already retired

        Circle manTwo = new Circle(44);
        manTwo.CheckAge(); // how many years until retirement: 21

        Console.WriteLine(Circle.retirementAge + " - getting a static field");

        Console.WriteLine("--- Static Classes ---");

        Console.WriteLine(Operations.Add(4, 7)); // 11
        Console.WriteLine(Operations.Subtract(4, 7)); // -3
        Console.WriteLine(Operations.Multiply(4, 7)); // 28

        Console.WriteLine("--- Static Constructor ---");

        Console.WriteLine("Retirement age in Argentina - " + Person.RetirementAge2);

        Console.WriteLine("--- Static Local Funtions ---");

        int Sum(int[] numbers)
        {
            int result = 0;
            int limit = 0;
            foreach (int number in numbers)
            {
                if (IsPassed(number, limit)) result += number;
            }
            return result;
        
            static bool IsPassed(int number, int lim) // static local function
            {
                return number > lim;
            }
        }
        int[] numbers1 = { -2, -1, 0, 1, 2, 3, 4 };
        int[] numbers2 = { 2, -3, 8, -5, 9 };
        
        Console.WriteLine(Sum(numbers1));
        Console.WriteLine(Sum(numbers2));
        
        Console.WriteLine("--- Extension Methods ---");

        string s = "Hello world!";
        char c = 'l';
        int i = s.Count(c);
        Console.WriteLine(i); // 3 letters l in "Hello world"

    }
}
