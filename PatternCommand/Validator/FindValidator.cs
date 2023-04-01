using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand.Validator
{
    public class FindValidator : BaseValidator
    {
        protected override int Count => 1;

        public FindValidator(string[] parameters) : base(parameters)
        {
        }
        public override bool Validate()
        {
            return ValidateParamsCount() && ValidateString(parameters[0]);
        }
    }
}
