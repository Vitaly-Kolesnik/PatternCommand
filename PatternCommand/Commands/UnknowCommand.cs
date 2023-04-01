using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand.Commands
{
    class UnknowCommand : Command
    {
        public UnknowCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
        }
        public override string Execute()
        {
            return "Ничего не вышло";
        }
    }
}
