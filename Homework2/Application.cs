namespace Homework2
{
    public class Application
    {
        private ApplicationView _applicationView;

        private string _checkEmailCommand;
        private string _checkPhoneNumberCommand;
        private string _checkUsernameCommand;
        private string _exitCommand;

        public Application()
        {
            _applicationView = new ApplicationView();

            _checkEmailCommand = _applicationView.CheckEmailCommand;
            _checkPhoneNumberCommand = _applicationView.CheckPhoneNumberCommand;
            _checkUsernameCommand = _applicationView.CheckUsernameCommand;
            _exitCommand = _applicationView.ExitCommand;
        }

        public void Run()
        {
            bool isRunning = true;

            while (isRunning)
            {
                _applicationView.ShowMenu();
                string userInput = _applicationView.GetUserInput();

                if (userInput == _checkEmailCommand)
                {
                    string data = _applicationView.GetUserData();
                    bool result = Validator.IsEmail(data);
                    _applicationView.ShowCheckingResult(result);
                }
                else if (userInput == _checkPhoneNumberCommand)
                {
                    string data = _applicationView.GetUserData();
                    bool result = Validator.IsPhoneNumber(data);
                    _applicationView.ShowCheckingResult(result);
                }
                else if (userInput == _checkUsernameCommand)
                {
                    string data = _applicationView.GetUserData();
                    bool result = Validator.IsUsernameValid(data);
                    _applicationView.ShowCheckingResult(result);
                }
                else if (userInput == _exitCommand)
                {
                    isRunning = false;
                }
                else
                {
                    _applicationView.ShowInvalidCommandMessage();
                }
            }
        }
    }
}
