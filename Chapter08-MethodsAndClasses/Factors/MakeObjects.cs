namespace Chapter08_MethodsAndClasses;

public class MakeObjects
{
    public void make()
    {
        FactoryDemo ob = new FactoryDemo();
        int i, j;

        for (i = 0, j = 10; i < 10; i++, j--)
        {
            FactoryDemo anotherOb = ob.Factory(i, j);
            anotherOb.Show();
        }

        Console.WriteLine();
    }
}