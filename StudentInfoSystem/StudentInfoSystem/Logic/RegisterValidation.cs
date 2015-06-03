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

        public bool isEmpty(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                errText = "Полетата не може да са empty или null!";
                return true;
            }
            return false;
        }

        public bool isStringLessThanOrMoreOf(string s, int min, int max, string what)
        {
            if (s.Length<min || s.Length>max)
            {
                if (min == max)
                {
                    errText = string.Format("{0} трябда да бъде точно {1} символа!", what, min);
                }
                else
                {
                    errText = string.Format("{0} трябда да бъде между {1} и {2} символа!", what, min, max);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkFacNumber(string facNumber)
        {
            if (facNumber.Length == 9)
            {
                for (int i = 0; i < facNumber.Length; i++)
                {
                    if (!(char.IsDigit(facNumber[i])))
                    {
                        errText = "Факултетният номер трябва да е само цифри!";
                        return true;
                    }
                }
                return false;
            }
            else
            {
                errText = "Факултетният номер трябва да е точно 9 символа!";
                return true;
            }
        }
    }
}
