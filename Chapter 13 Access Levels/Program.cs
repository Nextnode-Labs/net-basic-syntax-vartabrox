/* Every class member has an accessibility level that determines where the
member will be visible. */

using System;

class General
{
    int accessDefault = 0; // in this case, private access
    public int accessPublic = 1; // unrestricted access
    protected internal int accessProtInt = 2; // defining assembly or derived class
    private protected int accessPrivProt = 3; // derived class within defining assembley
    internal int accessInternal = 4; // defining assembley 
    protected int accessProtected = 5; // derived class
    private int accessPrivate = 6; // defining class only

    void PrintDefault() => Console.WriteLine(accessDefault); 
    public void PrintPublic() => Console.WriteLine(accessPublic); 
    protected internal void PrintProtInt() => Console.WriteLine(accessProtInt); 
    private protected void PrintPrivProt() => Console.WriteLine(accessPrivProt); 
    internal void PrintInternal() => Console.WriteLine(accessInternal); 
    protected void PrintProtected() => Console.WriteLine(accessProtected); 
    private void PrintPrivate() => Console.WriteLine(accessPrivate); 
    
}

class Second
{
    public void PrintSC()
    {
        General general = new General();

        Console.WriteLine(general.accessInternal);
        Console.WriteLine(general.accessProtInt);
        Console.WriteLine(general.accessPublic);
    }
}

class Inheritor : General
{
    public void PrintInheritor ()
    {
        Inheritor inh = new Inheritor();

        Console.WriteLine(inh.accessProtected);
        Console.WriteLine(inh.accessInternal);
        Console.WriteLine(inh.accessPrivProt);
        Console.WriteLine(inh.accessProtInt);
        Console.WriteLine(inh.accessPublic);
      
    }
}

class Program 
{
    static void Main()
    {   
        Console.WriteLine("--- Access Levels ---");

        Console.WriteLine("--- Methods and fileds of General class ---");
        General a = new General();
        a.PrintInternal();
        a.PrintProtInt();
        a.PrintPublic();

        Console.WriteLine("--- Methods and fileds of Second class ---");
        Second b = new Second();
        b.PrintSC();
        
        Console.WriteLine("--- Methods and fileds of Inheritor class ---");
        Inheritor c = new Inheritor();
        c.PrintInheritor();
    }
}
