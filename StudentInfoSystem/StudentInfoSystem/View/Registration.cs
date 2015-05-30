using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Data.UserData.IsUserNameOccupied(GetUserData().Username))
            {
                MessageBox.Show("Потребителското име е заето!");
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
            if (Data.UserData.IsUserNameOccupied(GetUserData().Username))
            {
                MessageBox.Show("Потребителското име е заето!");
            }
            else
            {
                if (Data.UserData.InsertUserData(GetUserData()))
                {
                    if (Data.UserData.InsertStudent(GetStudentData()))
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