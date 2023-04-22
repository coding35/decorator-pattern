using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

Component componentA = new ConcreteComponentA(); 
componentA.SetMultiplier(2);                        
componentA = new ConcreteDecoratorA(componentA);    // 4   
componentA = new ConcreteDecoratorB(componentA);    // 8 
componentA = new ConcreteDecoratorB(componentA);    // 12  
componentA = new ConcreteDecoratorB(componentA);    // 16 

Console.WriteLine(componentA.Amount());             // 16