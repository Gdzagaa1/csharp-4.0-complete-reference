namespace Chapter08_MethodsAndClasses.Overloading;


/*
 * Demonstrate use of Stack class which has overloaded constructor.
 */
public class StackDemo
{
    public void useStack() {
        Stack stk1 = new Stack(10);
        char ch;
        int i;
        
        Console.WriteLine("Push A through J onto stk1.");
        for(i = 0; !stk1.IsFull(); i++)
            stk1.Push((char) ('A' + i));
        
        // Create a copy of stck1.
        Stack stk2 = new Stack(stk1);
        
        // Display the contents of stk1.
        Console.Write("Contents of stk1: ");
        while(!stk1.IsEmpty()) {
            ch = stk1.Pop();
            Console.Write(ch);
        }
        
        Console.WriteLine();
        Console.Write("Contents of stk2: ");
        while (!stk2.IsEmpty()) {
            ch = stk2.Pop();
            Console.Write(ch);
        }
        Console.WriteLine("\n");
    }
}