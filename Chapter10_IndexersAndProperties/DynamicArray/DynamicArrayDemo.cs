namespace Chapter10_IndexersAndProperties.DynamicArray;

public class DynamicArrayDemo
{
    public static void UseDynamicArray() 
    {
        DynamicArray da = new DynamicArray();
        
        Console.WriteLine("Initial length: " + da.Length);
        Console.WriteLine("Adding elements 1 through 15...\n");
        
        // Add elements to demonstrate growth
        for (int i = 1; i <= 15; i++)
        {
            da.Add(i);
            Console.WriteLine($"Added {i}, Length: {da.Length}");
        }
        
        Console.Write("\nContents of da: ");
        for (int i = 0; i < da.Length; i++)
        {
            Console.Write(da[i] + " ");
        }
        Console.WriteLine("\n");

        // Demonstrate indexer modification
        Console.WriteLine("Modifying elements at indices 0, 5, and 10...");
        da[0] = 100;
        da[5] = 500;
        da[10] = 1000;
        
        Console.Write("Modified contents: ");
        for (int i = 0; i < da.Length; i++)
        {
            Console.Write(da[i] + " ");
        }
        Console.WriteLine("\n");

        // Test error handling
        Console.WriteLine("Testing bounds checking...");
        Console.WriteLine("Accessing index -1:");
        int value = da[-1];
        Console.WriteLine($"Value: {value}, Error: {da.Error}");
        
        Console.WriteLine("Accessing index 100:");
        value = da[100];
        Console.WriteLine($"Value: {value}, Error: {da.Error}");
        
        Console.WriteLine("Accessing valid index 5:");
        value = da[5];
        Console.WriteLine($"Value: {value}, Error: {da.Error}");
    }

}