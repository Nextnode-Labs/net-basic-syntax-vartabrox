/* An interface is used to specify members that deriving classes must
implement. */

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Interface Example and Class Interface ---");

        IMovable action = new BaseAction();

        action.Move(); // move
        action.Run(); // run

        Console.WriteLine("--- Default Implementations ---");

        action.Go();
    }
}

interface IAnimal
{
    void animalSound(); // interface method

    int Area { get; set; } // interface property

    int this[int indexer] { get; set; } // interface indexer
}

interface IMovable
{
    void Move();

    void Run();

    void Go() => Console.WriteLine(); // default Implementations
}

class BaseAction : IMovable
{
    public void Move()
    {
        Console.WriteLine("Move");
    }

    public void Run()
    {
        Console.WriteLine("Run");
    }

    public void Go()
    {
        Console.WriteLine("Go");
    }

}
