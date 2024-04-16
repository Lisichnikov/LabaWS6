abstract class Ship : Transport
{
    public override string GetInfo()
    {
        return $"Корабль со скоростью {Speed} узлов, грузоподъемностью {CarryingCapacity} килограмм, может пройти {Range} морских миль.";
    }
}
class Yacht : Ship
{
    public override int Speed => 23;
    public override int CarryingCapacity => 500;
    public override int Range => 12000;
}
