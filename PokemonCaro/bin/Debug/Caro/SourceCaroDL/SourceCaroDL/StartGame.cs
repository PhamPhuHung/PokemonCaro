using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaroDL
{
    public partial class StartGame : Form
    {
        public StartGame()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}