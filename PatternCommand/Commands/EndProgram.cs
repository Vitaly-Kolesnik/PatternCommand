using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand.Commands
{
    class EndProgram : Command
    {
        public override string Execute()
        {
            return "The end!";
        }
    }
}
