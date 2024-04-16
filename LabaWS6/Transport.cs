abstract class Transport
{
    public abstract int Speed { get; }
    public abstract int CarryingCapacity { get; }
    public abstract int Range { get; }
    public abstract string GetInfo();
}