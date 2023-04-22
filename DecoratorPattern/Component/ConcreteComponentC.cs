namespace DecoratorPattern.Component;

public class ConcreteComponentC : Component
{
    public override decimal Amount()
    {
        return 3M * GetMultiplier();
    }
}