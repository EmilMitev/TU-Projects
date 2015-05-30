namespace StudentInfoSystem.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginLogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miUverenie = new System.Windows.Forms.ToolStripMenuItem();
            this.infoForGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlStudentInfo = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBoxStudenInfo = new System.Windows.Forms.GroupBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelPotok = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.textBoxPotok = new System.Windows.Forms.TextBox();
            this.numericUpDownCourse = new System.Windows.Forms.NumericUpDown();
            this.labelFakNumber = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelOKS = new System.Windows.Forms.Label();
            this.labelSpecialty = new System.Windows.Forms.Label();
            this.labelFaculty = new System.Windows.Forms.Label();
            this.textBoxFakNumber = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxOKS = new System.Windows.Forms.ComboBox();
            this.textBoxSpecialty = new System.Windows.Forms.TextBox();
            this.textBoxFaculty = new System.Windows.Forms.TextBox();
            this.groupBoxStudentPersonalData = new System.Windows.Forms.GroupBox();
            this.textBoxStudentThirdName = new System.Windows.Forms.TextBox();
            this.textBoxStudentSecondName = new System.Windows.Forms.TextBox();
            this.textBoxStudentFirstName = new System.Windows.Forms.TextBox();
            this.labelStudentThirdName = new System.Windows.Forms.Label();
            this.labelStudentSecondName = new System.Windows.Forms.Label();
            this.labelStudentFirstName = new System.Windows.Forms.Label();
            this.groupBoxStudentPhoto = new System.Windows.Forms.GroupBox();
            this.pbStudentPhoto = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControlStudentInfo.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxStudenInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).BeginInit();
            this.groupBoxStudentPersonalData.SuspendLayout();
            this.groupBoxStudentPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginLogoutToolStripMenuItem,
            this.openPictureToolStripMenuItem,
            this.miUverenie,
            this.infoForGroupToolStripMenuItem,
            this.registrationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginLogoutToolStripMenuItem
            // 
            this.loginLogoutToolStripMenuItem.Name = "loginLogoutToolStripMenuItem";
            this.loginLogoutToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginLogoutToolStripMenuItem.Text = "Login";
            this.loginLogoutToolStripMenuItem.Click += new System.EventHandler(this.loginLogoutToolStripMenuItem_Click);
            // 
            // openPictureToolStripMenuItem
            // 
            this.openPictureToolStripMenuItem.Name = "openPictureToolStripMenuItem";
            this.openPictureToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.openPictureToolStripMenuItem.Text = "Open Picture";
            this.openPictureToolStripMenuItem.Click += new System.EventHandler(this.openPictureToolStripMenuItem_Click);
            // 
            // miUverenie
            // 
            this.miUverenie.Name = "miUverenie";
            this.miUverenie.Size = new System.Drawing.Size(40, 20);
            this.miUverenie.Text = "Info";
            this.miUverenie.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // infoForGroupToolStripMenuItem
            // 
            this.infoForGroupToolStripMenuItem.Name = "infoForGroupToolStripMenuItem";
            this.infoForGroupToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.infoForGroupToolStripMenuItem.Text = "Info for groups";
            this.infoForGroupToolStripMenuItem.Click += new System.EventHandler(this.infoForGroupToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.registrationToolStripMenuItem.Text = "Registration";
            this.registrationToolStripMenuItem.Click += new System.EventHandler(this.registrationToolStripMenuItem_Click);
            // 
            // tabControlStudentInfo
            // 
            this.tabControlStudentInfo.Controls.Add(this.tabPage3);
            this.tabControlStudentInfo.Controls.Add(this.tabPage1);
            this.tabControlStudentInfo.Location = new System.Drawing.Point(12, 27);
            this.tabControlStudentInfo.Name = "tabControlStudentInfo";
            this.tabControlStudentInfo.SelectedIndex = 0;
            this.tabControlStudentInfo.Size = new System.Drawing.Size(621, 363);
            this.tabControlStudentInfo.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBoxStudenInfo);
            this.tabPage3.Controls.Add(this.groupBoxStudentPersonalData);
            this.tabPage3.Controls.Add(this.groupBoxStudentPhoto);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(613, 337);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Студент";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBoxStudenInfo
            // 
            this.groupBoxStudenInfo.Controls.Add(this.btnAddStudent);
            this.groupBoxStudenInfo.Controls.Add(this.labelGroup);
            this.groupBoxStudenInfo.Controls.Add(this.labelPotok);
            this.groupBoxStudenInfo.Controls.Add(this.labelCourse);
            this.groupBoxStudenInfo.Controls.Add(this.textBoxGroup);
            this.groupBoxStudenInfo.Controls.Add(this.textBoxPotok);
            this.groupBoxStudenInfo.Controls.Add(this.numericUpDownCourse);
            this.groupBoxStudenInfo.Controls.Add(this.labelFakNumber);
            this.groupBoxStudenInfo.Controls.Add(this.labelStatus);
            this.groupBoxStudenInfo.Controls.Add(this.labelOKS);
            this.groupBoxStudenInfo.Controls.Add(this.labelSpecialty);
            this.groupBoxStudenInfo.Controls.Add(this.labelFaculty);
            this.groupBoxStudenInfo.Controls.Add(this.textBoxFakNumber);
            this.groupBoxStudenInfo.Controls.Add(this.comboBoxStatus);
            this.groupBoxStudenInfo.Controls.Add(this.comboBoxOKS);
            this.groupBoxStudenInfo.Controls.Add(this.textBoxSpecialty);
            this.groupBoxStudenInfo.Controls.Add(this.textBoxFaculty);
            this.groupBoxStudenInfo.Location = new System.Drawing.Point(215, 139);
            this.groupBoxStudenInfo.Name = "groupBoxStudenInfo";
            this.groupBoxStudenInfo.Size = new System.Drawing.Size(390, 190);
            this.groupBoxStudenInfo.TabIndex = 2;
            this.groupBoxStudenInfo.TabStop = false;
            this.groupBoxStudenInfo.Text = "Студентска информация";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(275, 167);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(109, 23);
            this.btnAddStudent.TabIndex = 16;
            this.btnAddStudent.Text = "Добави студент";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(255, 91);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(39, 13);
            this.labelGroup.TabIndex = 15;
            this.labelGroup.Text = "Група:";
            // 
            // labelPotok
            // 
            this.labelPotok.AutoSize = true;
            this.labelPotok.Location = new System.Drawing.Point(253, 65);
            this.labelPotok.Name = "labelPotok";
            this.labelPotok.Size = new System.Drawing.Size(41, 13);
            this.labelPotok.TabIndex = 14;
            this.labelPotok.Text = "Поток:";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(260, 38);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(34, 13);
            this.labelCourse.TabIndex = 13;
            this.labelCourse.Text = "Курс:";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(300, 88);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(72, 20);
            this.textBoxGroup.TabIndex = 12;
            // 
            // textBoxPotok
            // 
            this.textBoxPotok.Location = new System.Drawing.Point(300, 62);
            this.textBoxPotok.Name = "textBoxPotok";
            this.textBoxPotok.Size = new System.Drawing.Size(72, 20);
            this.textBoxPotok.TabIndex = 11;
            // 
            // numericUpDownCourse
            // 
            this.numericUpDownCourse.Location = new System.Drawing.Point(300, 36);
            this.numericUpDownCourse.Name = "numericUpDownCourse";
            this.numericUpDownCourse.Size = new System.Drawing.Size(72, 20);
            this.numericUpDownCourse.TabIndex = 10;
            // 
            // labelFakNumber
            // 
            this.labelFakNumber.AutoSize = true;
            this.labelFakNumber.Location = new System.Drawing.Point(17, 142);
            this.labelFakNumber.Name = "labelFakNumber";
            this.labelFakNumber.Size = new System.Drawing.Size(71, 13);
            this.labelFakNumber.TabIndex = 9;
            this.labelFakNumber.Text = "Фак. номер:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(44, 115);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 13);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "Статус:";
            // 
            // labelOKS
            // 
            this.labelOKS.AutoSize = true;
            this.labelOKS.Location = new System.Drawing.Point(56, 88);
            this.labelOKS.Name = "labelOKS";
            this.labelOKS.Size = new System.Drawing.Size(32, 13);
            this.labelOKS.TabIndex = 7;
            this.labelOKS.Text = "ОКС:";
            // 
            // labelSpecialty
            // 
            this.labelSpecialty.AutoSize = true;
            this.labelSpecialty.Location = new System.Drawing.Point(12, 62);
            this.labelSpecialty.Name = "labelSpecialty";
            this.labelSpecialty.Size = new System.Drawing.Size(76, 13);
            this.labelSpecialty.TabIndex = 6;
            this.labelSpecialty.Text = "Специалност:";
            // 
            // labelFaculty
            // 
            this.labelFaculty.AutoSize = true;
            this.labelFaculty.Location = new System.Drawing.Point(28, 36);
            this.labelFaculty.Name = "labelFaculty";
            this.labelFaculty.Size = new System.Drawing.Size(60, 13);
            this.labelFaculty.TabIndex = 5;
            this.labelFaculty.Text = "Факултет:";
            // 
            // textBoxFakNumber
            // 
            this.textBoxFakNumber.Location = new System.Drawing.Point(94, 139);
            this.textBoxFakNumber.Name = "textBoxFakNumber";
            this.textBoxFakNumber.Size = new System.Drawing.Size(121, 20);
            this.textBoxFakNumber.TabIndex = 4;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "0"});
            this.comboBoxStatus.Location = new System.Drawing.Point(94, 112);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 3;
            this.comboBoxStatus.Text = "Избери...";
            // 
            // comboBoxOKS
            // 
            this.comboBoxOKS.FormattingEnabled = true;
            this.comboBoxOKS.Items.AddRange(new object[] {
            "0"});
            this.comboBoxOKS.Location = new System.Drawing.Point(94, 85);
            this.comboBoxOKS.Name = "comboBoxOKS";
            this.comboBoxOKS.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOKS.TabIndex = 2;
            this.comboBoxOKS.Text = "Избери...";
            // 
            // textBoxSpecialty
            // 
            this.textBoxSpecialty.Location = new System.Drawing.Point(94, 59);
            this.textBoxSpecialty.Name = "textBoxSpecialty";
            this.textBoxSpecialty.Size = new System.Drawing.Size(121, 20);
            this.textBoxSpecialty.TabIndex = 1;
            // 
            // textBoxFaculty
            // 
            this.textBoxFaculty.Location = new System.Drawing.Point(94, 33);
            this.textBoxFaculty.Name = "textBoxFaculty";
            this.textBoxFaculty.Size = new System.Drawing.Size(121, 20);
            this.textBoxFaculty.TabIndex = 0;
            // 
            // groupBoxStudentPersonalData
            // 
            this.groupBoxStudentPersonalData.Controls.Add(this.textBoxStudentThirdName);
            this.groupBoxStudentPersonalData.Controls.Add(this.textBoxStudentSecondName);
            this.groupBoxStudentPersonalData.Controls.Add(this.textBoxStudentFirstName);
            this.groupBoxStudentPersonalData.Controls.Add(this.labelStudentThirdName);
            this.groupBoxStudentPersonalData.Controls.Add(this.labelStudentSecondName);
            this.groupBoxStudentPersonalData.Controls.Add(this.labelStudentFirstName);
            this.groupBoxStudentPersonalData.Location = new System.Drawing.Point(215, 3);
            this.groupBoxStudentPersonalData.Name = "groupBoxStudentPersonalData";
            this.groupBoxStudentPersonalData.Size = new System.Drawing.Size(390, 129);
            this.groupBoxStudentPersonalData.TabIndex = 1;
            this.groupBoxStudentPersonalData.TabStop = false;
            this.groupBoxStudentPersonalData.Text = "Лични данни";
            // 
            // textBoxStudentThirdName
            // 
            this.textBoxStudentThirdName.Location = new System.Drawing.Point(94, 83);
            this.textBoxStudentThirdName.Name = "textBoxStudentThirdName";
            this.textBoxStudentThirdName.Size = new System.Drawing.Size(278, 20);
            this.textBoxStudentThirdName.TabIndex = 5;
            // 
            // textBoxStudentSecondName
            // 
            this.textBoxStudentSecondName.Location = new System.Drawing.Point(94, 55);
            this.textBoxStudentSecondName.Name = "textBoxStudentSecondName";
            this.textBoxStudentSecondName.Size = new System.Drawing.Size(278, 20);
            this.textBoxStudentSecondName.TabIndex = 4;
            // 
            // textBoxStudentFirstName
            // 
            this.textBoxStudentFirstName.Location = new System.Drawing.Point(94, 29);
            this.textBoxStudentFirstName.Name = "textBoxStudentFirstName";
            this.textBoxStudentFirstName.Size = new System.Drawing.Size(278, 20);
            this.textBoxStudentFirstName.TabIndex = 3;
            // 
            // labelStudentThirdName
            // 
            this.labelStudentThirdName.AutoSize = true;
            this.labelStudentThirdName.Location = new System.Drawing.Point(29, 86);
            this.labelStudentThirdName.Name = "labelStudentThirdName";
            this.labelStudentThirdName.Size = new System.Drawing.Size(59, 13);
            this.labelStudentThirdName.TabIndex = 2;
            this.labelStudentThirdName.Text = "Фамилия:";
            // 
            // labelStudentSecondName
            // 
            this.labelStudentSecondName.AutoSize = true;
            this.labelStudentSecondName.Location = new System.Drawing.Point(32, 58);
            this.labelStudentSecondName.Name = "labelStudentSecondName";
            this.labelStudentSecondName.Size = new System.Drawing.Size(56, 13);
            this.labelStudentSecondName.TabIndex = 1;
            this.labelStudentSecondName.Text = "Презиме:";
            // 
            // labelStudentFirstName
            // 
            this.labelStudentFirstName.AutoSize = true;
            this.labelStudentFirstName.Location = new System.Drawing.Point(56, 32);
            this.labelStudentFirstName.Name = "labelStudentFirstName";
            this.labelStudentFirstName.Size = new System.Drawing.Size(32, 13);
            this.labelStudentFirstName.TabIndex = 0;
            this.labelStudentFirstName.Text = "Име:";
            // 
            // groupBoxStudentPhoto
            // 
            this.groupBoxStudentPhoto.Controls.Add(this.pbStudentPhoto);
            this.groupBoxStudentPhoto.Location = new System.Drawing.Point(3, 3);
            this.groupBoxStudentPhoto.Name = "groupBoxStudentPhoto";
            this.groupBoxStudentPhoto.Size = new System.Drawing.Size(206, 207);
            this.groupBoxStudentPhoto.TabIndex = 0;
            this.groupBoxStudentPhoto.TabStop = false;
            this.groupBoxStudentPhoto.Text = "Снимка";
            // 
            // pbStudentPhoto
            // 
            this.pbStudentPhoto.Location = new System.Drawing.Point(38, 19);
            this.pbStudentPhoto.Name = "pbStudentPhoto";
            this.pbStudentPhoto.Size = new System.Drawing.Size(117, 143);
            this.pbStudentPhoto.TabIndex = 0;
            this.pbStudentPhoto.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(613, 337);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Оценки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "openPictureDialog";
            this.openPictureDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 390);
            this.Controls.Add(this.tabControlStudentInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlStudentInfo.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBoxStudenInfo.ResumeLayout(false);
            this.groupBoxStudenInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).EndInit();
            this.groupBoxStudentPersonalData.ResumeLayout(false);
            this.groupBoxStudentPersonalData.PerformLayout();
            this.groupBoxStudentPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginLogoutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlStudentInfo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBoxStudentPhoto;
        private System.Windows.Forms.PictureBox pbStudentPhoto;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxStudentPersonalData;
        private System.Windows.Forms.TextBox textBoxStudentThirdName;
        private System.Windows.Forms.TextBox textBoxStudentSecondName;
        private System.Windows.Forms.TextBox textBoxStudentFirstName;
        private System.Windows.Forms.Label labelStudentThirdName;
        private System.Windows.Forms.Label labelStudentSecondName;
        private System.Windows.Forms.Label labelStudentFirstName;
        private System.Windows.Forms.GroupBox groupBoxStudenInfo;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.TextBox textBoxPotok;
        private System.Windows.Forms.NumericUpDown numericUpDownCourse;
        private System.Windows.Forms.Label labelFakNumber;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelOKS;
        private System.Windows.Forms.Label labelSpecialty;
        private System.Windows.Forms.Label labelFaculty;
        private System.Windows.Forms.TextBox textBoxFakNumber;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxOKS;
        private System.Windows.Forms.TextBox textBoxSpecialty;
        private System.Windows.Forms.TextBox textBoxFaculty;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelPotok;
        private System.Windows.Forms.ToolStripMenuItem openPictureToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.ToolStripMenuItem miUverenie;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.ToolStripMenuItem infoForGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
    }
}