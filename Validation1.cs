using System;

namespace Abstract_Class
{
    public class Validation1 : ValidationRuleBase               // class 'ValidationRuleBase' inherit in child class 'Validation1' 
    {
        public override void ValidationRule()                   // abstract method 'ValidationRule()' declare here with 'override' keyword 
        {
            Console.WriteLine("class Validation1");
        }
    }
}
