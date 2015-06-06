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
using System.Diagnostics;
using CardGame.Data;

namespace CardGame
{
    public partial class CardGame : Form
    {
        GameLogic logic;
        private List<int> list;
        public List<PictureBox> picBoxE;
        public List<PictureBox> picBoxN;
        private int score = 0;
        private int moves = 1;

        public Stopwatch stopWatch;

        public CardGame()
        {
            InitializeComponent();
            UnVisible();
            ClientSize = new System.Drawing.Size(427, 244);
            list = new List<int>();
            picBoxE = new List<PictureBox>();
            picBoxN = new List<PictureBox>();
            stopWatch = new Stopwatch();
        }

        private void UnVisible()
        {
            panelEasy.Visible = false;
            panelNormal.Visible = false;
        }

        private void VisiblePanelEasy()
        {
            panelEasy.Visible = true;
            panelWelcome.Visible = false;
        }

        private void VisiblePanelNormal()
        {
            panelNormal.Visible = true;
            panelWelcome.Visible = false;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Difficulty diff = new Difficulty();
            diff.ShowDialog();
            if (diff.Choise == 1)
            {
                UnVisible();
                VisiblePanelEasy();
                ClientSize = new System.Drawing.Size(442, 442);
                logic = new GameLogic(1);
                stopWatch.Start();

            }
            if (diff.Choise == 2)
            {
                UnVisible();
                VisiblePanelNormal();
                ClientSize = new System.Drawing.Size(654, 444);
                logic = new GameLogic(2);
                stopWatch.Start();
            }
        }

        private void OpenedCardAndScores(int i, int j)
        {
            if (logic.IsMaxFlipCard())
            {
                if (logic.Logic(list))
                {
                    CardID(list[0], list[1]);
                    CardID(list[2], list[3]);
                    score += 1000 / moves;
                }
                if (logic.EasyCards == 0 || logic.NormalCards == 0)
                {
                    stopWatch.Stop();
                    logic.EndGame(stopWatch.Elapsed.Minutes, stopWatch.Elapsed.Seconds, stopWatch.Elapsed.Milliseconds, score);
                    stopWatch.Reset();
                }
                ++moves;
                ResetCard();
                list = new List<int>();
            }
            else
            {
                list.Add(i);
                list.Add(j);
            }
        }

        #region ResetCard
        private void ResetCard()
        {
            pictureBox1E.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox2E.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox3E.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox4E.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox5E.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox6E.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox7E.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox8E.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox9E.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox10E.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox11E.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox12E.Image = global::CardGame.Properties.Resources.CardBack;

            pictureBox1N.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox2N.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox3N.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox4N.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox5N.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox6N.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox7N.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox8N.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox9N.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox10N.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox11N.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox12N.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox13N.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox14N.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox15N.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox16N.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox17N.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox18N.Image = global::CardGame.Properties.Resources.CardBack;
        }
        #endregion

        #region CardID
        public void CardID(int i, int j)
        {
            if (panelEasy.Visible == true)
            {
                if (i == 0 && j == 0) { pictureBox1E.Visible = false; }
                if (i == 0 && j == 1) { pictureBox2E.Visible = false; }
                if (i == 0 && j == 2) { pictureBox3E.Visible = false; }
                if (i == 0 && j == 3) { pictureBox4E.Visible = false; }
                if (i == 1 && j == 0) { pictureBox5E.Visible = false; }
                if (i == 1 && j == 1) { pictureBox6E.Visible = false; }
                if (i == 1 && j == 2) { pictureBox7E.Visible = false; }
                if (i == 1 && j == 3) { pictureBox8E.Visible = false; }
                if (i == 2 && j == 0) { pictureBox9E.Visible = false; }
                if (i == 2 && j == 1) { pictureBox10E.Visible = false; }
                if (i == 2 && j == 2) { pictureBox11E.Visible = false; }
                if (i == 2 && j == 3) { pictureBox12E.Visible = false; }
            }
            if (panelNormal.Visible == true)
            {
                if (i == 0 && j == 0) { pictureBox1N.Visible = false; }
                if (i == 0 && j == 1) { pictureBox2N.Visible = false; }
                if (i == 0 && j == 2) { pictureBox3N.Visible = false; }
                if (i == 0 && j == 3) { pictureBox4N.Visible = false; }
                if (i == 0 && j == 4) { pictureBox5N.Visible = false; }
                if (i == 0 && j == 5) { pictureBox6N.Visible = false; }
                if (i == 1 && j == 0) { pictureBox7N.Visible = false; }
                if (i == 1 && j == 1) { pictureBox8N.Visible = false; }
                if (i == 1 && j == 2) { pictureBox9N.Visible = false; }
                if (i == 1 && j == 3) { pictureBox10N.Visible = false; }
                if (i == 1 && j == 4) { pictureBox11N.Visible = false; }
                if (i == 1 && j == 5) { pictureBox12N.Visible = false; }
                if (i == 2 && j == 0) { pictureBox13N.Visible = false; }
                if (i == 2 && j == 1) { pictureBox14N.Visible = false; }
                if (i == 2 && j == 2) { pictureBox15N.Visible = false; }
                if (i == 2 && j == 3) { pictureBox16N.Visible = false; }
                if (i == 2 && j == 4) { pictureBox17N.Visible = false; }
                if (i == 2 && j == 5) { pictureBox18N.Visible = false; }
            }
        }
        #endregion

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            string name = pb.Name;
            AddPBToList();
            picBoxE[logic.PBNumber(name)].Image = logic.SetPicture(logic.MatrixEasy, logic.mass[0], logic.mass[1]);
            OpenedCardAndScores(logic.mass[0], logic.mass[1]);
        }

        private void pictureBoxN_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            string name = pb.Name;
            AddPBToList();
            picBoxN[logic.PBNumber(name)].Image = logic.SetPicture(logic.MatrixNormal, logic.mass[0], logic.mass[1]);
            OpenedCardAndScores(logic.mass[0], logic.mass[1]);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPBToList()
        {
            picBoxE.Add(this.pictureBox1E);
            picBoxE.Add(this.pictureBox2E);
            picBoxE.Add(this.pictureBox3E);
            picBoxE.Add(this.pictureBox4E);
            picBoxE.Add(this.pictureBox5E);
            picBoxE.Add(this.pictureBox6E);
            picBoxE.Add(this.pictureBox7E);
            picBoxE.Add(this.pictureBox8E);
            picBoxE.Add(this.pictureBox9E);
            picBoxE.Add(this.pictureBox10E);
            picBoxE.Add(this.pictureBox11E);
            picBoxE.Add(this.pictureBox12E);

            picBoxN.Add(this.pictureBox1N);
            picBoxN.Add(this.pictureBox2N);
            picBoxN.Add(this.pictureBox3N);
            picBoxN.Add(this.pictureBox4N);
            picBoxN.Add(this.pictureBox5N);
            picBoxN.Add(this.pictureBox6N);
            picBoxN.Add(this.pictureBox7N);
            picBoxN.Add(this.pictureBox8N);
            picBoxN.Add(this.pictureBox9N);
            picBoxN.Add(this.pictureBox10N);
            picBoxN.Add(this.pictureBox11N);
            picBoxN.Add(this.pictureBox12N);
            picBoxN.Add(this.pictureBox13N);
            picBoxN.Add(this.pictureBox14N);
            picBoxN.Add(this.pictureBox15N);
            picBoxN.Add(this.pictureBox16N);
            picBoxN.Add(this.pictureBox17N);
            picBoxN.Add(this.pictureBox18N);
        }
    }
}