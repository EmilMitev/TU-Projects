using StudentInfoSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.Logic
{
    class StudentValidation
    {
        public static Student IsThereStudent(User usr)
        {
            return StudentData.GetStudentDataByUser(usr.FacNumber);
        }

        public static bool InsertStudentIfValid(Student s)
        {
            //bool isTrue = s.FirstName != null && s.SecondName != null && s.LastName != null && s.Faculty != null && s.Specialty != null && s.FakNumber != null && s.Potok != null && s._Group_ != null && s.OKS != null && s.StudentStatus != null && s.Course != null;

            if (StudentData.InsertStudent(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
