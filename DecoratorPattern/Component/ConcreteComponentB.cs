namespace DecoratorPattern.Component;

public class ConcreteComponentB : Component
{
    public override decimal Amount()
    {
        return 2M * GetMultiplier();
    }
}