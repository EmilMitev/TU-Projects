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
    public partial class MainForm : Form
    {
        public UserStatus userStatus { get; private set; }
        public Data.Student student;

        public MainForm()
        {
            InitializeComponent();
            userStatus = UserStatus.ANONYMOUS;
            DisableAllControls();
            student = new Data.Student();
        }

        private void ClearInfo()
        {
            textBoxStudentFirstName.Text = string.Empty;
            textBoxStudentSecondName.Text = string.Empty;
            textBoxStudentThirdName.Text = string.Empty;
            textBoxFaculty.Text = string.Empty;
            textBoxSpecialty.Text = string.Empty;
            comboBoxOKS.Text = "Избери...";
            comboBoxStatus.Text = "Избери...";
            textBoxFakNumber.Text = string.Empty;
            numericUpDownCourse.Value = 1;
            textBoxPotok.Text = string.Empty;
            textBoxGroup.Text = string.Empty;
        }

        void ShowStudentInfo(Data.User user)
        {
            student = StudentValidation.IsThereStudent(user);
            if (student != null)
            {
                textBoxStudentFirstName.Text = student.FirstName;
                textBoxStudentSecondName.Text = student.SecondName;
                textBoxStudentThirdName.Text = student.LastName;
                textBoxFaculty.Text = student.Faculty;
                textBoxSpecialty.Text = student.Specialty;
                textBoxFakNumber.Text = student.FakNumber;
                textBoxPotok.Text = student.Potok;
                textBoxGroup.Text = student._Group_.ToString();
                comboBoxOKS.SelectedIndex = student.OKS;
                comboBoxStatus.SelectedIndex = student.StudentStatus;
                numericUpDownCourse.Value = student.Course;
            }

        }

        void DisableAllControls()
        {
            groupBoxStudentPersonalData.Enabled = false;
            groupBoxStudenInfo.Enabled = false;
            groupBoxStudentPhoto.Enabled = false;
            openPictureToolStripMenuItem.Visible = false;
            miUverenie.Visible = false;
            btnAddStudent.Visible = false;
            infoForGroupToolStripMenuItem.Visible = false;
        }

        void EnableAllControls()
        {
            groupBoxStudentPersonalData.Enabled = true;
            groupBoxStudenInfo.Enabled = true;
            groupBoxStudentPhoto.Enabled = true;
            openPictureToolStripMenuItem.Visible = true;
            miUverenie.Visible = true;
        }

        void Login(Data.User user)
        {
            EnableAllControls();
            ShowStudentInfo(user);
            loginLogoutToolStripMenuItem.Text = "Logout";
            if (user.Role == 1)
            {
                userStatus = UserStatus.STUDENT;
            }
            else if (user.Role == 3)
            {
                userStatus = UserStatus.ADMIN;
                btnAddStudent.Visible = true;
                infoForGroupToolStripMenuItem.Visible = true;
            }
        }

        void Logout()
        {
            ClearInfo();
            DisableAllControls();
            loginLogoutToolStripMenuItem.Text = "Login";
            userStatus = UserStatus.ANONYMOUS;
        }

        private void loginLogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginLogoutToolStripMenuItem.Text == "Login")
            {
                LoginForm loginForm = new LoginForm();
                registrationToolStripMenuItem.Visible = false;
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    switch (userStatus)
                    {
                        case UserStatus.ANONYMOUS: Login(loginForm.user);
                            break;
                        case UserStatus.STUDENT: Logout();
                            break;
                        case UserStatus.ADMIN: Logout();
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                Logout();
                registrationToolStripMenuItem.Visible = true;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void openPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadStudentPicture();
        }

        private void LoadStudentPicture()
        {
            if
            (openPictureDialog.ShowDialog() == DialogResult.OK)
            {
                pbStudentPhoto.ImageLocation = openPictureDialog.FileName;
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = GenerateInfoText();
            InfoForm infoForm = new InfoForm(text);
            infoForm.Show();
        }

        private string GenerateInfoText()
        {
            string text = "Уверение\n";
            text += textBoxStudentFirstName.Text + " " + textBoxStudentSecondName.Text + " " + textBoxStudentThirdName.Text;
            text += " е студент/ка във Факултет " + textBoxFaculty + ", специалност " + textBoxSpecialty.Text;
            text += "\n";
            return text;
        }

        private Data.Student ReadStudentInfo()
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

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (StudentValidation.InsertStudentIfValid(ReadStudentInfo()))
            {
                MessageBox.Show("Студентът е добавен успешно!");
            }
            else
            {
                MessageBox.Show("Има грешка при добавянето!");
            }
        }

        private void infoForGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupsForm groupForm = new GroupsForm();
            groupForm.ShowDialog();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrationToolStripMenuItem.Visible = true;
            Registration reg = new Registration();
            reg.ShowDialog();
        }

    }
}
//|DataDirectory|\StudentInfoDatabase.mdf