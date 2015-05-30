using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.Logic
{
    class LoginValidation
    {
        private string _username;
        private string _password;

        public string errText { get; private set; }

        public LoginValidation(string username, string pass)
        {
            _username = username;
            _password = pass;
            errText = string.Empty;
        }

        private bool isEmpty(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }
            return false;
        }

        private bool isStringLessThan(string s, int n)
        {

            if (s.Length < n)
            {
                return true;
            }

            return false;
        }

        public bool ValidateUserInput(out User user)
        {
            user = null;
            if (isEmpty(_username))
            {
                errText = "Името не може да е empty или null!";
                return false;
            }
            else if (isStringLessThan(_username, 4))
            {
                errText = "Името не може да е по-малко от 4 символа!";
                return false;
            }
            else if (isEmpty(_password))
            {
                errText = "Паролата не може да е null или empty!";
                return false;
            }

            else if (isStringLessThan(_password, 6))
            {
                errText = "Паролата не може да е по-малко от 6 символа!";
                return false;
            }

            User queryResult = UserData.IsUserPassCorrect(_username, _password);
            // returns the user role
            if (queryResult == null)
            {
                errText += "Въвели сте грешно потребителско име или парола!";
                return false;
            }
            user = queryResult;
            return true;
        }
    }
}
