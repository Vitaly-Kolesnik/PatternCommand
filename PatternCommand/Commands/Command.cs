using PatternCommand.Validator;

namespace PatternCommand.Commands
{
    public abstract class Command
    {
        protected string[] parametrs;
        protected Repository repository;
        protected IValidator validator;

        public Command()
        {

        }

        public Command(Repository repository, string[] parametrs)
        {
            this.parametrs = parametrs;
            this.repository = repository;
        }

        public string ExecuteWithValidation()

        {
            if (validator != null)
            {
                if (validator.Validate())
                {
                    return Execute();
                }
                return validator.ErrorMessage;
            }
            return Execute();
        }
        public abstract string Execute();
    }
}
