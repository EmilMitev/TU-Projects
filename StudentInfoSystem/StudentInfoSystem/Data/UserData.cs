using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem.Data
{
    public class UserData
    {
        public static User IsUserPassCorrect(string username, string password)
        {
            return UserData._IsUserPassCorrect(username, password);
        }

        private static User _IsUserPassCorrect(string username, string password)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            var queryResult = (from users in dc.GetTable<User>()
                               where (users.Username == username) &&
                               (users.Password == password)
                               select users).ToArray<User>();
            if (queryResult.Count<User>() > 0)
            {
                return queryResult.ElementAt<User>(0);
            }
            return null;
        }

        public static bool IsUserNameOccupied(string username)
        {
            return UserData._IsUserNameOccupied(username);
        }

        private static bool _IsUserNameOccupied(string username)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            var queryResult = (from users in dc.GetTable<User>()
                               where (users.Username == username)
                               select users.Username).ToArray<string>();
            if (queryResult.Count<string>() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Student GetStudentDataByUser(string fakNumber)
        {
            StudentDataContext dc = new StudentDataContext();
            var studentInfoResult = (from students in dc.GetTable<Student>()
                                     where (students.FakNumber == fakNumber)
                                     select students).ToArray<Student>();
            if (studentInfoResult.Count<Student>() > 0)
            {
                return studentInfoResult.ElementAt<Student>(0);
            }
            else
            {
                return null;
            }
        }

        public static bool InsertStudent(Student s)
        {
            StudentDataContext dc = new StudentDataContext();

            try
            {
                dc.AddNewStudent(s.FirstName, s.SecondName, s.LastName, s.Faculty,
                                 s.Specialty, s.OKS, s.StudentStatus,
                                 s.FakNumber, s.Course, s.Potok, s._Group_);
                
                dc.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static List<int> ShowAllGroup()
        {
            StudentDataContext dc = new StudentDataContext();
            var querry = (from students in dc.GetTable<Student>()
                          select students._Group_).Distinct().ToList<int>();
            return querry;
        }

        public static bool InsertUserData(User u)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            try
            {
                dc.AddNewUser(u.Username, u.Password, u.FacNumber, u.Role);

                dc.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
