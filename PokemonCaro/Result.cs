using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonCaro
{
    public partial class Result : Form
    {
        public Result(string resultString, string resultImage, int currentRank)
        {
            InitializeComponent();
            lbResult.Text = resultString;
            if(resultImage!=null) pbResult.BackgroundImage = Image.FromFile(resultImage);
            if (currentRank == 0 || currentRank == 100) lbRank.Visible = false;
            else lbRank.Text = "Rank " + currentRank.ToString() + " -> Rank " + (currentRank + 1).ToString();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
