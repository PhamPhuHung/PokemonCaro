using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaroDL
{
    public partial class Chess : Form
    {
        public Chess()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
        }
    }
}