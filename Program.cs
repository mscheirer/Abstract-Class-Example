
using Abstract_Class;

public class main_method                    // Driver Class 
{
    public static void Main()               // Main Method 
    {   
        ValidationRuleBase g;               // 'g' is object of class 'ValidationRuleBase' class ' ValidationRuleBase' cannot be instantiate 

        g = new Validation1();              // instantiate class 'Validation1' 

        g.ValidationRule();                 // call 'ValidationRule()' of class 'Validation1' 

        g = new Validation2();              // instantiate class 'Validation2'    
     
        g.ValidationRule();                 // call 'ValidationRule()' of class 'Validation2' 

    }
}

