abstract class Car : Transport
{
    public override string GetInfo()
    {
        return $"Машина со скоростью {Speed} км/ч, грузоподъемностью {CarryingCapacity} кг, может проехать {Range} км.";
    }
}

class Mercedes : Car
{
    public override int Speed => 180;
    public override int CarryingCapacity => 500;
    public override int Range => 800;

    public override string GetInfo()
    {
        return $"Легковой автомобиль со скоростью {Speed} км/ч, грузоподъемностью {CarryingCapacity} кг, может проехать {Range} км.";
    }
}