namespace DecoratorPattern.Decorator;

public class ConcreteDecoratorA : Decorator
{
    private readonly Component.Component _component;
    
    public ConcreteDecoratorA(Component.Component component) : base(component)
    {
        _component = component;
    }
    
    public override decimal Amount()
    {
        return _component.Amount() + (1M * GetComponentMultiplier());
    }
}