namespace Chapter08_MethodsAndClasses;

public class FactoryDemo
{
    int a, b;
    
    // Create a class factory.
    public FactoryDemo Factory(int i, int j)
    {
        FactoryDemo t = new FactoryDemo();
        t.a = i;
        t.b = j;
        return t;
    }

    public void Show() {
            Console.WriteLine("a and b: " + a + " " + b);
    }
}

