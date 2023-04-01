using PatternCommand.Validator;
using System.Text;

namespace PatternCommand.Commands
{
    class FindCommand : Command
    {
        public FindCommand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
            validator = new FindValidator(parametrs);
        }
        public override string Execute()
        {
            Student[] findlist = repository.Find(parametrs[0]);

            StringBuilder result = new StringBuilder();

            foreach (Student s in findlist)
            {
                result.AppendLine($"{s}");
            }
            return result.ToString();
        }
    }
}
