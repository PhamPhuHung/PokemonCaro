using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaroDL
{
    
    public partial class option : Form
    {
        public int skin;
        public bool sound;
        public int size;

        public option()
        {

            InitializeComponent();
        }
       

        private void classic_CheckedChanged(object sender, EventArgs e)
        {
            skin = 1;
        }

        private void black_CheckedChanged(object sender, EventArgs e)
        {
            skin = 2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.classic.Checked = true;
            skin = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.GREEN.Checked = true;
            skin = 2;
        }

        public void set_confirguration(bool soundon, int sizeboard, int s,bool ruleGMK,int thinking)
        {
            timethinking.Value = thinking / 3;

            skin = s;
            if (skin == 1)
                this.classic.Checked = true;
            else
                if (skin == 2)
                    this.GREEN.Checked = true;
                else
                    this.wood.Checked = true;
            //---------------------------------
            sound=soundon;
            soundgame.Checked = soundon;
            //---------------------------------
            size=sizeboard;
            switch (size)
            {
                case 1: this.radioButton3.Checked = true;
                    break;
                case 2: this.radioButton4.Checked = true;
                    break;
                case 3: this.radioButton5.Checked = true;
                    break;
                case 4: this.radioButton6.Checked = true;
                    break;
                
            }
            //---------------------------------
            if (ruleGMK == true)
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            size = 1;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            size = 2;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            size = 3;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            size = 4;
        }
        
        private void soundgame_CheckedChanged(object sender, EventArgs e)
        {
            sound = soundgame.Checked;
       

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            wood.Checked = true;
            skin = 3;
        }

        private void wood_CheckedChanged(object sender, EventArgs e)
        {
            skin = 3;
        }

    }
}