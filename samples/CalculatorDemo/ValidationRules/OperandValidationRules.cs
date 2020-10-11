using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CalculatorDemo.ValidationRules
{
    class OperandValidationRules : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string operand = value as string;
            if(string.IsNullOrEmpty(operand))
                return new ValidationResult(false, "Operand can not be empty");
            else
                return new ValidationResult(true,"");
        }
    }
}
