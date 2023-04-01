using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand.Validator
{
    public class RndValidator : BaseValidator
    {
        protected override int Count => 0;

        public RndValidator(string[] parameters) : base(parameters)
        {
        }
        public override bool Validate() => ValidateParamsCount();
    }
}
