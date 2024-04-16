abstract class Airplane : Transport
{
    public override string GetInfo()
    {
        return $"С со скоростью {Speed} км/ч, грузоподъемностью {CarryingCapacity} кг, может пролететь {Range} км.";
    }
}
class Boeing : Airplane
{
    public override int Speed => 920;
    public override int CarryingCapacity => 250000;
    public override int Range => 13400;

    public override string GetInfo()
    {
        return $"Боинг летит со скоростью {Speed} км/ч, грузоподъемностью {CarryingCapacity} кг, может пролететь {Range} км.";
    }
}