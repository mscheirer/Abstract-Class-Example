using System;

namespace Abstract_Class
{
    public class ValidationStringIsANumber : ValidationRuleBase         // class 'ValidationRuleBase' inherit in another child class 'ValidationStringIsANumber' 
    {
        public ValidationStringIsANumber()
        {
        }

        public ValidationStringIsANumber(string value)                  // same as the previous class 
        {
            Value = value;
        }

        public string Value { get; }

        public override bool ValidationRule()
        {
            return (string.IsNullOrWhiteSpace(Value)) && int.TryParse(Value, out int number);
        }
    }
}
