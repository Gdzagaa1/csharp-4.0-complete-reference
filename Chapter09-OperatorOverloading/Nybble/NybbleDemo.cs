namespace Chapter09_OperatorOverloading.Nybble;

public class NybbleDemo
{
        public static void useNybble()
        {
                Nybble a = new Nybble(1);
                Nybble b = new Nybble(10);
                Nybble c = new Nybble();
                int t;
                
                Console.WriteLine("a: " + (int)a);
                Console.WriteLine("b: " + (int)b);
                
                // Use a Nybble in an if statement.
                if (a < b) Console.WriteLine("a is less than b\n");
                
                // Add two Nybbles together.
                c = a + b;
                Console.WriteLine("c after c = a + b: " + (int)c);
                
                // Add an int to a Nybble.
                a += 5;
                Console.WriteLine("a after a += 5: " + (int)a);
                
                Console.WriteLine();
                
                // Use a Nybble in an int expression.
                t = a * 2 + 3;
                Console.WriteLine("Result of a * 2 + 3: " + t);
                
                Console.WriteLine();
                
                // Illustrate int assignment and overflow.
                a = 19;
                Console.WriteLine("Result of a = 19: " + (int)a);
                
                Console.WriteLine();
                
                // Use a Nybble to control a loop.
                Console.WriteLine("Control a for loop with a Nybble.");
                for (a = 0; a < 10; a++)
                        Console.Write((int)a + " ");
                
                Console.WriteLine();
        }
}