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
    public partial class CreateNewAccount : Form
    {
        ExcelPackage playerFile;
        ExcelWorksheet playerWs;
        public int Code { get; set; }
        enum fillCheck
        {
            Correct = 0,
            InvalidCode = 1,
            InvalidPassword = 2,
            InvalidName = 3
        };

        public CreateNewAccount()
        {
            InitializeComponent();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            switch (AllCorrectFill())
            {
                case fillCheck.Correct:
                    SaveUser();
                    MessageBox.Show("Create new account succeeded. Log in to enjoy", "CreateNewAccount", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
                case fillCheck.InvalidCode:
                    MessageBox.Show("Code must be a 6-numeral number and not duplicated with other users", "Invalid code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case fillCheck.InvalidPassword:
                    MessageBox.Show("Password must be a 4-to-6-numeral number", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case fillCheck.InvalidName:
                    MessageBox.Show("Please fill in name", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }

        private void CreateNewAccount_Shown(object sender, EventArgs e)
        {
            cbbGen.DataSource = Constant.GENDER;
            cbbGen.SelectedIndex = 0;

            playerFile = new ExcelPackage(new FileInfo(Constant.PLAYER_FILE_PATH));
            playerWs = playerFile.Workbook.Worksheets[1];
        }

        private void pbPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdPicture = new OpenFileDialog()
            {
                Filter = ".JPG (*.jpg)|*.jpg|.PNG (*.png)|*.png",
                FilterIndex = 1,
                RestoreDirectory = true,
                DefaultExt = "jpg",
                Title = "Change profile image"
            };
            if (ofdPicture.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofdPicture.FileName);
                Bitmap bm = new Bitmap(img);
                img.Dispose();
                pbPicture.Image = bm;
                pbPicture.ImageLocation = ofdPicture.FileName;
            }

        }
        private fillCheck AllCorrectFill()
        {
            fillCheck check = fillCheck.Correct;
            if (!ValidCode()) check = fillCheck.InvalidCode;
            else if (!ValidPassword()) check = fillCheck.InvalidPassword;
            else if (!NameFilled()) check = fillCheck.InvalidName;
            return check;
        }
        private bool ValidCode()
        {
            bool check = true;
            if (Int32.TryParse(tbCode.Text, out int code))
            {
                if (code > 100000 && code < 999999)
                {
                    for (int i = 2; i <= playerWs.Dimension.End.Row; i++)
                    {
                        if (tbCode.Text == playerWs.Cells[i, 1].Value.ToString())
                        {
                            check = false;
                            break;
                        }
                    }
                }
                else check = false;
            }
            else check = false;
            
            return check;
        }
        private bool ValidPassword()
        {
            bool check = true;
            if (Int32.TryParse(tbPassword.Text, out int code))
            {
                if (code < 1000 || code > 999999)
                {
                    check = false;
                }
            }
            else check = false;

            return check;
        }
        private bool NameFilled()
        {
            bool check = false;
            if (!string.IsNullOrWhiteSpace(tbName.Text)) check = true;

            return check;
        }

        private void SaveUser()
        {
            try
            {
                pbPicture.Image.Save(Constant.PLAYER_FOLDER_PATH + "\\" + tbCode.Text + ".jpg");

                int lastRow = playerWs.Dimension.End.Row + 1;
                playerWs.Cells[lastRow, 1].Value = tbCode.Text;
                playerWs.Cells[lastRow, 2].Value = tbPassword.Text;
                playerWs.Cells[lastRow, 3].Value = tbName.Text;
                playerWs.Cells[lastRow, 5].Value = cbbGen.SelectedIndex;
                playerWs.Cells[lastRow, 6].Value = 0;
                playerWs.Cells[lastRow, 7].Value = 0;
                playerWs.Cells[lastRow, 8].Value = 0;
                playerWs.Cells[lastRow, 9].Value = tbCode.Text + ".jpg";

                //List<int> playerArrangeList = PlayerArrange();
                //int row = playerWs.Dimension.End.Row;
                //for (int i = 0; i < playerArrangeList.Count(); i++)
                //{
                //    row = row + 1;
                //    playerWs.Cells[row, 1].Value = playerWs.Cells[playerArrangeList[i], 1].Value;
                //    playerWs.Cells[row, 2].Value = playerWs.Cells[playerArrangeList[i], 2].Value;
                //    playerWs.Cells[row, 3].Value = playerWs.Cells[playerArrangeList[i], 3].Value;
                //    playerWs.Cells[row, 5].Value = playerWs.Cells[playerArrangeList[i], 5].Value;
                //    playerWs.Cells[row, 6].Value = playerWs.Cells[playerArrangeList[i], 6].Value;
                //    playerWs.Cells[row, 7].Value = playerWs.Cells[playerArrangeList[i], 7].Value;
                //    playerWs.Cells[row, 8].Value = playerWs.Cells[playerArrangeList[i], 8].Value;
                //    playerWs.Cells[row, 9].Value = playerWs.Cells[playerArrangeList[i], 9].Value;
                //}
                //playerWs.DeleteRow(2, playerArrangeList.Count());

                byte[] bin = playerFile.GetAsByteArray();
                File.WriteAllBytes(Constant.PLAYER_FILE_PATH, bin);
                Code = Convert.ToInt32(tbCode.Text);
            }
            catch { }

        }

        private List<int> PlayerArrange()
        {
            List<int> list = new List<int>();
            List<int> arrangeList = new List<int>();
            List<int> indexList = new List<int>();

            for (int j = 2; j <= playerWs.Dimension.End.Row; j++)
            {
                list.Add(Convert.ToInt32(playerWs.Cells[j, 1].Value));
                arrangeList.Add(Convert.ToInt32(playerWs.Cells[j, 1].Value));
            }
            arrangeList.Sort();

            foreach (var item in arrangeList)
            {
                int minIndex = list.IndexOf(item) + 2;
                indexList.Add(minIndex);
            }
            return indexList;

        }

    }
}
