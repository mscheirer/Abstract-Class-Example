using Abstract_Class;
using System;

public class main_method                                // Driver Class 
{

    public static void Main(string[] args)              // Main Method 
    {   
        ValidationRuleBase g;                           // 'g' is object of class 'ValidationRuleBase' class ' ValidationRuleBase' cannot be instantiate 

        g = new ValidationStringNotNullOrEmpty();       // instantiate class 'ValidationStringNotNullOrEmpty' 

        g.ValidationRule();                             // call 'ValidationRule()' of class 'Validation1' 

        g = new ValidationStringIsANumber();            // instantiate class 'ValidationStringIsANumber'    

        g.ValidationRule();                             // call 'ValidationRule()' of class 'Validation2' 

    }
}


//public class Person
//{
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public string Cnp { get; set; }
//    public int Age { get; set; }

//}
