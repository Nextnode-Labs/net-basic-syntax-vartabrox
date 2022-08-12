/* The struct keyword in C# is used to create value types. A struct is
similar to a class in that it represents a structure with mainly field and
method members. However, a struct is a value type, whereas a class is a
reference type. */

using static System.Console;

namespace Struct
{
    struct Fields
    {
        /* Fields within a struct can be assigned initial values. Prior to C# 10, this
        was only allowed for fields declared as const or static. */

        public int floor = 8;
        public static int number = 5;
        public const int number2 = 10;
        public Fields() { }
        public void Print() => WriteLine(floor + number + number2);
    }

    struct Driver
    {
        public string nameDriver;
        public int ageDriver;
        public string driverGender;

        public Driver(string nameDriver = "Daniel", int ageDriver = 33, string driverGender = "Male")
        {
            this.nameDriver = nameDriver;
            this.ageDriver = ageDriver;
            this.driverGender = driverGender;
        }

        public void Print()
        {
            WriteLine($"Name: {nameDriver}, age: {ageDriver}, gender: {driverGender}");
        }
    }

    struct Transport
    {
        public string Type;
        public int Seats;

        public void Print() => WriteLine($"Transport type: {Type}; number of seats: {Seats}");
    }

    class Program
    {
        static void Main()
        {
            WriteLine("--- Struct Variable and Constructors ---");

            Transport t = new Transport();
            t.Type = "Bus";
            t.Seats = 25;
            t.Print();

            WriteLine("--- Struct Constructors ---");

            Driver oneDriver = new Driver("Anderson", 42, "Male");
            Driver twoDriver = new Driver("Alexander", 54, "Male");
            Driver threeDriver = new Driver("Monika", 39, "Woman");

            oneDriver.Print();
            twoDriver.Print();
            threeDriver.Print();

            WriteLine("--- Struct Field Initializers ---");

            Fields values = new Fields();
            values.Print();
        }
    }
}
