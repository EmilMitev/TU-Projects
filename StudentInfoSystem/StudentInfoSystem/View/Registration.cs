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
        public Registration()
        {
            InitializeComponent();
            HideComponents();
            ClientSize = new System.Drawing.Size(160, 86);
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

        private Data.User GetUserData()
        {
            Data.User user = new Data.User();
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
            else
            {
                user.Role = 3;
            }

            return user;
        }

        private Data.Student GetStudentData()
        {
            Data.Student st = new Data.Student();
            st.FirstName = textBoxStudentFirstName.Text;
            st.SecondName = textBoxStudentSecondName.Text;
            st.LastName = textBoxStudentThirdName.Text;
            st.Faculty = textBoxFaculty.Text;
            st.Specialty = textBoxSpecialty.Text;
            st.FakNumber = textBoxFakNumber.Text;
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

            return st;
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
            else if (comboBoxChoice.Text == "Администратор")
            {
                ClientSize = new System.Drawing.Size(166, 342);
                comboBoxChoice.Enabled = false;
                groupBoxUser.Visible = true;
                buttonSaveData.Visible = false;
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
            if (rv.isEmpty(GetUserData().Username))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isEmpty(this.textBoxPassword.Text))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isEmpty(this.textBoxPassRepeat.Text))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isStringLessThanOrMoreOf(GetUserData().Username, 4, 16, "Username"))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isStringLessThanOrMoreOf(this.textBoxPassword.Text, 6, 16, "Password"))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isStringLessThanOrMoreOf(this.textBoxPassRepeat.Text, 6, 16, "Password repeat"))
            {
                MessageBox.Show(rv.errText);
            }
            else if (!(rv.IsPassMatch(this.textBoxPassRepeat.Text, this.textBoxPassword.Text)))
            {
                MessageBox.Show(rv.errText);
            }
            else
            {
                if (Data.UserData.InsertUserData(GetUserData()))
                {
                    MessageBox.Show("Успешно добавихте нов потребител!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Нещо се обърка!");
                }
            }
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            RegisterValidation rv = new RegisterValidation();

            #region CheckNullOrEmpty
            if (rv.isEmpty(GetUserData().Username))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isEmpty(this.textBoxPassword.Text))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isEmpty(this.textBoxPassRepeat.Text))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isEmpty(GetStudentData().FirstName))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isEmpty(GetStudentData().SecondName))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isEmpty(GetStudentData().LastName))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isEmpty(GetStudentData().Faculty))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isEmpty(GetStudentData().Specialty))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isEmpty(GetStudentData().FakNumber))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isEmpty(GetStudentData().Potok))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isEmpty(GetStudentData()._Group_.ToString()))
            {
                MessageBox.Show(rv.errText);
            }
            #endregion

            else if (rv.isStringLessThanOrMoreOf(GetUserData().Username, 4, 16, "Username"))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isStringLessThanOrMoreOf(this.textBoxPassword.Text, 6, 16, "Password"))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isStringLessThanOrMoreOf(this.textBoxPassRepeat.Text, 6, 16, "Password repeat"))
            {
                MessageBox.Show(rv.errText);
            }
            else if (!(rv.IsPassMatch(this.textBoxPassRepeat.Text, this.textBoxPassword.Text)))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isStringLessThanOrMoreOf(GetStudentData().FirstName, 4, 16, "Името"))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isStringLessThanOrMoreOf(GetStudentData().SecondName, 4, 16, "Презимето"))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isStringLessThanOrMoreOf(GetStudentData().LastName, 4, 16, "Фамилията"))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isStringLessThanOrMoreOf(GetStudentData().Faculty, 3, 10, "Факултетът"))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isStringLessThanOrMoreOf(GetStudentData().Specialty, 3, 10, "Специалността"))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.checkFacNumber(GetStudentData().FakNumber))
            {
                MessageBox.Show(rv.errText);
            }
            else if (Data.UserData.IsUserNameOccupied(GetUserData().Username))
            {
                MessageBox.Show("Потребителското име е заето!");
            }
            else if (Data.UserData.IsFacNumberNameOccupied(GetUserData().FacNumber))
            {
                MessageBox.Show("Факултетният номер е зает!");
            }
            else
            {
                if (Data.UserData.InsertUserData(GetUserData()))
                {
                    if (Data.StudentData.InsertStudent(GetStudentData()))
                    {
                        MessageBox.Show("Успешно добавихте нов потребител!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Нещо се обърка!");
                    }
                }
                else
                {
                    MessageBox.Show("Нещо се обърка!");
                }
            }
        }
    }
}