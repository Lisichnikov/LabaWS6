class Program
{
    static void Main()
    {
        Mercedes sedan = new Mercedes();
        Boeing boeing = new Boeing();
        Yacht ship = new Yacht();

        Console.WriteLine(sedan.GetInfo());
        Console.WriteLine(boeing.GetInfo());
        Console.WriteLine(ship.GetInfo());
    }
}