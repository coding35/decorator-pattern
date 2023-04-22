namespace DecoratorPattern.Decorator;

public class ConcreteDecoratorB : Decorator
{
    private readonly Component.Component _component;
    
    public ConcreteDecoratorB(Component.Component component) : base(component)
    {
        _component = component;
    }
    
    public override decimal Amount()
    {
        return _component.Amount() + (2M * GetComponentMultiplier());
    }
}