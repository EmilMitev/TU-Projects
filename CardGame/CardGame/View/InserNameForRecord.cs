using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardGame.Logic;

namespace CardGame.View
{
    public partial class InserNameForRecord : Form
    {
        public int Choise { get; private set; }

        public InserNameForRecord()
        {
            InitializeComponent();
        }

        public void ShowDataInDialog(int score, string time)
        {
            this.labelScore.Text = score.ToString();
            this.labelTime.Text = time;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            GameLogic logic = new GameLogic();
            logic.InsertNewRecord(textBoxName.Text, labelScore.Text, labelTime.Text);
            TopFive five = new TopFive(logic.GetRecords());
            five.ShowDialog();            
            this.Close();
        }
    }
}
