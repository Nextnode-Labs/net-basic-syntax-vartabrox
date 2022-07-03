/* A member in a derived class can redefine a member in its base class. This
can be done for all kinds of inherited members, but it is most often used
to give instance methods new implementations. */

using System;

class Animals // base class
{
    public int paws = 4, ears = 2;
    public virtual int GetAnimal() 
    {
        return paws + ears;
    }

    public int GetAnimalNow() 
    {
        return paws + ears;
    }

    public virtual void GetTail() {}

    string bm = "Base Method";

    public virtual string BaseMethod ()
    {
        return bm;
    }

    public Animals () {}

    int n;
    public Animals(int z, int x)
    {
        n = z * x - x;
    }

    public void Print()
    {
        Console.WriteLine(n);
    }
}

class Dogs : Animals // derived class
{
    public override int GetAnimal() // overridden method
    {
        return paws * 8;
    }

    public new int GetAnimalNow() // hidden method 
    {
        return paws * 10;
    }

    /* to stop an override method, he is can be declared as sealed 
    to negative the virtual modifier */
    public sealed override void GetTail () {} 

    public override string BaseMethod ()
    {
        return base.BaseMethod().ToUpper();
    }

    public Dogs() {}
    public Dogs(int z) : base(z, z) {}

}

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Hiding and Overriding ---");

        Animals dogAsAnimal = new Dogs();
        int a = dogAsAnimal.GetAnimalNow(); // hiding  
        int b = dogAsAnimal.GetAnimal(); // overiding

        Console.WriteLine(a); 
        Console.WriteLine(b);

        Console.WriteLine("--- Base Keyword ---");
        string c = dogAsAnimal.BaseMethod();
        Console.WriteLine(c);

        Animals animals = new Animals (3,5);
        animals.Print(); // 3*5-5=10

        Dogs dogs = new Dogs(9);
        dogs.Print(); // 9*9-9=81
    }
}
