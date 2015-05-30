namespace StudentInfoSystem.View
{
    partial class GroupsForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fakNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfoDatabaseDataSet = new StudentInfoSystem.StudentInfoDatabaseDataSet();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.studentTableAdapter = new StudentInfoSystem.StudentInfoDatabaseDataSetTableAdapters.StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.secondNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.facultyDataGridViewTextBoxColumn,
            this.specialtyDataGridViewTextBoxColumn,
            this.oKSDataGridViewTextBoxColumn,
            this.studentStatusDataGridViewTextBoxColumn,
            this.fakNumberDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.potokDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1254, 177);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            this.secondNameDataGridViewTextBoxColumn.DataPropertyName = "SecondName";
            this.secondNameDataGridViewTextBoxColumn.HeaderText = "SecondName";
            this.secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // facultyDataGridViewTextBoxColumn
            // 
            this.facultyDataGridViewTextBoxColumn.DataPropertyName = "Faculty";
            this.facultyDataGridViewTextBoxColumn.HeaderText = "Faculty";
            this.facultyDataGridViewTextBoxColumn.Name = "facultyDataGridViewTextBoxColumn";
            // 
            // specialtyDataGridViewTextBoxColumn
            // 
            this.specialtyDataGridViewTextBoxColumn.DataPropertyName = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.HeaderText = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.Name = "specialtyDataGridViewTextBoxColumn";
            // 
            // oKSDataGridViewTextBoxColumn
            // 
            this.oKSDataGridViewTextBoxColumn.DataPropertyName = "OKS";
            this.oKSDataGridViewTextBoxColumn.HeaderText = "OKS";
            this.oKSDataGridViewTextBoxColumn.Name = "oKSDataGridViewTextBoxColumn";
            // 
            // studentStatusDataGridViewTextBoxColumn
            // 
            this.studentStatusDataGridViewTextBoxColumn.DataPropertyName = "StudentStatus";
            this.studentStatusDataGridViewTextBoxColumn.HeaderText = "StudentStatus";
            this.studentStatusDataGridViewTextBoxColumn.Name = "studentStatusDataGridViewTextBoxColumn";
            // 
            // fakNumberDataGridViewTextBoxColumn
            // 
            this.fakNumberDataGridViewTextBoxColumn.DataPropertyName = "FakNumber";
            this.fakNumberDataGridViewTextBoxColumn.HeaderText = "FakNumber";
            this.fakNumberDataGridViewTextBoxColumn.Name = "fakNumberDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // potokDataGridViewTextBoxColumn
            // 
            this.potokDataGridViewTextBoxColumn.DataPropertyName = "Potok";
            this.potokDataGridViewTextBoxColumn.HeaderText = "Potok";
            this.potokDataGridViewTextBoxColumn.Name = "potokDataGridViewTextBoxColumn";
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "[Group]";
            this.groupDataGridViewTextBoxColumn.HeaderText = "[Group]";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.studentInfoDatabaseDataSet;
            // 
            // studentInfoDatabaseDataSet
            // 
            this.studentInfoDatabaseDataSet.DataSetName = "StudentInfoDatabaseDataSet";
            this.studentInfoDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(12, 12);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGroup.TabIndex = 1;
            this.comboBoxGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroup_SelectedIndexChanged);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 380);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GroupsForm";
            this.Text = "GroupsForm";
            this.Load += new System.EventHandler(this.GroupsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StudentInfoDatabaseDataSet studentInfoDatabaseDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StudentInfoDatabaseDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fakNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxGroup;
    }
}