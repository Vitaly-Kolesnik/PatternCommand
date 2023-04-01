using PatternCommand.Commands;

namespace PatternCommand
{
    public class CommandsParser
    {
        private readonly Repository repository;

        public CommandsParser(Repository repository)
        {
            this.repository = repository;
        }

        public Command Parse(string? input)
        {
            var inputArr = input?.Split();
            string[] parametrs = new string[6];
            int index = 0;

            foreach (string item in inputArr)
            {
                if (!string.IsNullOrEmpty(item) && index < parametrs.Length)
                {
                    parametrs[index] = item;
                    index++;
                }
            }
            var command = parametrs[0];
            string[] newparametrs = new string[5];
            Array.Copy(parametrs, 1, newparametrs, 0, newparametrs.Length);
            parametrs = newparametrs;

            return (command.ToUpper(), repository != null) //Patternmathing from .Net 7
            switch
            {
                ("ADD", true) or ("ADD", false) => new AddCommand(repository, parametrs),
                ("DELETE", true) => new DeleteCommand(repository, parametrs),
                ("END", true) => new EndProgram(),
                ("EDIT", true) => new EditCommand(repository, parametrs),
                ("LIST", true) => new ShowListCommand(repository, parametrs),
                ("RANDOM", true) => new RndCommand(repository, parametrs),
                ("FIND", true) => new FindCommand(repository, parametrs),
                ("GET", true) => new GetCommand(repository, parametrs),
                _ => new UnknowCommand(repository, parametrs),
            };
        }
    }
}
