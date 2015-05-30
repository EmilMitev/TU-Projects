using CardGame.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame.View
{
    public partial class TopFive : Form
    {
        public TopFive(List<Result> list)
        {
            InitializeComponent();

            panelTop5.Visible = true;
            labelTop1.Text = list[0].Name;
            labelTop2.Text = list[1].Name;
            labelTop3.Text = list[2].Name;
            labelTop4.Text = list[3].Name;
            labelTop5.Text = list[4].Name;
            labelTopTime1.Text = list[0].Time.Second + ":" + list[0].Time.Millisecond;
            labelTopTime2.Text = list[1].Time.Second + ":" + list[1].Time.Millisecond;
            labelTopTime3.Text = list[2].Time.Second + ":" + list[2].Time.Millisecond;
            labelTopTime4.Text = list[3].Time.Second + ":" + list[3].Time.Millisecond;
            labelTopTime5.Text = list[4].Time.Second + ":" + list[4].Time.Millisecond;

        }
    }
}
