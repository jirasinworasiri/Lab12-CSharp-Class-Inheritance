DerivedClass dc = new DerivedClass();
dc.Greeting();

class BaseClass
{
    public string HelloBase = "Hello From BaseClass";  
    public void Greeting()
    {
        Console.WriteLine("This is method in BaseClass");
        Console.WriteLine(HelloBase);  
    }
}

class DerivedClass : BaseClass
{
    public string HelloDerived = "Hello From DerivedClass";  
    public new void Greeting()  
    {
        Console.WriteLine("This is method in DerivedClass");
        Console.WriteLine(HelloDerived);  
    }
}
