/* An abstract class provides a partial implementation that other classes
can build on. When a class is declared as abstract, it means that the class
can contain incomplete members that must be implemented in derived
classes, in addition to normal class members. */

using System;

abstract class Animal
{
    public abstract void animalWeight(); // abstract method

    public void animalFood() => Console.WriteLine("Predatory animals eat meat.");


    public abstract int animalArea { get; set; } // abstract property

    public abstract int this[int index] { get; set; } // abstract indexer

    //public delegate void MyAnimal(); // abstract event
    //public abstract event MyAnimal MyEvent;

}

class Leon : Animal
{
    public override void animalWeight()
    {
        Console.WriteLine("The average weight of a lion is 180 kg.");
    }

    private int area;
    public override int animalArea
    {
        get { return area; }
        set { area = value; }
    }

    private int[] speed = new int[] { 30, 40, 50 };
    public override int this[int index]
    {
        get { return speed[index]; }
        set { speed[index] = value; }
    }
}

abstract class Birds : Animal
{
    /* The deriving class can be declared abstract as well, in which case it
does not have to implement any of the abstract members. */
}

// abstract Classes and Interfaces
interface IMovable
{
    void Move();
}
abstract class Person : IMovable
{
    public abstract void Move();
}
class Driver : Person
{
    public override void Move() => Console.WriteLine("Driver driving a car");
}


class Program
{
    static void Main()
    {
        Leon myLeon = new Leon();

        Console.WriteLine("--- Abstract Members ---");

        myLeon.animalArea = 350;
        int a = myLeon.animalArea;
        Console.WriteLine(a);

        myLeon[2] = 75;
        for (int s = 0; s < 3; s++)
            Console.WriteLine(myLeon[s]);

        myLeon.animalWeight();
        myLeon.animalFood();

        Console.WriteLine("--- Abstract Classes and Interfaces ---");

        IMovable moving = new Driver();

        moving.Move();
    }
}
