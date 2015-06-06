using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using CardGame.Data;
using CardGame.View;
using System.Globalization;

namespace CardGame.Logic
{
    public class GameLogic
    {
        List<Result> list;

        private const int MaxFlipCard = 2;
        private int flipCard = 0;
        private int choise;

        public int EasyCards { get; set; }
        public int NormalCards { get; set; }

        public int[] mass = new int[2];

        #region matrix
        private int[,] matrixEasy = {
                                     {0,0,0,0},
                                     {0,0,0,0},
                                     {0,0,0,0}
                                    };

        private int[,] matrixNormal = {
                                      {0,0,0,0,0,0},
                                      {0,0,0,0,0,0},
                                      {0,0,0,0,0,0}
                                     };

        public int[,] MatrixEasy
        {
            get
            {
                return this.matrixEasy;
            }
        }

        public int[,] MatrixNormal
        {
            get
            {
                return this.matrixNormal;
            }
        }

        #endregion

        public int FlipCard
        {
            get
            {
                return this.flipCard;
            }
            set
            {
                this.flipCard = value;
            }
        }

        public GameLogic(int index)
        {
            this.EasyCards = (this.MatrixEasy.GetLength(0) * this.MatrixEasy.GetLength(1)) / 2;
            this.NormalCards = (this.MatrixNormal.GetLength(0) * this.MatrixNormal.GetLength(1)) / 2;
            choise = index;
            if (index == 1)
            {
                Randomize(matrixEasy);
            }
            if (index == 2)
            {
                Randomize(matrixNormal);
            }
            list = new List<Result>();
        }

        public GameLogic()
        {
            list = new List<Result>();
        }

        private void Randomize(int[,] matrix)
        {
            Random random = new Random();
            int len = (matrix.GetLength(0) * matrix.GetLength(1)) / 2;
            int row = 0;
            int col = 0;

            while (len != 0)
            {
                for (int j = 0; j < 2; j++)
                {
                    while (true)
                    {
                        row = random.Next(matrix.GetLength(0));
                        col = random.Next(matrix.GetLength(1));
                        if (matrix[row, col] == 0)
                        {
                            matrix[row, col] = len;
                            break;
                        }
                    }
                }
                --len;
            }
        }

        public Bitmap SetPicture(int[,] matrix, int i, int j)
        {
            if (matrix[i, j] == 1)
            {
                return global::CardGame.Properties.Resources._2;
            }
            if (matrix[i, j] == 2)
            {
                return global::CardGame.Properties.Resources._3;
            }
            if (matrix[i, j] == 3)
            {
                return global::CardGame.Properties.Resources._4;
            }
            if (matrix[i, j] == 4)
            {
                return global::CardGame.Properties.Resources._5;
            }
            if (matrix[i, j] == 5)
            {
                return global::CardGame.Properties.Resources._6;
            }
            if (matrix[i, j] == 6)
            {
                return global::CardGame.Properties.Resources._7;
            }
            if (matrix[i, j] == 7)
            {
                return global::CardGame.Properties.Resources._8;
            }
            if (matrix[i, j] == 8)
            {
                return global::CardGame.Properties.Resources._9;
            }
            if (matrix[i, j] == 9)
            {
                return global::CardGame.Properties.Resources._10;
            }
            if (matrix[i, j] == 10)
            {
                return global::CardGame.Properties.Resources.jack;
            }
            if (matrix[i, j] == 11)
            {
                return global::CardGame.Properties.Resources.queen;
            }
            if (matrix[i, j] == 12)
            {
                return global::CardGame.Properties.Resources.king;
            }
            if (matrix[i, j] == 13)
            {
                return global::CardGame.Properties.Resources.ace;
            }
            return global::CardGame.Properties.Resources.CardBack;
        }

        public bool Logic(List<int> list)
        {
            if (!(list[0] == list[2] && list[1] == list[3]))
            {
                if (choise == 1)
                {
                    if (this.MatrixEasy[list[0], list[1]] == this.MatrixEasy[list[2], list[3]])
                    {
                        --EasyCards;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                if (choise == 2)
                {
                    if (this.MatrixNormal[list[0], list[1]] == this.MatrixNormal[list[2], list[3]])
                    {
                        --NormalCards;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public bool IsMaxFlipCard()
        {
            if (this.FlipCard == MaxFlipCard)
            {
                this.FlipCard = 0;
                return true;
            }
            else
            {
                ++this.FlipCard;
                return false;
            }
        }

        public void InsertNewRecord(string name, string score, string time)
        {
            DataInfo data = new DataInfo();
            DateTime gameTime = DateTime.ParseExact(time, "m:ss,fff", CultureInfo.InvariantCulture);
            data.AddNewRecord(name, int.Parse(score), gameTime);
        }

        public List<Result> GetRecords()
        {
            return DataInfo.GetAllRecords();
        }

        public int PBNumber(string name)
        {
            if (name == "pictureBox1E") { mass[0] = 0; mass[1] = 0; return 0; }
            if (name == "pictureBox2E") { mass[0] = 0; mass[1] = 1; return 1; }
            if (name == "pictureBox3E") { mass[0] = 0; mass[1] = 2; return 2; }
            if (name == "pictureBox4E") { mass[0] = 0; mass[1] = 3; return 3; }
            if (name == "pictureBox5E") { mass[0] = 1; mass[1] = 0; return 4; }
            if (name == "pictureBox6E") { mass[0] = 1; mass[1] = 1; return 5; }
            if (name == "pictureBox7E") { mass[0] = 1; mass[1] = 2; return 6; }
            if (name == "pictureBox8E") { mass[0] = 1; mass[1] = 3; return 7; }
            if (name == "pictureBox9E") { mass[0] = 2; mass[1] = 0; return 8; }
            if (name == "pictureBox10E") { mass[0] = 2; mass[1] = 1; return 9; }
            if (name == "pictureBox11E") { mass[0] = 2; mass[1] = 2; return 10; }
            if (name == "pictureBox12E") { mass[0] = 2; mass[1] = 3; return 11; }
            if (name == "pictureBox1N") { mass[0] = 0; mass[1] = 0; return 0; }
            if (name == "pictureBox2N") { mass[0] = 0; mass[1] = 1; return 1; }
            if (name == "pictureBox3N") { mass[0] = 0; mass[1] = 2; return 2; }
            if (name == "pictureBox4N") { mass[0] = 0; mass[1] = 3; return 3; }
            if (name == "pictureBox5N") { mass[0] = 0; mass[1] = 4; return 4; }
            if (name == "pictureBox6N") { mass[0] = 0; mass[1] = 5; return 5; }
            if (name == "pictureBox7N") { mass[0] = 1; mass[1] = 0; return 6; }
            if (name == "pictureBox8N") { mass[0] = 1; mass[1] = 1; return 7; }
            if (name == "pictureBox9N") { mass[0] = 1; mass[1] = 2; return 8; }
            if (name == "pictureBox10N") { mass[0] = 1; mass[1] = 3; return 9; }
            if (name == "pictureBox11N") { mass[0] = 1; mass[1] = 4; return 10; }
            if (name == "pictureBox12N") { mass[0] = 1; mass[1] = 5; return 11; }
            if (name == "pictureBox13N") { mass[0] = 2; mass[1] = 0; return 12; }
            if (name == "pictureBox14N") { mass[0] = 2; mass[1] = 1; return 13; }
            if (name == "pictureBox15N") { mass[0] = 2; mass[1] = 2; return 14; }
            if (name == "pictureBox16N") { mass[0] = 2; mass[1] = 3; return 15; }
            if (name == "pictureBox17N") { mass[0] = 2; mass[1] = 4; return 16; }
            if (name == "pictureBox18N") { mass[0] = 2; mass[1] = 5; return 17; }
            return 0;

        }



        public void EndGame(int minutes, int seconds, int milliseconds, int score)
        {
            InserNameForRecord insertName = new InserNameForRecord();
            string time = minutes.ToString() + ":" + seconds.ToString() + "," + milliseconds.ToString();
            insertName.ShowDataInDialog(score, time);
            insertName.ShowDialog();
        }
    }
}