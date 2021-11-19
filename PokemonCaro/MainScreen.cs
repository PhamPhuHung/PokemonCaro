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
    public partial class MainScreen : Form
    {
        #region Properties
        private string userCode;
        private List<List<Button>> characterList;
        private Player userPlayer;
        private List<string> playerCodeList;


        public string UserCode { get => userCode; set => userCode = value; }
        public List<List<Button>> CharacterList { get => characterList; set => characterList = value; }
        internal Player UserPlayer { get => userPlayer; set => userPlayer = value; }
        public List<string> PlayerCodeList { get => playerCodeList; set => playerCodeList = value; }
        #endregion

        #region Initialize
        ExcelPackage playerFile;
        ExcelWorksheet playerWs;
        ExcelPackage characterFile;
        List<ExcelWorksheet> characterWs;
        int currentPlayer;
        int currentCharacterImage = 2;
        int currentGen = 0;
        Player character;


        private void ReadFile()
        {
            playerFile = new ExcelPackage(new FileInfo(Constant.PLAYER_FILE_PATH));
            playerWs = playerFile.Workbook.Worksheets[1];

            characterFile = new ExcelPackage(new FileInfo(Constant.CHARACTER_FILE_PATH));
            characterWs = new List<ExcelWorksheet>();
            for (int i = 1; i <= 5; i++)
            {
                characterWs.Add(characterFile.Workbook.Worksheets[i]);
            }
        }
        #endregion

        #region Method

        public MainScreen()
        {
            InitializeComponent();
            
        }

        private void MainScreen_Shown(object sender, EventArgs e)
        {

            Loading();


        }
        public void Loading()
        {
            ReadFile();
            UserPlayer = LoadPlayerInfo(UserCode, playerWs);
            PlayerCodeList = LoadPlayerCodeList(UserCode, playerWs);

            ShowPlayerInfo(UserPlayer, true, false);

            LoadComputerCharater(UserPlayer.Rank, characterWs);
            ShowComputerCharacter(currentGen);

            currentPlayer = 0;

            this.Size = this.MaximumSize;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            btSaveChanges.Enabled = true;
        }

        private void btSaveChanges_Click(object sender, EventArgs e)
        {
            if(AcceptedCode(tbCode.Text, PlayerCodeList) && AcceptedPassWord(Convert.ToInt32(tbPassword.Text)))
            {
                pbUser.ImageLocation = Constant.PLAYER_FOLDER_PATH + "\\" + tbCode.Text + ".jpg";
                File.Delete(Constant.PLAYER_FOLDER_PATH + "\\" + playerWs.Cells[UserPlayer.Row, 1].Value.ToString() + ".jpg");
                pbUser.Image.Save(Constant.PLAYER_FOLDER_PATH + "\\" + tbCode.Text + ".jpg");

                playerWs.Cells[UserPlayer.Row, 1].Value = tbCode.Text;
                playerWs.Cells[UserPlayer.Row, 2].Value = tbPassword.Text;
                playerWs.Cells[UserPlayer.Row, 3].Value = tbName.Text;
                playerWs.Cells[UserPlayer.Row, 4].Value = cbbGender.SelectedIndex;

                File.WriteAllBytes(Constant.PLAYER_FILE_PATH, playerFile.GetAsByteArray());
                ReadFile();

                btSaveChanges.Enabled = false;
            }
            else
            {
                string message = null;
                if (!AcceptedCode(tbCode.Text, PlayerCodeList)) message += "Invalid or Existed Code\n";
                if (!AcceptedPassWord(Convert.ToInt32(tbPassword.Text))) message += "Invalid Password - Password must have 4-6 number";
                MessageBox.Show(message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            if(!btLoad.Enabled)
            {
                currentPlayer = LeftUser(currentPlayer);
                ShowPlayerInfo(LoadPlayerInfo(PlayerCodeList[currentPlayer], playerWs), false, false);
            }
            else
            {
                currentCharacterImage--;
                if (currentCharacterImage < 2)
                {
                    currentCharacterImage = 2;
                    return;
                }
                pbCUser.ImageLocation = Constant.CHARACTER_FOLDER_PATH + "\\" + ((character.Rank - 1) / 20 + 1).ToString() + "\\" + character.ImageList[currentCharacterImage];
            }

        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            ShowPlayerInfo(LoadPlayerInfo(PlayerCodeList[currentPlayer], playerWs), false, false);

            btPlay.Enabled = false;

            btLoad.Enabled = false;
            btLeft.Enabled = true;
            btRight.Enabled = true;
            tbPokedex.Text = "OTHER PLAYER";
        }

        private void btRight_Click(object sender, EventArgs e)
        {
            if(!btLoad.Enabled)
            {
                currentPlayer = RightUser(currentPlayer, PlayerCodeList.Count());
                ShowPlayerInfo(LoadPlayerInfo(PlayerCodeList[currentPlayer], playerWs), false, false);
            }
            else
            {
                currentCharacterImage++;
                if (currentCharacterImage >= character.ImageList.Count())
                {
                    currentCharacterImage = character.ImageList.Count() - 1;
                    return;
                }
                pbCUser.ImageLocation = Constant.CHARACTER_FOLDER_PATH + "\\" + ((character.Rank - 1) / 20 + 1).ToString() + "\\" + character.ImageList[currentCharacterImage];
            }

        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            PlayGame frmPlayGame = new PlayGame();
            frmPlayGame.Show();
            frmPlayGame.FormClosed += FrmPlayGame_FormClosed;

            frmPlayGame.ServerPlayer = UserPlayer;
            frmPlayGame.ClientPlayer = character;
            frmPlayGame.PlayMode = (int)Constant.PLAY_MODE.OnePlayer;

            this.Hide();
        }

        private void btLeftGen_Click(object sender, EventArgs e)
        {
            currentGen--;
            if (currentGen < 0)
            {
                currentGen = 0;
                return;
            }
            ShowComputerCharacter(currentGen);
        }

        private void btRightGen_Click(object sender, EventArgs e)
        {
            currentGen++;
            if (currentGen >= CharacterList.Count())
            {
                currentGen = CharacterList.Count() - 1;
                if(currentGen < 4) MessageBox.Show("Next Gen is still locked", "Generation Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ShowComputerCharacter(currentGen);
        }

        private void FrmPlayGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            Loading();
        }

        private void btConnectLan_Click(object sender, EventArgs e)
        {

        }

        private void Bt_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;

            currentCharacterImage = 2;

            character = LoadPlayerInfo(bt.Text, characterWs[Convert.ToInt32(bt.Tag)]);
            ShowPlayerInfo(character, false, true);
            btPlay.Enabled = true;
            tbPokedex.Text = "POKEDEX";
            btLoad.Enabled = true;
            btLeft.Enabled = true;
            btRight.Enabled = true;
        }

        private void pbUser_Click(object sender, EventArgs e)
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
                pbUser.Image = bm;
                pbUser.ImageLocation = ofdPicture.FileName;
            }
        }

        /// <summary>
        /// Get all player information
        /// </summary>
        /// <param name="code"></param>
        /// <param name="infoWs"></param>
        /// <returns></returns>
        private Player LoadPlayerInfo(string code, ExcelWorksheet infoWs)
        {
            Player player = null;
            for (int i = 2; i <= infoWs.Dimension.End.Row; i++)
            {
                if (code == infoWs.Cells[i, 1].Value.ToString())
                {
                    List<string> imageList = new List<string>();
                    for (int j = 9; j <= 16   ; j++)
                    {
                        try
                        {
                            imageList.Add(infoWs.Cells[i, j].Value.ToString());
                        }
                        catch
                        {
                            break;
                        }
                    } 
                    player = new Player(Convert.ToInt32(infoWs.Cells[i, 1].Value),
                                                     Convert.ToInt32(infoWs.Cells[i, 2].Value),
                                                      infoWs.Cells[i, 3].Value.ToString(),
                                                      infoWs.Cells[i,4]?.Value?.ToString(),
                                                      Convert.ToInt32(infoWs.Cells[i, 5].Value),
                                                      infoWs.Cells[i, 6]?.Value?.ToString(),
                                                      infoWs.Cells[i, 7]?.Value?.ToString(),
                                                      Convert.ToInt32(infoWs.Cells[i, 8].Value),
                                                      i,
                                                      imageList,
                                                      null);
                    break;
                }
            }
            return player;
        }
        
        /// <summary>
        /// Get code of all players except  user
        /// </summary>
        /// <param name="userCode"></param>
        /// <param name="infoWs"></param>
        /// <returns></returns>
        private List<string> LoadPlayerCodeList(string userCode, ExcelWorksheet infoWs)
        {
            List<string> playerCodeList = new List<string>();
            for (int i = 2; i <= infoWs.Dimension.End.Row; i++)
            {
                if (userCode != infoWs.Cells[i, 1].Value.ToString())
                {
                    playerCodeList.Add(infoWs.Cells[i, 1].Value.ToString());
                }
            }
            return playerCodeList;
        }

        /// <summary>
        ///  Load Player information from excel file
        /// </summary>
        /// <param name="player"></param>
        /// <param name="isUser"></param>
        private void ShowPlayerInfo(Player player, bool isUser, bool isCharacter)
        {
            if (isUser)
            {
                tbCode.Text = player.Code.ToString();
                tbPassword.Text = player.Password.ToString();
                tbName.Text = player.Name.ToString();
                tbDescription.Text = player.Description;
                cbbGender.DataSource = Constant.GENDER;
                cbbGender.SelectedIndex = player.Gender;
                tbWonGames.Text = player.WonGames;
                tbLoseGames.Text = player.LoseGames;

                Image img = Image.FromFile(Constant.PLAYER_FOLDER_PATH + "\\" + player.ImageList[0]);
                Bitmap bm = new Bitmap(img);
                img.Dispose();
                pbUser.Image = bm;

                pbUser.ImageLocation = Constant.PLAYER_FOLDER_PATH + "\\" + player.ImageList[0];
                tbRank.Text = "Rank " + player.Rank;
            }
            else
            {
                tbCCode.Text = player.Code.ToString();
                tbCPassword.Text = "****";
                tbCName.Text = player.Name.ToString();
                tbCDescription.Text = player.Description;
                tbCGender.Text = Constant.GENDER[player.Gender];
                tbCWonGames.Text = player.WonGames;
                tbCLoseGames.Text = player.LoseGames;

                if(isCharacter)
                {
                    pbCUser.ImageLocation = Constant.CHARACTER_FOLDER_PATH + "\\" + ((player.Rank - 1) / 20 + 1).ToString() + "\\" + player.ImageList[currentCharacterImage];
                }
                else
                {
                    pbCUser.ImageLocation = Constant.PLAYER_FOLDER_PATH + "\\" + player.ImageList[0];
                }
                tbCRank.Text = "Rank " + player.Rank;
            }
        }
        
        /// <summary>
        /// Search for the Player in the left of the User
        /// </summary>
        private int LeftUser(int searchPlayer)
        {
            return searchPlayer = searchPlayer >= 1 ? (searchPlayer - 1) : (searchPlayer);
        }

        /// <summary>
        /// Search for the Player in the right of the User
        /// </summary>
        private int RightUser(int searchPlayer, int totalPlayer)
        {
            return searchPlayer = searchPlayer < (totalPlayer - 1) ? (searchPlayer + 1) : (searchPlayer);
        }

        /// <summary>
        /// Load computer character 
        /// </summary>
        /// <param name="userRank"></param>
        private void LoadComputerCharater(int userRank, List<ExcelWorksheet> characterWs)
        {
            CharacterList = new List<List<Button>>();

            for (int i = 0; i < userRank/20 + 1; i++)
            {
                if (i == 5) break;
                CharacterList.Add(new List<Button>());
                for (int j = 0; j < Constant.POKEMON_QUANTITY_PER_GENERATION; j++)
                {
                    Button bt = new Button()
                    {
                        Size = new Size(Width = Constant.CHARACTER_WIDTH, Height = Constant.CHARACTER_HEIGHT),
                        BackgroundImageLayout = ImageLayout.Zoom,
                        Text = (j+1).ToString(),
                        Tag = i,
                        Font = new Font("Wide Latin", 12f),
                        ForeColor = Color.Red
                    };
                    if (j + i * 20 <= userRank) 
                    {
                        bt.BackgroundImage = Image.FromFile(Constant.CHARACTER_FOLDER_PATH + "\\" + (i + 1).ToString() + "\\" + characterWs[i].Cells[j + 2, 9].Value.ToString());

                        if (j + i * 20 < userRank) bt.AccessibleDescription = Constant.CHARACTER_FOLDER_PATH + "\\" + (i + 1).ToString() + "\\" + characterWs[i].Cells[j + 2, 10].Value.ToString();
                        else bt.AccessibleDescription = Constant.CHARACTER_FOLDER_PATH + "\\Pokeball.jpg";

                        bt.Enabled = true;
                    }
                    else
                    {
                        bt.BackgroundImage = Image.FromFile(Constant.CHARACTER_FOLDER_PATH + "\\Lock.jpg");
                        bt.Enabled = false;
                    }
                    bt.Click += Bt_Click;
                    CharacterList[i].Add(bt);
                }
            }
        }

        private void ShowComputerCharacter(int genNumber)
        {
            flpCharacter.Controls.Clear();
            flpCharacter.Controls.AddRange(CharacterList[genNumber].ToArray());
            lbGen.Text = Constant.GENERATION[genNumber];
        }

        /// <summary>
        /// Check if Code is valid (1000-999999) && not the same with other player
        /// </summary>
        /// <param name="code"></param>
        /// <param name="playerCodeList"></param>
        /// <returns></returns>
        private bool AcceptedCode(string code, List<string> playerCodeList)
        {
            bool check = true;
            int x = Convert.ToInt32(code);
            if (x < 1000 || x > 999999) check = false;
            for (int i = 0; i < playerCodeList.Count(); i++)
            {
                if (code == playerCodeList[i])
                {
                    check = false;
                    break;
                }
            }
            return check;
        }

        /// <summary>
        /// Check if password is valid (4-6 numbers)
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool AcceptedPassWord(int password)
        {
            bool check = false;
            if (password >= 1000 && password <= 999999) check = true;
            return check;
        }

       
        #endregion

        private void btCollection_Click(object sender, EventArgs e)
        {
            PokemonCollection frmPokemonCollection = new PokemonCollection
            {
                PokeballList = CharacterList
            };

            frmPokemonCollection.Show();
        }

    }
}
