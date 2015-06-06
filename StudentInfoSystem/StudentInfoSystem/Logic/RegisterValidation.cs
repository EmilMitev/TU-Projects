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
                errText += "Паролите не съвпадат!\n";
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
            string temp;
            if (s.Length < min || s.Length > max)
            {
                if (min == max)
                {
                   temp = string.Format("{0} трябда да бъде точно {1} символа!", what, min);
                   errText = errText + "\n" + temp;
                }
                else
                {
                    temp = string.Format("{0} трябда да бъде между {1} и {2} символа!", what, min, max);
                    errText = errText + "\n" + temp;
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
                        errText += "Факултетният номер трябва да е само цифри!\n";
                        return true;
                    }
                }
                return false;
            }
            else
            {
                errText += "Факултетният номер трябва да е точно 9 символа!\n";
                return true;
            }
        }

        public bool CheckIsNumber(string str, string obj)
        {
            string temp;
            short number;
            if (Int16.TryParse(str, out number))
            {
                return true;
            }
            else
            {
                temp = string.Format("{0} трябва да бъде число!", obj);
                errText = errText + "\n" + temp;
                return false;
            }
        }

        public bool UsenameOcc(string username)
        {
            if (Data.UserData.IsUserNameOccupied(username))
            {
                errText += "Потребителското име е заето\n";
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FacNumberOcc(string facNumber)
        {
            if (Data.UserData.IsFacNumberNameOccupied(facNumber))
            {
                errText += "Факултетният номер е зает!\n";
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertUserData(Data.User user)
        {
            if (Data.UserData.InsertUserData(user))
            {
                errText = "Успешно добавихте нов потребител!";

                return true;

            }
            else
            {
                errText += "Нещо се обърка!\n";
                return false;
            }
        }
        public bool InsertStudentData(Data.Student student)
        {
            if (Data.StudentData.InsertStudent(student))
            {
                errText = "Успешно добавихте нов потребител!";
                return true;
            }
            else
            {
                errText += "Нещо се обърка!\n";
                return false;
            }
        }
    }
}
