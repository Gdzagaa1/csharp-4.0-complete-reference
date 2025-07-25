namespace Chapter07_ArraysAndStrings.Strings;
using System.Globalization;

/**
 * Book examples of strings
 * from Chapter 7 for testing/learning (Some of them may be changed).
 */
public class StringExamples
{
    public static void StrOps() {
        string str1 = "When it comes to .NET programming, C# is #1.";
        string str2 = "When it comes to .NET programming, C# is #1.";
        string str3 = "C# strings are powerful.";
        string strUp, strLow;
        int result, idx;
        Console.WriteLine("str1: " + str1);
        Console.WriteLine("Length of str1: " + str1.Length);
        
        // Create upper- and lowercase versions of str1.
        strLow = str1.ToLower(CultureInfo.CurrentCulture);
        strUp = str1.ToUpper(CultureInfo.CurrentCulture);
        Console.WriteLine("Lowercase version of str1:\n     " + strLow);
        Console.WriteLine("Uppercase version of str1:\n     " + strUp);
        Console.WriteLine();
        
        // Display str1, one char at a time.
        Console.WriteLine("Display str1, one char at a time.");
        
        for(int i=0; i < str1.Length; i++)
            Console.Write(str1[i]);
        Console.WriteLine("\n");
        
        // Compare strings using == and !=. These comparisons are ordinal.
        if(str1 == str2)
            Console.WriteLine("str1 == str2");
        else
            Console.WriteLine("str1 != str2");
        if(str1 == str3)
            Console.WriteLine("str1 == str3");
        else
            Console.WriteLine("str1 != str3");
        
        // This comparison is culture-sensitive.
        result = string.Compare(str1, str3, StringComparison.CurrentCulture);
        if(result == 0)
            Console.WriteLine("str1 and str3 are equal");
        else if(result < 0)
            Console.WriteLine("str1 is less than str3");
        else
            Console.WriteLine("str1 is greater than str3");
        Console.WriteLine();
        
        // Assign a new string to str2.
        str2 = "One Two Three One";
        
        // Search a string.
        idx = str2.IndexOf("One", StringComparison.Ordinal);
        Console.WriteLine("Index of first occurrence of One: " + idx);
        idx = str2.LastIndexOf("One", StringComparison.Ordinal);
        Console.WriteLine("Index of last occurrence of One: " + idx);
    }
    
    
    
    // A string can control a switch statement.
    public static void StringSwitch() {
        string[] strs = { "one", "two", "three", "two", "one" };
        foreach(string s in strs) {
            switch(s) {
                case "one":
                    Console.Write(1);
                    break;
                case "two":
                    Console.Write(2);
                    break;
                case "three":
                    Console.Write(3);
                    break;
            }
        }
        Console.WriteLine();
    }
    
}