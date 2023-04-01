using PatternCommand;

public class Program
{
    private static void Main(string[] args)
    {
        var repository = new Repository();
        string result;
        do
        {
            var input = Console.ReadLine();
            var parser = new CommandsParser(repository);
            var commandUser = parser.Parse(input);
            result = commandUser.ExecuteWithValidation();
            Console.WriteLine(result);
        }
        while (result != "The end!");
    }
}