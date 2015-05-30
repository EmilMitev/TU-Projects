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
    public partial class GroupsForm : Form
    {

        public GroupsForm()
        {
            InitializeComponent();

        }

        private void GroupsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentInfoDatabaseDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentInfoDatabaseDataSet.Student);

            List<int> groupList;
            groupList = new List<int>();
            groupList = Data.UserData.ShowAllGroup();

            for (int i = 0; i < groupList.Count; i++)
            {
                comboBoxGroup.Items.Add(groupList[i]);
            }
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.studentTableAdapter.FillByGroup(this.studentInfoDatabaseDataSet.Student, ((int)(System.Convert.ChangeType(comboBoxGroup.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}