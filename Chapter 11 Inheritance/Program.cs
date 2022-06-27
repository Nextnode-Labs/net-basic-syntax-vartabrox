// Inheritance allows a class to acquire the members of another class

class FootballPlayer : Person // derived class
{
    public string cob = "France";
    public string team = "Juventus";
}

class Person // base class
{
    public string name = "Zidane";
    public int age = 50;
    public string? post;
    public Person(){}
    public Person(string post) 
    {
        this.post = post;
        Console.WriteLine(post);
    } 
}

class Program : System.Object // object class
{
    static void Main()
    {
        Console.WriteLine("--- Inheritance ---");

        FootballPlayer fp = new FootballPlayer();
        Console.WriteLine($"Name: {fp.name}; Age: {fp.age}");     
        Console.WriteLine($"Team: {fp.team}; Country of birthday: {fp.cob}");     

        Console.WriteLine("--- Object Class ---");

        System.Object obj = new object();   
        Console.WriteLine(obj.ToString()); // System.Object
        Console.WriteLine(fp.ToString()); // FootballPlayer

        Console.WriteLine("--- Downcast and Upcast ---");

        FootballPlayer goalkeeper = new FootballPlayer();
        Person player = goalkeeper; // upcast FootballPlayer to Person
        FootballPlayer midfielder = (FootballPlayer)goalkeeper; // explicit downcast Person to FootballPlayer

        Console.WriteLine("--- Boxing and Unboxing ---");

        int players = 11;
        object box = players; // boxing
        players = (int)box; // explicit unboxing
        
        Console.WriteLine("--- The is and as Keywords ---");

        // is keyword
        Person keywords = new FootballPlayer();
        if (keywords is FootballPlayer) 
        {
            FootballPlayer ob = (FootballPlayer)keywords; // true
            Console.WriteLine(ob);
        }
        // as keyword
        Person pers = new Person("Coach");
        FootballPlayer? footballplayer = pers as FootballPlayer;
        if (footballplayer == null)
            Console.WriteLine("The conversion was successful");
        else
            Console.WriteLine("Seccessful");

        Console.WriteLine("--- Pattern Matching ---");

        object? speed = null;
        // cheking for null
        if (speed is null) Console.WriteLine("speed is null");
    }
}
