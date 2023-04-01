using PatternCommand.Validator;

namespace PatternCommand.Commands
{
    class RndCommand : Command
    {
        public RndCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
            validator = new RndValidator(parametrs);
        }
        public override string Execute()
        {
            var list = repository.List();

            Random rnd = new Random();

            Student rndStudent = list[rnd.Next(list.Length)];

            return $"{rndStudent}";
        }
    }
}
