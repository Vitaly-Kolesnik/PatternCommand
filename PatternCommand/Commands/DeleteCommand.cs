using PatternCommand.Validator;

namespace PatternCommand.Commands
{
    class DeleteCommand : Command
    {
        public DeleteCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs) => validator = new DeleteValidator(parametrs);

        public override string Execute() => repository.Delete(int.Parse(parametrs[0])) == 1 ? "Удалено" : "Ошибка";
    }
}
