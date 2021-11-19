using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace PokemonCaro
{
    public partial class PlayGame : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        Heuristic heuristicChoice;
        Minimax minimaxChoice;
        Player serverPlayer;
        Player clientPlayer;
        int playMode;

        public Player ServerPlayer { get => serverPlayer; set => serverPlayer = value; }
        public Player ClientPlayer { get => clientPlayer; set => clientPlayer = value; }
        public int PlayMode { get => playMode; set => playMode = value; }
        public Heuristic HeuristicChoice { get => heuristicChoice; set => heuristicChoice = value; }
        internal Minimax MinimaxChoice { get => minimaxChoice; set => minimaxChoice = value; }

        #endregion
        public PlayGame()
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();
        }

        private void PlayGame_Shown(object sender, EventArgs e)
        {
            ChessBoard = new ChessBoardManager(pbServer, pbClient, ServerPlayer, ClientPlayer, flpServer, flpClient, tbServer, tbClient, cbbTheme, pbChessBoard);
            ChessBoard.LoadPlayers();
            ChessBoard.DrawChessBoard();

            HeuristicChoice = new Heuristic(ChessBoard);
            MinimaxChoice = new Minimax(0, ChessBoard);

            pbCountDown.Maximum = Constant.PROGRESSBAR_MAX;
            pbCountDown.Step = Constant.PROGRESSBAR_STEP;
            tmCountDown.Interval = Constant.TIMER_INTERVAL;

            media.settings.setMode("loop", true);
            switch (ClientPlayer.Rank)
            {
                case int n when (n>=1 && n <=15):
                    media.URL = Constant.BACKGROUND_MEDIA_FOLDER_PATH + "\\OP2.mp3";
                    break;
                case int n when (n >= 21 && n <= 34):
                    media.URL = Constant.BACKGROUND_MEDIA_FOLDER_PATH + "\\OP5.mp3";
                    break;
                case int n when (n >= 41 && n <= 54):
                    media.URL = Constant.BACKGROUND_MEDIA_FOLDER_PATH + "\\OP6.mp3";
                    break;
                case int n when (n >= 61 && n <= 70):
                    media.URL = Constant.BACKGROUND_MEDIA_FOLDER_PATH + "\\OP11.mp3";
                    break;
                case int n when (n >= 81 && n <= 94):
                    media.URL = Constant.BACKGROUND_MEDIA_FOLDER_PATH + "\\OP12.mp3";
                    break;
                default:
                    media.URL = Constant.BACKGROUND_MEDIA_FOLDER_PATH + "\\OP1_Aim to Be a Pokemon Master.mp3";
                    break;
            }

            if(PlayMode == (int) Constant.PLAY_MODE.OnePlayer)
            {
                cbbTheme.SelectedIndex = ClientPlayer.Rank + 2;
                StartGame();
                
            }

            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;
            ChessBoard.EndedGame += ChessBoard_EndedGame;
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame(false);
        }

        private void ChessBoard_PlayerMarked(object sender, ChessBoardManager.ButtonClickEvent e)
        {
            pbCountDown.Value = 0;

            //Point computerChoice = HeuristicChoice.MaxScorePoint();
            Point computerChoice = MinimaxChoice.MinimaxSearch(0, ChessBoard);
            ChessBoard.ChessMatrix[computerChoice.X][computerChoice.Y].BackgroundImage = ChessBoard.ClientPlayer.Mark;

            if (ChessBoard.IsEndGame(ChessBoard.ChessMatrix[computerChoice.X][computerChoice.Y])) ChessBoard.EndGame();
            ChessBoard.ServerTurn = !ChessBoard.ServerTurn;
            ChessBoard.ChangePlayer();
        }

        private void cbbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ChessBoard!=null) ChessBoard.DisplayTheme();
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            cbbTheme.Enabled = false;
            startGameToolStripMenuItem.Enabled = false;
            pbChessBoard.Enabled = true;

            tmCountDown.Start();
            pbCountDown.Value = 0;
            media.Ctlcontrols.play();
        }
        private void EndGame(bool timeRunOut)
        {
            tmCountDown.Stop();

            ChessBoard.ChessBoard.Enabled = false;

            bool win = !ServerWin(timeRunOut);
            int rank = ChessBoard.ServerPlayer.Rank < ChessBoard.ClientPlayer.Rank ? ChessBoard.ClientPlayer.Rank : ChessBoard.ServerPlayer.Rank;
            if (win)
            {
                Result frmResult = new Result("CONGRATULATION!, YOU CAUGHT " + ChessBoard.ClientPlayer.Name.ToUpper(), ChessBoard.Pokeball, ChessBoard.ServerPlayer.Rank == 100 ? 100: rank-1);
                frmResult.Show();
                frmResult.FormClosed += FrmResult_FormClosed;
            }
            else
            {
                Result frmResult = new Result("YOU LOSE, TRY AGAIN NEXT TIME!", null, 0);
                frmResult.Show();
                frmResult.FormClosed += FrmResult_FormClosed;
            }
            
            RankIncrease(win, rank);

        }
        public void RankIncrease(bool win, int rank)
        {
            using (ExcelPackage ex = new ExcelPackage(new FileInfo(Constant.PLAYER_FILE_PATH)))
            {
                ExcelWorksheet ws = ex.Workbook.Worksheets[1];

                for (int i = 1; i <= ws.Dimension.Rows; i++)
                {
                    if(ws.Cells[i,1].Value.ToString() == ChessBoard.ServerPlayer.Code.ToString())
                    {
                        if (win)
                        {
                            ws.Cells[i, 6].Value = (Convert.ToInt32(ws.Cells[i, 6].Value) + 1);
                            ws.Cells[i, 8].Value = rank;
                        }
                        else
                        {
                            ws.Cells[i, 7].Value = (Convert.ToInt32(ws.Cells[i, 7].Value) + 1);
                        }
                    }
                }
                //Save files
                byte[] bin = ex.GetAsByteArray();
                File.WriteAllBytes(Constant.PLAYER_FILE_PATH, bin);
            }
        }

        private void FrmResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private bool ServerWin(bool timeRunOut)
        {
            if(timeRunOut)
            {
                if (flpServer.BackgroundImage != null) return true;
                else return false;
            }
            else
            {
                if (flpServer.BackgroundImage != null) return true;
                else return false;
            }
            //return (flpServer.BackgroundImage != null && timeRunOut == false) || (flpServer.BackgroundImage == null && timeRunOut == true);
        }
        private void NewGame()
        {
            ChessBoard.LoadPlayers();
            ChessBoard.DrawChessBoard();
            cbbTheme.Enabled = true;
            startGameToolStripMenuItem.Enabled = true;
        }
        private void btSpeaker_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChessBoard.Undo();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tmCountDown_Tick(object sender, EventArgs e)
        {
            pbCountDown.PerformStep();

            if (pbCountDown.Value >= pbCountDown.Maximum) EndGame(true);
        }

        private void btMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdMusicPlaylist = new OpenFileDialog()
            {
                Filter = "MP3 File (*.mp3)|*.mp3|WAV File (*.wav*)|*.wav*",
                FilterIndex = 1,
                RestoreDirectory = true,
                DefaultExt = "mp3",
                Multiselect = true
            };
            if(ofdMusicPlaylist.ShowDialog() == DialogResult.OK)
            {
                media.currentPlaylist.clear();
                
                foreach (var item in ofdMusicPlaylist.FileNames)
                {
                    IWMPMedia wmp = media.newMedia(item);
                    media.currentPlaylist.appendItem(wmp);
                }
            }
        }
    }
}
