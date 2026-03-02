namespace Homework2
{
    public class ApplicationView
    {
        public string CheckEmailOrPasswordCommand { get; } = "1";
        public string CheckUsernameCommand { get; } = "1";
        public string ExitCommand { get; } = "3";

        private Dictionary<string, string> _commands;

        public ApplicationView()
        {
            _commands = new Dictionary<string, string>()
            {
                { CheckEmailOrPasswordCommand, "Проверить логин или пароль" },
                { CheckUsernameCommand, "Проверить правильность имени пользователя" },
                { ExitCommand, "Выйти" }
            };
        }

        public void ShowMenu()
        {
            foreach (KeyValuePair<string, string> command in _commands)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{command.Value} - {command.Key}");
                Console.ResetColor();
            }
        }

        public void ShowInvalidCommandMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Неверная команда!");
            Console.ResetColor();
        }

        public string GetUserInput()
        {
            return Console.ReadLine();
        }

        public string GetUserData()
        {
            return Console.ReadLine();
        }
    }
}
