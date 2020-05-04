using System;

namespace Abstract_Class
{
    public class Validation2 : ValidationRuleBase               // class 'ValidationRuleBase' inherit in another child class 'Validation2' 
    {
        public override void ValidationRule()                   // same as the previous class 
        {
            Console.WriteLine("class Validation2");
        }
    }
}
