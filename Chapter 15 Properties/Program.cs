/* Properties in C# provide the ability to protect a field by reading and writing
to it through special methods called accessors. */

using System;

class Year
{
    private int days;
    public int Days
    {
        get { return days; }
        set { days = value; }
    }

    /* Properties allow developers to change the internal
    implementation of the property without breaking any programs that are
    using it. */
    private byte months;
    public int Months
    {
        get { return (int)months; }
        set { months = (byte)value; }
    }

    /* A second advantage of properties is that they allow the data to be
    validated before permitting a change. */
    private int weeks;
    public int Weeks
    {
        get { return weeks; }
        set 
        {
            if ( value > 0 && value < 54 )
                weeks = value;
            else
                Console.WriteLine("There can't be so many weeks in a year");
        }
    }

    /* Properties do not have to correspond to an actual field. They can just
    as well compute their own values. */
    string capital;
    string country;
    public string Discovery
    {
        get { return $"{capital}, {country}";}
    }
    //public Year() {}
    public Year(string capital, string country)
    {
        this.capital = capital;
        this.country = country;
    }

    // property Access Levels
    string actor = "Bruce Willis";
    int age = 67;
    // write-only property
    public int Age
    {
        set { age = value; }
    }

    // read-only property
    public string Actor
    {
        get { return actor; }
    }

    public void Print() => Console.WriteLine($"Actor: {actor} Age: {age}");
}

class Person
{
    string name = " ";
    public string Name
    {
    get { return name; }
    private set { name = value; }
    }
    public Person(string name) => Name = name;
    
}

class AutoProp
{
    public string Name { get; set; }
    public int Age { get; set; }
         
    public AutoProp(string name, int age)
    {
    Name = name;
    Age = age;
    }

    public int Wood { get; init; }
}

class Program
{
    static void Main()
    {
        Year y = new Year("Antananarivo", "Madagascar");
        y.Days = 365;
        int d = y.Days; // 365

        Console.WriteLine("--- Properties ---");
        Console.WriteLine(d + " days in the year");

        Console.WriteLine("--- Property Advantages ---");

        y.Months = 12;
        int m = y.Months; // 12
        Console.WriteLine(m + " months in the year");

        y.Weeks = 42;
        int w = y.Weeks; // 42
        Console.WriteLine(w + " weeks is 294 days");
        y.Weeks = 56; // there can't be so many weeks in a year

        //Year dis = new Year("Antananarivo", "Madagascar");
        Console.WriteLine(y.Discovery);

        Console.WriteLine("--- Read-Only and Write-Only Properties ---");

        Console.WriteLine(y.Actor); // Bruce Willis (read-only)
        y.Age = 70; // write-only
        y.Print(); // Actor: Bruce Willis Age: 70

        Console.WriteLine("--- Property Access Levels ---");
        Person man = new Person("Homer Simpson");
        Console.WriteLine(man.Name);
        //  error - set declare with private modifier
        // man.Name = "Bart"; 

        Console.WriteLine("--- Auto-implemented Properties ---");

        AutoProp tree = new AutoProp("Oak", 300) { Wood = 1000000};

        Console.WriteLine(tree.Name);
        Console.WriteLine(tree.Age);

        //AutoProp wood = new AutoProp() { Wood = 1000000};

        Console.WriteLine(tree.Wood + " trees in the forest");
    }
        
}
