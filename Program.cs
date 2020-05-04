
// C# program to show the  
// working of abstract class 
using System;

// Driver Class 
public class main_method
{
    // Main Method 
    public static void Main()
    {
        // 'g' is object of class 
        // 'ValidationRuleBase' class ' 
        // ValidationRuleBase' cannot 
        // be instantiate 
        ValidationRuleBase g;

        // instantiate class 'Validation1' 
        g = new Validation1();

        // call 'ValidationRule()' of class 'Validation1' 
        g.ValidationRule();

        // instantiate class 'Validation2'   
        g = new Validation2();

        // call 'ValidationRule()' of class 'Validation2' 
        g.ValidationRule();

    }
}

