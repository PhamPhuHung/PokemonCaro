using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonCaro
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            MainScreen frmMainScreen = new MainScreen();
            frmMainScreen.FormClosed += FrmMainScreen_FormClosed;

            if (ValidUser(tbCode.Text, tbPassword.Text))
            {
                this.Hide();

                frmMainScreen.UserCode = tbCode.Text;
                frmMainScreen.Show();
            }
            else
            {
                MessageBox.Show("Player Unexisted or Wrong Password", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidUser(string code, string password)
        {
            ExcelPackage playerFile = new ExcelPackage(new FileInfo(Constant.PLAYER_FILE_PATH));
            ExcelWorksheet playerWs = playerFile.Workbook.Worksheets[1];

            bool check = false;
            for (int i = 2; i <= playerWs.Dimension.End.Row; i++) 
            {
                if(code == playerWs.Cells[i,1].Value.ToString() && password == playerWs.Cells[i, 2].Value.ToString())
                {
                    check = true;
                    break;
                }   
            }
            return check;
        }
        private void FrmMainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            CreateNewAccount frmCreateNewAccount = new CreateNewAccount();
            frmCreateNewAccount.Show();
            frmCreateNewAccount.FormClosed += FrmCreateNewAccount_FormClosed;
            this.Hide();
        }

        private void FrmCreateNewAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            CreateNewAccount createNewAccount = sender as CreateNewAccount;
            this.Show();
            tbCode.Text = createNewAccount.Code.ToString();
            tbPassword.Text = "";
        }
    }
}
