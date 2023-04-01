using PatternCommand.Validator;

namespace PatternCommand.Commands
{
    class GetCommand : Command
    {
        public GetCommand(Repository repository, string[] parameters)
            : base(repository, parameters) => validator = new DeleteValidator(parameters);

        public override string Execute() => repository.Get(int.Parse(parametrs[0])) != null ? $"{repository.Get(int.Parse(parametrs[0]))}" : "Такой id отсутствует";
    }
}
