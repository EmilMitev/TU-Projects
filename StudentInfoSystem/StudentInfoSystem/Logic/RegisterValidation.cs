using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem.Logic
{
    class RegisterValidation
    {
        public string errText { get; private set; }

        public bool IsPassMatch(string pass, string repeatPass)
        {
            if (pass == repeatPass)
            {
                return true;
            }
            else
            {
                errText = "Паролите не съвпадат!";
                return false;
            }
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

        public bool ValidateUserInput(string username, string password)
        {
            if (isEmpty(username))
            {
                errText = "Името не може да е empty или null!";
                return false;
            }
            else if (isStringLessThan(username, 4))
            {
                errText = "Името не може да е по-малко от 4 символа!";
                return false;
            }
            else if (isEmpty(password))
            {
                errText = "Паролата не може да е null или empty!";
                return false;
            }

            else if (isStringLessThan(password, 6))
            {
                errText = "Паролата не може да е по-малко от 6 символа!";
                return false;
            }
            return true;
        }

        public bool ValidateStudentInput(string name, string facNumber)
        {
            if (isEmpty(name))
            {
                errText = "Името не може да е empty или null!";
                return false;
            }
            else if (isStringLessThan(name, 4))
            {
                errText = "Името не може да е по-малко от 4 символа!";
                return false;
            }
            else if (isEmpty(facNumber))
            {
                errText = "Факултетният номер не може да е null или empty!";
                return false;
            }

            else if (isStringLessThan(facNumber, 9))
            {
                errText = "Факултетният номер не може да е по-малко от 9 символа!";
                return false;
            }
            return true;
        }
    }
}
