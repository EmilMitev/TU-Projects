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
        private int score = 0;
        private int moves = 1;

        Stopwatch stopWatch;

        public CardGame()
        {
            InitializeComponent();
            UnVisible();
            ClientSize = new System.Drawing.Size(427, 244);
            list = new List<int>();
            stopWatch = new Stopwatch();
        }

        private void UnVisible()
        {
            panelEasy.Visible = false;
            panelHard.Visible = false;
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

        private void VisiblePanelHard()
        {
            panelHard.Visible = true;
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
            if (diff.Choise == 3)
            {
                UnVisible();
                VisiblePanelHard();
                ClientSize = new System.Drawing.Size(976, 579);
                logic = new GameLogic(3);
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
                if (logic.EasyCards == 0 || logic.NormalCards == 0 || logic.HardCards == 0)
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

            pictureBox1H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox2H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox3H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox4H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox5H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox6H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox7H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox8H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox9H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox10H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox11H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox12H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox13H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox14H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox15H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox16H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox17H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox18H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox19H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox20H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox21H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox22H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox23H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox24H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox25H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox26H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox27H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox28H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox29H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox30H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox31H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox32H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox33H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox34H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox35H.Image = global::CardGame.Properties.Resources.CardBack;
            pictureBox36H.Image = global::CardGame.Properties.Resources.CardBack;
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
            if (panelHard.Visible == true)
            {
                if (i == 0 && j == 0) { pictureBox1H.Visible = false; }
                if (i == 0 && j == 1) { pictureBox2H.Visible = false; }
                if (i == 0 && j == 2) { pictureBox3H.Visible = false; }
                if (i == 0 && j == 3) { pictureBox4H.Visible = false; }
                if (i == 0 && j == 4) { pictureBox5H.Visible = false; }
                if (i == 0 && j == 5) { pictureBox6H.Visible = false; }
                if (i == 0 && j == 6) { pictureBox7H.Visible = false; }
                if (i == 0 && j == 7) { pictureBox8H.Visible = false; }
                if (i == 0 && j == 8) { pictureBox9H.Visible = false; }
                if (i == 1 && j == 0) { pictureBox10H.Visible = false; }
                if (i == 1 && j == 1) { pictureBox11H.Visible = false; }
                if (i == 1 && j == 2) { pictureBox12H.Visible = false; }
                if (i == 1 && j == 3) { pictureBox13H.Visible = false; }
                if (i == 1 && j == 4) { pictureBox14H.Visible = false; }
                if (i == 1 && j == 5) { pictureBox15H.Visible = false; }
                if (i == 1 && j == 6) { pictureBox16H.Visible = false; }
                if (i == 1 && j == 7) { pictureBox17H.Visible = false; }
                if (i == 1 && j == 8) { pictureBox18H.Visible = false; }
                if (i == 2 && j == 0) { pictureBox19H.Visible = false; }
                if (i == 2 && j == 1) { pictureBox20H.Visible = false; }
                if (i == 2 && j == 2) { pictureBox21H.Visible = false; }
                if (i == 2 && j == 3) { pictureBox22H.Visible = false; }
                if (i == 2 && j == 4) { pictureBox23H.Visible = false; }
                if (i == 2 && j == 5) { pictureBox24H.Visible = false; }
                if (i == 2 && j == 6) { pictureBox25H.Visible = false; }
                if (i == 2 && j == 7) { pictureBox26H.Visible = false; }
                if (i == 2 && j == 8) { pictureBox27H.Visible = false; }
                if (i == 3 && j == 0) { pictureBox28H.Visible = false; }
                if (i == 3 && j == 1) { pictureBox29H.Visible = false; }
                if (i == 3 && j == 2) { pictureBox30H.Visible = false; }
                if (i == 3 && j == 3) { pictureBox31H.Visible = false; }
                if (i == 3 && j == 4) { pictureBox32H.Visible = false; }
                if (i == 3 && j == 5) { pictureBox33H.Visible = false; }
                if (i == 3 && j == 6) { pictureBox34H.Visible = false; }
                if (i == 3 && j == 7) { pictureBox35H.Visible = false; }
                if (i == 3 && j == 8) { pictureBox36H.Visible = false; }
            }
        }
        #endregion

        #region Easy
        private void pictureBox1E_Click(object sender, EventArgs e)
        {
            pictureBox1E.Image = logic.SetPicture(logic.MatrixEasy, 0, 0);
            OpenedCardAndScores(0, 0);
        }
        private void pictureBox2E_Click(object sender, EventArgs e)
        {
            pictureBox2E.Image = logic.SetPicture(logic.MatrixEasy, 0, 1);
            OpenedCardAndScores(0, 1);
        }
        private void pictureBox3E_Click(object sender, EventArgs e)
        {
            pictureBox3E.Image = logic.SetPicture(logic.MatrixEasy, 0, 2);
            OpenedCardAndScores(0, 2);
        }
        private void pictureBox4E_Click(object sender, EventArgs e)
        {
            pictureBox4E.Image = logic.SetPicture(logic.MatrixEasy, 0, 3);
            OpenedCardAndScores(0, 3);
        }
        private void pictureBox5E_Click(object sender, EventArgs e)
        {
            pictureBox5E.Image = logic.SetPicture(logic.MatrixEasy, 1, 0);
            OpenedCardAndScores(1, 0);
        }
        private void pictureBox6E_Click(object sender, EventArgs e)
        {
            pictureBox6E.Image = logic.SetPicture(logic.MatrixEasy, 1, 1);
            OpenedCardAndScores(1, 1);
        }
        private void pictureBox7E_Click(object sender, EventArgs e)
        {
            pictureBox7E.Image = logic.SetPicture(logic.MatrixEasy, 1, 2);
            OpenedCardAndScores(1, 2);
        }
        private void pictureBox8E_Click(object sender, EventArgs e)
        {
            pictureBox8E.Image = logic.SetPicture(logic.MatrixEasy, 1, 3);
            OpenedCardAndScores(1, 3);
        }
        private void pictureBox9E_Click(object sender, EventArgs e)
        {
            pictureBox9E.Image = logic.SetPicture(logic.MatrixEasy, 2, 0);
            OpenedCardAndScores(2, 0);
        }
        private void pictureBox10E_Click(object sender, EventArgs e)
        {
            pictureBox10E.Image = logic.SetPicture(logic.MatrixEasy, 2, 1);
            OpenedCardAndScores(2, 1);
        }
        private void pictureBox11E_Click(object sender, EventArgs e)
        {
            pictureBox11E.Image = logic.SetPicture(logic.MatrixEasy, 2, 2);
            OpenedCardAndScores(2, 2);
        }
        private void pictureBox12E_Click(object sender, EventArgs e)
        {
            pictureBox12E.Image = logic.SetPicture(logic.MatrixEasy, 2, 3);
            OpenedCardAndScores(2, 3);
        }
        #endregion

        #region Normal
        private void pictureBox1N_Click(object sender, EventArgs e)
        {
            pictureBox1N.Image = logic.SetPicture(logic.MatrixNormal, 0, 0);
            OpenedCardAndScores(0, 0);
        }
        private void pictureBox2N_Click(object sender, EventArgs e)
        {
            pictureBox2N.Image = logic.SetPicture(logic.MatrixNormal, 0, 1);
            OpenedCardAndScores(0, 1);
        }
        private void pictureBox3N_Click(object sender, EventArgs e)
        {
            pictureBox3N.Image = logic.SetPicture(logic.MatrixNormal, 0, 2);
            OpenedCardAndScores(0, 2);
        }
        private void pictureBox4N_Click(object sender, EventArgs e)
        {
            pictureBox4N.Image = logic.SetPicture(logic.MatrixNormal, 0, 3);
            OpenedCardAndScores(0, 3);
        }
        private void pictureBox5N_Click(object sender, EventArgs e)
        {
            pictureBox5N.Image = logic.SetPicture(logic.MatrixNormal, 0, 4);
            OpenedCardAndScores(0, 4);
        }
        private void pictureBox6N_Click(object sender, EventArgs e)
        {
            pictureBox6N.Image = logic.SetPicture(logic.MatrixNormal, 0, 5);
            OpenedCardAndScores(0, 5);
        }
        private void pictureBox7N_Click(object sender, EventArgs e)
        {
            pictureBox7N.Image = logic.SetPicture(logic.MatrixNormal, 1, 0);
            OpenedCardAndScores(1, 0);
        }
        private void pictureBox8N_Click(object sender, EventArgs e)
        {
            pictureBox8N.Image = logic.SetPicture(logic.MatrixNormal, 1, 1);
            OpenedCardAndScores(1, 1);
        }
        private void pictureBox9N_Click(object sender, EventArgs e)
        {
            pictureBox9N.Image = logic.SetPicture(logic.MatrixNormal, 1, 2);
            OpenedCardAndScores(1, 2);
        }
        private void pictureBox10N_Click(object sender, EventArgs e)
        {
            pictureBox10N.Image = logic.SetPicture(logic.MatrixNormal, 1, 3);
            OpenedCardAndScores(1, 3);
        }
        private void pictureBox11N_Click(object sender, EventArgs e)
        {
            pictureBox11N.Image = logic.SetPicture(logic.MatrixNormal, 1, 4);
            OpenedCardAndScores(1, 4);
        }
        private void pictureBox12N_Click(object sender, EventArgs e)
        {
            pictureBox12N.Image = logic.SetPicture(logic.MatrixNormal, 1, 5);
            OpenedCardAndScores(1, 5);
        }
        private void pictureBox13N_Click(object sender, EventArgs e)
        {
            pictureBox13N.Image = logic.SetPicture(logic.MatrixNormal, 2, 0);
            OpenedCardAndScores(2, 0);
        }
        private void pictureBox14N_Click(object sender, EventArgs e)
        {
            pictureBox14N.Image = logic.SetPicture(logic.MatrixNormal, 2, 1);
            OpenedCardAndScores(2, 1);
        }
        private void pictureBox15N_Click(object sender, EventArgs e)
        {
            pictureBox15N.Image = logic.SetPicture(logic.MatrixNormal, 2, 2);
            OpenedCardAndScores(2, 2);
        }
        private void pictureBox16N_Click(object sender, EventArgs e)
        {
            pictureBox16N.Image = logic.SetPicture(logic.MatrixNormal, 2, 3);
            OpenedCardAndScores(2, 3);
        }
        private void pictureBox17N_Click(object sender, EventArgs e)
        {
            pictureBox17N.Image = logic.SetPicture(logic.MatrixNormal, 2, 4);
            OpenedCardAndScores(2, 4);
        }
        private void pictureBox18N_Click(object sender, EventArgs e)
        {
            pictureBox18N.Image = logic.SetPicture(logic.MatrixNormal, 2, 5);
            OpenedCardAndScores(2, 5);
        }
        #endregion

        #region Hard
        private void pictureBox1H_Click(object sender, EventArgs e)
        {
            pictureBox1H.Image = logic.SetPicture(logic.MatrixHard, 0, 0);
            OpenedCardAndScores(0, 0);
        }
        private void pictureBox2H_Click(object sender, EventArgs e)
        {
            pictureBox2H.Image = logic.SetPicture(logic.MatrixHard, 0, 1);
            OpenedCardAndScores(0, 1);
        }
        private void pictureBox3H_Click(object sender, EventArgs e)
        {
            pictureBox3H.Image = logic.SetPicture(logic.MatrixHard, 0, 2);
            OpenedCardAndScores(0, 2);
        }
        private void pictureBox4H_Click(object sender, EventArgs e)
        {
            pictureBox4H.Image = logic.SetPicture(logic.MatrixHard, 0, 3);
            OpenedCardAndScores(0, 3);
        }
        private void pictureBox5H_Click(object sender, EventArgs e)
        {
            pictureBox5H.Image = logic.SetPicture(logic.MatrixHard, 0, 4);
            OpenedCardAndScores(0, 4);
        }
        private void pictureBox6H_Click(object sender, EventArgs e)
        {
            pictureBox6H.Image = logic.SetPicture(logic.MatrixHard, 0, 5);
            OpenedCardAndScores(0, 5);
        }
        private void pictureBox7H_Click(object sender, EventArgs e)
        {
            pictureBox7H.Image = logic.SetPicture(logic.MatrixHard, 0, 6);
            OpenedCardAndScores(0, 6);
        }
        private void pictureBox8H_Click(object sender, EventArgs e)
        {
            pictureBox8H.Image = logic.SetPicture(logic.MatrixHard, 0, 7);
            OpenedCardAndScores(0, 7);
        }
        private void pictureBox9H_Click(object sender, EventArgs e)
        {
            pictureBox9H.Image = logic.SetPicture(logic.MatrixHard, 0, 8);
            OpenedCardAndScores(0, 8);
        }
        private void pictureBox10H_Click(object sender, EventArgs e)
        {
            pictureBox10H.Image = logic.SetPicture(logic.MatrixHard, 1, 0);
            OpenedCardAndScores(1, 0);
        }
        private void pictureBox11H_Click(object sender, EventArgs e)
        {
            pictureBox11H.Image = logic.SetPicture(logic.MatrixHard, 1, 1);
            OpenedCardAndScores(1, 1);
        }
        private void pictureBox12H_Click(object sender, EventArgs e)
        {
            pictureBox12H.Image = logic.SetPicture(logic.MatrixHard, 1, 2);
            OpenedCardAndScores(1, 2);
        }
        private void pictureBox13H_Click(object sender, EventArgs e)
        {
            pictureBox13H.Image = logic.SetPicture(logic.MatrixHard, 1, 3);
            OpenedCardAndScores(1, 3);
        }
        private void pictureBox14H_Click(object sender, EventArgs e)
        {
            pictureBox14H.Image = logic.SetPicture(logic.MatrixHard, 1, 4);
            OpenedCardAndScores(1, 4);
        }
        private void pictureBox15H_Click(object sender, EventArgs e)
        {
            pictureBox15H.Image = logic.SetPicture(logic.MatrixHard, 1, 5);
            OpenedCardAndScores(1, 5);
        }
        private void pictureBox16H_Click(object sender, EventArgs e)
        {
            pictureBox16H.Image = logic.SetPicture(logic.MatrixHard, 1, 6);
            OpenedCardAndScores(1, 6);
        }
        private void pictureBox17H_Click(object sender, EventArgs e)
        {
            pictureBox17H.Image = logic.SetPicture(logic.MatrixHard, 1, 7);
            OpenedCardAndScores(1, 7);
        }
        private void pictureBox18H_Click(object sender, EventArgs e)
        {
            pictureBox18H.Image = logic.SetPicture(logic.MatrixHard, 1, 8);
            OpenedCardAndScores(1, 8);
        }
        private void pictureBox19H_Click(object sender, EventArgs e)
        {
            pictureBox19H.Image = logic.SetPicture(logic.MatrixHard, 2, 0);
            OpenedCardAndScores(2, 0);
        }
        private void pictureBox20H_Click(object sender, EventArgs e)
        {
            pictureBox20H.Image = logic.SetPicture(logic.MatrixHard, 2, 1);
            OpenedCardAndScores(2, 1);
        }
        private void pictureBox21H_Click(object sender, EventArgs e)
        {
            pictureBox21H.Image = logic.SetPicture(logic.MatrixHard, 2, 2);
            OpenedCardAndScores(2, 2);
        }
        private void pictureBox22H_Click(object sender, EventArgs e)
        {
            pictureBox22H.Image = logic.SetPicture(logic.MatrixHard, 2, 3);
            OpenedCardAndScores(2, 3);
        }
        private void pictureBox23H_Click(object sender, EventArgs e)
        {
            pictureBox23H.Image = logic.SetPicture(logic.MatrixHard, 2, 4);
            OpenedCardAndScores(2, 4);
        }
        private void pictureBox24H_Click(object sender, EventArgs e)
        {
            pictureBox24H.Image = logic.SetPicture(logic.MatrixHard, 2, 5);
            OpenedCardAndScores(2, 5);
        }
        private void pictureBox25H_Click(object sender, EventArgs e)
        {
            pictureBox25H.Image = logic.SetPicture(logic.MatrixHard, 2, 6);
            OpenedCardAndScores(2, 6);
        }
        private void pictureBox26H_Click(object sender, EventArgs e)
        {
            pictureBox26H.Image = logic.SetPicture(logic.MatrixHard, 2, 7);
            OpenedCardAndScores(2, 7);
        }
        private void pictureBox27H_Click(object sender, EventArgs e)
        {
            pictureBox27H.Image = logic.SetPicture(logic.MatrixHard, 2, 8);
            OpenedCardAndScores(2, 8);
        }
        private void pictureBox28H_Click(object sender, EventArgs e)
        {
            pictureBox28H.Image = logic.SetPicture(logic.MatrixHard, 3, 0);
            OpenedCardAndScores(3, 0);
        }
        private void pictureBox29H_Click(object sender, EventArgs e)
        {
            pictureBox29H.Image = logic.SetPicture(logic.MatrixHard, 3, 1);
            OpenedCardAndScores(3, 1);
        }
        private void pictureBox30H_Click(object sender, EventArgs e)
        {
            pictureBox30H.Image = logic.SetPicture(logic.MatrixHard, 3, 2);
            OpenedCardAndScores(3, 2);
        }
        private void pictureBox31H_Click(object sender, EventArgs e)
        {
            pictureBox31H.Image = logic.SetPicture(logic.MatrixHard, 3, 3);
            OpenedCardAndScores(3, 3);
        }
        private void pictureBox32H_Click(object sender, EventArgs e)
        {
            pictureBox32H.Image = logic.SetPicture(logic.MatrixHard, 3, 4);
            OpenedCardAndScores(3, 4);
        }
        private void pictureBox33H_Click(object sender, EventArgs e)
        {
            pictureBox33H.Image = logic.SetPicture(logic.MatrixHard, 3, 5);
            OpenedCardAndScores(3, 5);
        }
        private void pictureBox34H_Click(object sender, EventArgs e)
        {
            pictureBox34H.Image = logic.SetPicture(logic.MatrixHard, 3, 6);
            OpenedCardAndScores(3, 6);
        }
        private void pictureBox35H_Click(object sender, EventArgs e)
        {
            pictureBox35H.Image = logic.SetPicture(logic.MatrixHard, 3, 7);
            OpenedCardAndScores(3, 7);
        }
        private void pictureBox36H_Click(object sender, EventArgs e)
        {
            pictureBox36H.Image = logic.SetPicture(logic.MatrixHard, 3, 8);
            OpenedCardAndScores(3, 8);
        }
        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}