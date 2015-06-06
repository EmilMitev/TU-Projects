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
            
            if (!(rv.CheckIsNumber(textBoxGroup.Text, "Групата")))
            {
                MessageBox.Show(rv.errText);
            }
            else if (!(rv.CheckIsNumber(comboBoxOKS.Text, "ОКС")))
            {
                MessageBox.Show(rv.errText);
            }
            else if (!(rv.CheckIsNumber(textBoxPotok.Text, "Потокът")))
            {
                MessageBox.Show(rv.errText);
            }
            else if (!(rv.CheckIsNumber(comboBoxStatus.Text, "Статус")))
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
            GetStudentData();
            if (rv.isEmpty(user.Username))
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
            else if (rv.isStringLessThanOrMoreOf(user.Username, 4, 16, "Username"))
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
            #region CheckNullOrEmpty
            if (rv.isEmpty(user.Username))
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
            else if (rv.isEmpty(st.FirstName))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isEmpty(st.SecondName))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isEmpty(st.LastName))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isEmpty(st.Faculty))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isEmpty(st.Specialty))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isEmpty(st.FakNumber))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isEmpty(st.Potok))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isEmpty(st._Group_.ToString()))
            {
                MessageBox.Show(rv.errText);
            }
            #endregion

            else if (rv.isStringLessThanOrMoreOf(user.Username, 4, 16, "Username"))
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
            else if (rv.isStringLessThanOrMoreOf(st.FirstName, 4, 16, "Името"))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isStringLessThanOrMoreOf(st.SecondName, 4, 16, "Презимето"))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isStringLessThanOrMoreOf(st.LastName, 4, 16, "Фамилията"))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isStringLessThanOrMoreOf(st.Faculty, 3, 10, "Факултетът"))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.isStringLessThanOrMoreOf(st.Specialty, 3, 10, "Специалността"))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.checkFacNumber(st.FakNumber))
            {
                MessageBox.Show(rv.errText);
            }
            
            else if (rv.UsenameOcc(user.Username))
            {
                MessageBox.Show(rv.errText);
            }
            else if (rv.FacNumberOcc(user.FacNumber))
            {
                MessageBox.Show(rv.errText);
            }
            else
            {
                if (rv.InsertUserData(user))
                {
                    if (rv.InsertStudentData(st))
                    {
                        MessageBox.Show(rv.errText);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(rv.errText);
                    }
                }
                else
                {
                    MessageBox.Show(rv.errText);
                }
            }
        }
    }
}