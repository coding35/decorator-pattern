namespace DecoratorPattern.Component;

public abstract class Component
{
    private static int _multiplier;
    
    public void SetMultiplier(int multiplier)
    {
        _multiplier = multiplier;
    }

    protected static int GetMultiplier()
    {
        return _multiplier;
    }
    
    public abstract decimal Amount();
}