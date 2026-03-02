using System.Text.RegularExpressions;

namespace Homework2
{
    public class Validator
    {
        public static bool IsEmail(string data)
        {
            string emailPattern = @"[\w]+@[\w]+\.[\w]+";
            bool isEmail = Regex.IsMatch(data, emailPattern);

            return isEmail;
        }

        public static bool IsPhoneNumber(string data)
        {
            string emailPattern = @"^(\+7|8)[0-9]{10}$";
            bool isNumber = Regex.IsMatch(data, emailPattern);

            return isNumber;
        }

        public static bool IsUsernameValid(string username)
        {
            string usernamePattern = @"^[a-zA-Z0-9]{3,20}$";
            bool isUsernameValid = Regex.IsMatch(username, usernamePattern);

            return isUsernameValid;
        }
    }
}
