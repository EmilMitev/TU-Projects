using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class Difficulty : Form
    {
        public int Choise { get; private set; }

        public Difficulty()
        {
            InitializeComponent();
        }

        private void buttonEasy_Click(object sender, EventArgs e)
        {
            this.Choise = 1;
            this.Close();
        }

        private void buttonNormal_Click(object sender, EventArgs e)
        {
            this.Choise = 2;
            this.Close();
        }

        private void buttonHard_Click(object sender, EventArgs e)
        {
            this.Choise = 3;
            this.Close();
        }
    }
}
