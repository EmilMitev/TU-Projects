using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInfoSystem.Logic;

namespace StudentInfoSystem.View
{
    public partial class Registration : Form
    {
        private Data.User user;
        private Data.Student st;

        public Registration()
        {
            InitializeComponent();
            HideComponents();
            ClientSize = new System.Drawing.Size(160, 86);
            user = new Data.User();
            st = new Data.Student();
        }

        private void HideComponents()
        {
            groupBoxStudenInfo.Visible = false;
            groupBoxStudentPersonalData.Visible = false;
            groupBoxUser.Visible = false;
        }

        private void VisibleComponents()
        {
            groupBoxStudenInfo.Visible = true;
            groupBoxStudentPersonalData.Visible = true;
            groupBoxUser.Visible = true;
        }

        private void GetUserData()
        {
            user.Username = textBoxUsername.Text;
            user.Password = textBoxPassword.Text;
            user.FacNumber = textBoxFakNumber.Text;

            if (comboBoxChoice.Text == "Студент")
            {
                user.Role = 1;
            }
            else if (comboBoxChoice.Text == "Преподавател")
            {
                user.Role = 2;
            }
        }

        private void GetStudentData()
        {
            RegisterValidation rv = new RegisterValidation();
            st.FirstName = textBoxStudentFirstName.Text;
            st.SecondName = textBoxStudentSecondName.Text;
            st.LastName = textBoxStudentThirdName.Text;
            st.Faculty = textBoxFaculty.Text;
            st.Specialty = textBoxSpecialty.Text;
            st.FakNumber = textBoxFakNumber.Text;

            if (!(rv.CheckIsNumber(textBoxGroup.Text, "Групата")) &&
                !(rv.CheckIsNumber(comboBoxOKS.Text, "ОКС")) &&
                !(rv.CheckIsNumber(textBoxPotok.Text, "Потокът")) &&
                !(rv.CheckIsNumber(comboBoxStatus.Text, "Статус")))
            {
                MessageBox.Show(rv.errText);
            }
            else
            {
                st.Potok = textBoxPotok.Text;
                if (textBoxGroup.Text != string.Empty)
                {
                    st._Group_ = int.Parse(textBoxGroup.Text);
                }
                if (textBoxGroup.Text != string.Empty)
                {
                    st.OKS = (short)comboBoxOKS.SelectedIndex;
                }
                if (comboBoxStatus.Text != string.Empty)
                {
                    st.StudentStatus = (short)comboBoxStatus.SelectedIndex;
                }
                if (numericUpDownCourse.Text != string.Empty)
                {
                    st.Course = (short)numericUpDownCourse.Value;
                }
            }
        }

        private void comboBoxChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChoice.Text == "Студент")
            {
                ClientSize = new System.Drawing.Size(562, 359);
                VisibleComponents();
                comboBoxChoice.Enabled = false;
                buttonSave.Visible = false;
            }
            else if (comboBoxChoice.Text == "Преподавател")
            {
                ClientSize = new System.Drawing.Size(166, 342);
                comboBoxChoice.Enabled = false;
                groupBoxUser.Visible = true;
                buttonSaveData.Visible = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            RegisterValidation rv = new RegisterValidation();
            GetUserData();
            if (!(rv.isEmpty(user.Username) &&
                rv.isEmpty(this.textBoxPassword.Text) &&
                rv.isEmpty(this.textBoxPassRepeat.Text) &&
                rv.isStringLessThanOrMoreOf(user.Username, 4, 16, "Username") &&
                rv.isStringLessThanOrMoreOf(this.textBoxPassword.Text, 6, 16, "Password") &&
                rv.isStringLessThanOrMoreOf(this.textBoxPassRepeat.Text, 6, 16, "Password repeat") &&
                !(rv.IsPassMatch(this.textBoxPassRepeat.Text, this.textBoxPassword.Text))))
            {
                MessageBox.Show(rv.errText);
            }
            else
            {
                if (rv.InsertUserData(user))
                {
                    MessageBox.Show(rv.errText);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(rv.errText);
                }
            }
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            RegisterValidation rv = new RegisterValidation();
            GetUserData();
            GetStudentData();

            if (!(rv.isEmpty(user.Username) &&
                rv.isEmpty(this.textBoxPassword.Text) &&
                rv.isEmpty(this.textBoxPassRepeat.Text) &&
                rv.isEmpty(st.FirstName) &&
                rv.isEmpty(st.SecondName) &&
                rv.isEmpty(st.LastName) &&
                rv.isEmpty(st.Faculty) &&
                rv.isEmpty(st.Specialty) &&
                rv.isEmpty(st.FakNumber) &&
                rv.isEmpty(st.Potok) &&
                rv.isEmpty(st._Group_.ToString()) &&
                rv.isStringLessThanOrMoreOf(user.Username, 4, 16, "Username") &&
                rv.isStringLessThanOrMoreOf(this.textBoxPassword.Text, 6, 16, "Password") &&
                rv.isStringLessThanOrMoreOf(this.textBoxPassRepeat.Text, 6, 16, "Password repeat") &&
                !(rv.IsPassMatch(this.textBoxPassRepeat.Text, this.textBoxPassword.Text)) &&
                rv.isStringLessThanOrMoreOf(st.FirstName, 4, 16, "Името") &&
                rv.isStringLessThanOrMoreOf(st.SecondName, 4, 16, "Презимето") &&
                rv.isStringLessThanOrMoreOf(st.LastName, 4, 16, "Фамилията") &&
                rv.isStringLessThanOrMoreOf(st.Faculty, 3, 10, "Факултетът") &&
                rv.isStringLessThanOrMoreOf(st.Specialty, 3, 10, "Специалността") &&
                rv.checkFacNumber(st.FakNumber) &&
                rv.UsenameOcc(user.Username) &&
                rv.FacNumberOcc(user.FacNumber)))
            {
                MessageBox.Show(rv.errText);
            }
            else
            {
                if (rv.InsertUserData(user) && rv.InsertStudentData(st))
                {
                    MessageBox.Show(rv.errText);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(rv.errText);
                }
            }
        }
    }
}