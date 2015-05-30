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
        public int HardCards { get; set; }

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

        private int[,] matrixHard = {
                                     {0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0},
                                     {0,0,0,0,0,0,0,0,0}
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

        public int[,] MatrixHard
        {
            get
            {
                return this.matrixHard;
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
            this.HardCards = (this.MatrixHard.GetLength(0) * this.MatrixHard.GetLength(1)) / 2;
            choise = index;
            if (index == 1)
            {
                Randomize(matrixEasy);
            }
            if (index == 2)
            {
                Randomize(matrixNormal);
            }
            if (index == 3)
            {
                Randomize(matrixHard);
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
            if (matrix[i, j] == 14)
            {
                return global::CardGame.Properties.Resources._2;
            }
            if (matrix[i, j] == 15)
            {
                return global::CardGame.Properties.Resources._3;
            }
            if (matrix[i, j] == 16)
            {
                return global::CardGame.Properties.Resources._4;
            }
            if (matrix[i, j] == 17)
            {
                return global::CardGame.Properties.Resources._5;
            }
            if (matrix[i, j] == 18)
            {
                return global::CardGame.Properties.Resources._6;
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
                if (choise == 3)
                {
                    if (this.MatrixHard[list[0], list[1]] == this.MatrixHard[list[2], list[3]])
                    {
                        --HardCards;
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

        public void EndGame(int minutes, int seconds, int milliseconds, int score)
        {
            InserNameForRecord insertName = new InserNameForRecord();
            string time = minutes.ToString() + ":" + seconds.ToString() + "," + milliseconds.ToString();
            insertName.ShowDataInDialog(score, time);
            insertName.ShowDialog();
        }
    }
}