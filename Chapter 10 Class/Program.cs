/* A class is a template used to create objects. They are made up of members,
the main two of which are fields and methods. */

using System;

class Circle 
{
    public double r; // public field - radious of the circle
    public double GetArea() // public method
    {   
        return Math.PI*r*r;
    }
}

class Area 
{
    public int a, b;
    public Area(int sideA, int sideB) // constructor 
    {
        a = sideA; b = sideB;
        Console.WriteLine("Create an object");
    }
    
    public int GetAreaSq()
    {
       return a * b;
    }

    public int q, w;
    public int GetAreaSq2(int sideq, int sidew)
    {
        q = sideq;  
        w = sidew;
        return q * w;
    }
    
    // this keyword
    public string town = default!;
    public string river = default!;
    public Area (string town, string river)
    {
        this.town = town; // set field town to parameter town
        this.river = river;
    }
    public void Print() => Console.WriteLine($"The {river} flows into {town}");

    // constructor overloading
    public int c, v, n;
    public Area() 
    {
        c = 5;
        v = 9;
        Console.WriteLine(c*v);
    }
    public Area(int ca) 
    {
        c = ca;
        v = ca;
        Console.WriteLine(c*v);
    }
    public Area(int ca, int vb, int nb) 
    {
        c = ca;
        v = vb;
        n = nb;
        Console.WriteLine(c*v*nb);
    }

}

class ConstructorChaining
{
        // constructor chaining 
    public int a, b, c;
    public ConstructorChaining() : this(51) 
    {
        a = 51; // initial field values
        b = 91;
        Console.WriteLine(a*b + " - chain 1");
    }
    public ConstructorChaining(int aa) : this (11, 12, 9) 
    {
        a = aa;
        b = aa;
        Console.WriteLine(a*b + " - chain 2");
    }
    public ConstructorChaining(int aa, int bb, int nn) 
    {
        a = aa;
        b = bb;
        c = nn;
        Console.WriteLine(c*b*c + " - chain 3");
    }
}

public partial class Object
{
    // object Initializers
    public int num1, num2;
    string[] favSeries = {"Dark", "LOST", "True Detective"};

    // partial class
    public void FavMS()
    {
        Console.Write("Movies: ");
        foreach (string m in favMovies)
        {   
            Console.Write(m + " ");
        }
        Console.WriteLine();
        Console.Write("Series: ");
        foreach (string m in favSeries)
        {   
            Console.Write(m + " ");
        }
    }
}

public class Finalizer
    // Finalizer
{
    public string? Color { get; }
    public Finalizer (string color) => Color = color;

    ~Finalizer()
    {
        Console.WriteLine($"{Color} has been deleted");
    }

}

public class NullTypes
{
    public string? planet = null; // nullable type with a question mark
    public string galaxy = "Milky Way"; // non-nullable type

    // nullable value types
    public int? ram = null;
    public bool? question = null;

    // null-coalescing operator
    public static string? ocean = null; // static field, otherwise error cs0236
    public string name = ocean ?? "Indian";

    public static int? dob = 1910;
    public int personDob = dob ?? 1935; 

    // null-conditional operator
    static string tree = "Pine";
    public int? tLenght = tree?.Length; // Pine

    static string? tree2 = null;
    public int? tLenght2 = tree2?.Length ?? 0; // 0

    static string[]? dogs = null;
    string? cats = dogs?[5];

    // null-forgiving Operator
    //string food = null!; // warning supressed
 
}
class DefValues // default values
{
    // int myvariable; // field is assigned default value 0
    
    void Default()
    {
        // int myvariable; // local variable must be assigned if used
    }
}

class TypeInference {}

class Classes 
{
    static void Main() 
    {
        Console.WriteLine("--- Object/Instance Creation and Accesing Object Members ---");

        Circle CircleArea = new Circle(); // create an object (instance) of circle and calls default constructor
        CircleArea.r = 4; // radious of the circle
        double x = CircleArea.GetArea();
        Console.WriteLine($"The area of the circle is {x} cm.");

        Console.WriteLine("--- Constructor ---");
        Area ar = new Area(7, 7); //calls constructor
        int areaSquare = ar.a * ar.b;
        Console.WriteLine($"The area of the square is {areaSquare} cm.");       

        Console.WriteLine("--- Just testing different options ---");

        int areaSquare2 = ar.GetAreaSq();
        Console.WriteLine($"The area of the square is {areaSquare2} cm.");

        int areaSquare3 = ar.GetAreaSq2(8, 8); 
        Console.WriteLine($"The area of the square is {areaSquare3} cm.");

        Console.WriteLine("--- This Keyword ---");
        Area geo = new Area("Zhlobin", "Dnepr");
        geo.Print();

        Console.WriteLine("--- Constructor Overloading ---");
        Area over = new Area();
        Area over2 = new Area(3);
        Area over3 = new Area(4, 6, 7);

        Console.WriteLine("--- Constructor Chaining ---");
        ConstructorChaining cnstr = new ConstructorChaining();

        Console.WriteLine("Object Initializers ---");
        Object obj = new Object() {num1 = 8, num2 = 18};
        Console.WriteLine($"num1 plus num2 equals {obj.num1 + obj.num2}");

        Console.WriteLine("--- Partial Class ---");
        obj.FavMS();

        Console.WriteLine("");

        Console.WriteLine("--- Finalizer ---");
        void FinalizerTest()
        {
            Finalizer col = new Finalizer("Yellow");
        }
        FinalizerTest();
        GC.Collect(); // garbadge collection
        // Console.ReadKey(); // delay
        
        Console.WriteLine("--- Null and Nullable Types ---");

        NullTypes space = new NullTypes();
        Console.WriteLine(space.galaxy);
        if (space.planet == null) // check for a null reference
        {
            space.planet = "Earth"; // create a valid object
        }
        int length = space.planet.Length; // 5 symbols 
        Console.WriteLine($"Earth has {length} letters");
        length = (space.planet != null) ? space.planet.Length : 0; // ternary operator

        Console.WriteLine("--- Nullable Value Types ---");

        Console.WriteLine(space.ram + " - nullable Value Types 1 ---");
        Console.WriteLine(space.question + " - nullable Value Types 2");

        Console.WriteLine("--- Null-Coalescing Operator ---");
        
        Console.WriteLine(space.name);
        Console.WriteLine(NullTypes.dob);

        int? fingers = null;
        fingers ??= 20;
        Console.WriteLine(fingers + " fingers");

        Console.WriteLine("--- Null-Conditional Operator ---");
        Console.WriteLine($"World pine contains {space.tLenght} letters");
        Console.WriteLine($"Variable tree2 contains {space.tLenght2} letters");

        Console.WriteLine("--- Type Inference ---");
        var ti = new TypeInference(); // implicit type
        TypeInference ti1 = new TypeInference(); // implicit type

        Console.WriteLine("--- Anonymous Types ---");
        var at = new {yo = 71, name = "Garry"};
        Console.WriteLine(at.name + " " + at.yo);
    }
}
