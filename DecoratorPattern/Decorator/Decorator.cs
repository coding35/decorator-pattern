namespace DecoratorPattern.Decorator;

public abstract class Decorator : Component.Component
{
    private readonly Component.Component _wrappedObj;


    
    protected Decorator(Component.Component component)
    {
        _wrappedObj = component;
    }

    protected int GetComponentMultiplier()
    {
        return Component.Component.GetMultiplier();
    }
}