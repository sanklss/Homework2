namespace Homework2
{
    public class ApplicationView
    {
        public string CheckEmailCommand { get; } = "1";
        public string CheckPhoneNumberCommand { get; } = "2";
        public string CheckUsernameCommand { get; } = "3";
        public string ExitCommand { get; } = "4";

        private Dictionary<string, string> _commands;

        public ApplicationView()
        {
            _commands = new Dictionary<string, string>()
            {
                { CheckEmailCommand, "Проверить Email" },
                { CheckPhoneNumberCommand, "Проверить номер телефона" },
                { CheckUsernameCommand, "Проверить правильность имени пользователя" },
                { ExitCommand, "Выйти" }
            };
        }

        public void ShowMenu()
        {
            foreach (KeyValuePair<string, string> command in _commands)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
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

        public void ShowCheckingResult(bool result)
        {
            if (result == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Проверка пройдена успешно!");
                Console.ResetColor();
            }
            else if (result == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Проверка не пройдена!");
                Console.ResetColor();
            }
        }
    }
}
