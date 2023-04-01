using PatternCommand.Validator;

namespace PatternCommand.Commands
{
    class ShowListCommand : Command
    {
        public ShowListCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
            validator = new ListValidator(parametrs);
        }
        public override string Execute()
        {
            var list = repository.List();
            string listStudent = string.Empty;

            foreach (Student s in list)
            {
                listStudent += $"{s}\n";
            }

            return $"{listStudent.TrimEnd()}";
        }
    }
}
