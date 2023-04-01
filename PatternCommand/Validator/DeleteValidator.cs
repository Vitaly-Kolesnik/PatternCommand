using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand.Validator
{
    public class DeleteValidator : BaseValidator
    {
        protected override int Count => 1;

        public DeleteValidator(string[] parameters) : base(parameters)
        {
        }
        public override bool Validate()
        {
            return ValidateParamsCount() && ValidateId(parameters[0]);
        }
    }
}
