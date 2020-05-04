using System;

namespace Abstract_Class
{
    public class ValidationStringNotNullOrEmpty : ValidationRuleBase       // class 'ValidationRuleBase' inherit in child class 'ValidationStringNotNullOrEmpty' 
    {
        public ValidationStringNotNullOrEmpty()
        {
        }

        public ValidationStringNotNullOrEmpty(string value)               // abstract method 'ValidationRule()' declare here with 'override' keyword 
        {
            Value = value;
        }

        public string Value { get; }

        public override bool ValidationRule()
        {
            return string.IsNullOrEmpty(Value);
        }

    }
}
