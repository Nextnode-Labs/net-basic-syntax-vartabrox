/* Indexers allow an object to be treated as an array. They are declared in
the same way as properties, except that the this keyword is used instead
of a name and their accessors take parameters. */

using System;

class MyClass
{
    private int[] myArray = new int[] {1989, 2005, 2009, 2014, 2020};

    public int this[int index] // indexer
    {
        get { return myArray[index]; }
        set { myArray[index] = value; }
    }

    // indexer parameters
    int[,] numbers = new int[,] { { 3, 4, 6 }, { 4, 5, 8 }, { 5, 6, 10 } };

    public int this[int i, int j]
    {
        get => numbers[i, j];
        set => numbers[i, j] = value;
    }
}

class Person
{
    public string Name { get;}
    public Person(string name) => Name=name;
}
class Company
{
    Person[] personal;
    public Company(Person[] people) => personal = people;
    
    public Person this[int index]
    {
        get => personal[index];
        set => personal[index] = value;
    }
 
    public Person this[string name]
    {
        get
        {
            foreach (var person in personal)
            {
                if (person.Name == name) return person;
            }
            throw new Exception("Unknown name");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Indexers ---");

        MyClass instance = new MyClass();

        instance[3] = 2012;

        for (int i = 0; i < 5; i++)
            Console.WriteLine(instance[i]);

        Console.WriteLine("--- Indexer Parameters ---");

        MyClass matrix = new MyClass();

        Console.WriteLine(matrix[2, 2]);

        matrix[2, 2] = 99;

        Console.WriteLine(matrix[2, 2]);

        Console.WriteLine("--- Indexer Overloading ---");

        var microsoft = new Company(new Person[] { new("Octavius"), new("Tiberius"), new("Claudius") });
        
        Console.WriteLine(microsoft[0].Name);      // Octavius
        Console.WriteLine(microsoft["Claudius"].Name);  // Claudius

        Console.WriteLine("--- Ranges and Indices ---");

        Index myIndex1 = 1;     
        Index myIndex2 = ^3;    
        
        string[] earth = { "Europe", "Africa", "South America", "North America", "Australia" };
        string continent1 = earth[myIndex1];    
        string continent2 = earth[myIndex2];    
        Console.WriteLine(continent1); // Africa
        Console.WriteLine(continent2); // South America

        int[] b = { 11, 12, 13, 14, 15 };
        foreach (int n in b[2..4]) {
        System.Console.Write(n); // "34"
        }

        Console.WriteLine();

        System.Range range = 0..2; 
        foreach (int n in b[range]) {
        System.Console.Write(n); // "12"
        }
    }
}
