using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand.Validator
{
    public class ListValidator : BaseValidator
    {
        protected override int Count => 0;

        public ListValidator(string[] parameters) : base(parameters)
        {
        }
        public override bool Validate() => ValidateParamsCount();
    }
}
