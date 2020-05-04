using System;
// abstract class 'ValidationRuleBase' 
public abstract class ValidationRuleBase
{
    // abstract method 'ValidationRule()' 
    public abstract void ValidationRule();
}

// class 'ValidationRuleBase' inherit 
// in child class 'Validation1' 
public class Validation1 : ValidationRuleBase
{
    // abstract method 'ValidationRule()'  
    // declare here with  
    // 'override' keyword 
    public override void ValidationRule()
    {
        Console.WriteLine("class Validation1");
    }
}

// class 'ValidationRuleBase' inherit in  
// another child class 'Validation2' 
public class Validation2 : ValidationRuleBase
{
    // same as the previous class 
    public override void ValidationRule()
    {
        Console.WriteLine("class Validation2");
    }
}


