namespace DecoratorPattern.Component;

public class ConcreteComponentA : Component
{
    public override decimal Amount()
    {
        return 1M * GetMultiplier();
    }
}