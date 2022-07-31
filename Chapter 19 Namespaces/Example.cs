namespace General;

class River
{
    string title;
    public River(string title) => this.title = title;
    public void Print() => Console.WriteLine($"River: {title}");
}