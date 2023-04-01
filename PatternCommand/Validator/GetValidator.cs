using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand.Validator
{
    public class GetValidator : BaseValidator
    {
        protected override int Count => 1;

        public GetValidator(string[] parameters) : base(parameters)
        {
        }
        public override bool Validate() => ValidateParamsCount() && ValidateId(parameters[0]);
    }
}
