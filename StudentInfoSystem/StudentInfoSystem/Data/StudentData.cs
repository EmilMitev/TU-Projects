using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem.Data
{
    class StudentData
    {
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
    }
}
