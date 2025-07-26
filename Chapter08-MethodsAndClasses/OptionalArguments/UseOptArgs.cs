namespace Chapter08_MethodsAndClasses.OptionalArguments;

// Use an optional argument to simplify a call to a method.

class UseOptArgs {
    
    // Display part or all of string.
    public void Display(string str, int start = 0, int stop = -1) {
        if(stop < 0)  stop = str.Length;

        if(stop > str.Length | start > stop | start < 0) return;

        for (int i = start; i < stop; i++)
        {
            Console.Write(str[i]);
        }
        Console.WriteLine();
    }
}