using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand.Validator
{
    public interface IValidator
    {
        bool Validate();
        string ErrorMessage { get; }
    }
}
