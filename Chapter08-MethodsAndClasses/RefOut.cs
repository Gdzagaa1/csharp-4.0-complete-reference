namespace Chapter08_MethodsAndClasses;

/*
 * Examples/Exercises of ref and out parameters.
 */
public class RefOut
{
    
    /*
     * An argument passed by ref must
     * be assigned a value prior to the call
     */
        
        // Swap two values.
        private void Swap(ref int a, ref int b) {
            int t;
            t = a;
            a = b;
            b = t;
        }

        public void SwapDemo() {
            int x = 10, y = 20;
            Console.WriteLine("x and y before call: " + x + " " + y);
            Swap(ref x, ref y);
            Console.WriteLine("x and y after call: " + x + " " + y);
        }
        

        // Use ref to pass a value type by reference
        private void Sqr(ref int i) {
            i = i * i;
        }
        
        public void RefDemo() {
            int a = 10;
            Console.WriteLine("a before call: " + a);
            Sqr(ref a);
            Console.WriteLine("a after call: " + a);
        }
        
        
            // Use out.
            
            // Decompose a floating-point value into its
            // integer and fractional parts.
            private int GetParts(double n, out double frac) {
                int whole;
                whole = (int) n;
                frac = n - whole; // pass fractional part back through frac
                return whole; // return integer portion
            }
        
        
            public void UseOut() {
                int i;
                double f;
                i = GetParts(10.125, out f);
                Console.WriteLine("Integer portion is " + i);
                Console.WriteLine("Fractional part is " + f);
            }
            
        
    /*
     * Inside the method, an out parameter is considered unassigned;
     * that is, it is assumed to have no initial value. This implies that the method must assign the
     * parameter a value prior to the method’s termination. Thus, after the call to the method, an
     * out parameter will contain a value.
     */


        // Use two out parameters.
        
        /* Determine if x and v have a common divisor.
        If so, return least and greatest common factors in
        the out parameters. */
        private bool HasComFactor(int x, int y,
            out int least, out int greatest) {
            int i;
            int max = x < y ? x : y;
            bool first = true;
            least = 1;
            greatest = 1;

            for(i = 2; i <= max/2 + 1; i++) {
                if( ((y % i) == 0) & ((x % i) == 0) ) {
                    if(first) {
                        least = i;
                        first = false;
                    }
                    greatest = i;
                }
            }
            if(least != 1) return true;
            else return false;
        }
    

        public void DemoOut() {
            int lcf, gcf;
            if(HasComFactor(231, 105, out lcf, out gcf)) {
                Console.WriteLine("Lcf of 231 and 105 is " + lcf);
                Console.WriteLine("Gcf of 231 and 105 is " + gcf);
            }
            else
                Console.WriteLine("No common factor for 35 and 49.");
            if(HasComFactor(35, 51, out lcf, out gcf)) {
                Console.WriteLine("Lcf of 35 and 51 " + lcf);
                Console.WriteLine("Gcf of 35 and 51 is " + gcf);
            }
            else
                Console.WriteLine("No common factor for 35 and 51.");
        }
        
}