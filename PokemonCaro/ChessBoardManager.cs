using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonCaro
{
    public class ChessBoardManager
    {
        #region Properties
        PictureBox serverProfile;
        PictureBox clientProfile;
        Player serverPlayer;
        Player clientPlayer;
        FlowLayoutPanel flpServer;
        FlowLayoutPanel flpClient;
        TextBox serverName;
        TextBox clientName;
        ComboBox cbbTheme;
        PictureBox chessBoard;
        List<Theme> themeList;
        bool serverTurn;
        Image imTurn;
        List<List<Button>> chessMatrix;

        public PictureBox ServerProfile { get => serverProfile; set => serverProfile = value; }
        public PictureBox ClientProfile { get => clientProfile; set => clientProfile = value; }
        internal Player ServerPlayer { get => serverPlayer; set => serverPlayer = value; }
        internal Player ClientPlayer { get => clientPlayer; set => clientPlayer = value; }
        public FlowLayoutPanel FlpServer { get => flpServer; set => flpServer = value; }
        public FlowLayoutPanel FlpClient { get => flpClient; set => flpClient = value; }
        public TextBox ServerName { get => serverName; set => serverName = value; }
        public TextBox ClientName { get => clientName; set => clientName = value; }
        public ComboBox CbbTheme { get => cbbTheme; set => cbbTheme = value; }
        public List<Theme> ThemeList { get => themeList; set => themeList = value; }
        public PictureBox ChessBoard { get => chessBoard; set => chessBoard = value; }
        public bool ServerTurn { get => serverTurn; set => serverTurn = value; }
        public Image ImTurn { get => imTurn; set => imTurn = value; }
        public List<List<Button>> ChessMatrix { get => chessMatrix; set => chessMatrix = value; }

        public string Pokeball { get; set; }

        private event EventHandler<ButtonClickEvent> playerMarked;
        public event EventHandler<ButtonClickEvent> PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }

        private Stack<PlayInfo> playTimeLine;
        #endregion

        #region Initialize
        public ChessBoardManager(PictureBox serverProfile, PictureBox clientProfile, Player serverPlayer, Player clientPlayer, FlowLayoutPanel flpServer, FlowLayoutPanel flpClient, TextBox serverName, TextBox clientName, ComboBox cbbTheme, PictureBox chessBoard)
        {
            this.ServerProfile = serverProfile;
            this.ClientProfile = clientProfile;
            this.ServerPlayer = serverPlayer;
            this.ClientPlayer = clientPlayer;
            this.FlpServer = flpServer;
            this.FlpClient = flpClient;
            this.ServerName = serverName;
            this.ClientName = clientName;
            this.CbbTheme = cbbTheme;
            this.ChessBoard = chessBoard;

            FlpServer.BackgroundImage = Image.FromFile(Constant.RESOURCES +"\\" + "Turn.jpg");
            LoadTheme();
            DisplayTheme();

            imTurn = Image.FromFile(Constant.RESOURCES + "\\Turn.jpg");
            ServerTurn = true;
        }


        #endregion

        #region Method

        /// <summary>
        /// Button click event, show mark, change player & create PlayerMarked event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bt_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (bt.BackgroundImage != null) return;

            bt.BackgroundImage = ServerTurn == true ? ServerPlayer.Mark : ClientPlayer.Mark;
            playTimeLine.Push(new PlayInfo(GetChessPoint(bt), serverTurn));

            if (playerMarked != null) playerMarked(this, new ButtonClickEvent(GetChessPoint(bt)));
            if (IsEndGame(bt)) EndGame();

            ServerTurn = !ServerTurn;
            ChangePlayer();


        }
        
        /// <summary>
        /// Load Players Information to the form
        /// </summary>
        public void LoadPlayers()
        {
            Random randomImg = new Random();
            int imgNum = randomImg.Next(3, ClientPlayer.ImageList.Count());

            int gen = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(Convert.ToDouble(ClientPlayer.Rank)/20.0)));
            ServerProfile.Image = Image.FromFile(Constant.PLAYER_FOLDER_PATH + "\\" + ServerPlayer.Code + ".jpg");
            ClientProfile.Image = Image.FromFile(Constant.CHARACTER_FOLDER_PATH +"\\" + gen.ToString() + "\\" + ClientPlayer.ImageList[imgNum]);
            Pokeball = Constant.CHARACTER_FOLDER_PATH + "\\" + gen.ToString() + "\\" + ClientPlayer.ImageList[1];
            ServerName.Text = ServerPlayer.Name;
            ClientName.Text = ClientPlayer.Name;
        }

        /// <summary>
        /// Draw Chess board & save button to matrix
        /// </summary>
        public void DrawChessBoard()
        {
            ChessBoard.Controls.Clear();
            ChessBoard.Enabled = false;
            ChessMatrix = new List<List<Button>>();
            playTimeLine = new Stack<PlayInfo>();

            for (int i = 0; i < Constant.CHESSBOARD_HEIGHT; i++)
            {
                ChessMatrix.Add(new List<Button>());
                for (int j = 0; j < Constant.CHESSBOARD_WIDTH; j++)
                {
                    Button bt = new Button()
                    {
                        Location = new Point(j * Constant.CHESS_WIDTH, i * Constant.CHESS_HEIGHT),
                        Size = new Size(Constant.CHESS_WIDTH, Constant.CHESS_HEIGHT),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        BackColor = Color.Transparent,
                        FlatStyle = FlatStyle.Popup,
                        Parent = ChessBoard,
                        Tag = i.ToString()
                    };
                    bt.Click += Bt_Click;
                    ChessBoard.Controls.Add(bt);
                    ChessMatrix[i].Add(bt);
                }
            }
        }

        /// <summary>
        /// Get button coordinate
        /// </summary>
        /// <param name="bt"></param>
        /// <returns></returns>
        private Point GetChessPoint(Button bt)
        {
            int x = Convert.ToInt32(bt.Tag);
            int y = ChessMatrix[x].IndexOf(bt);
                
            Point point = new Point(x,y);
            return point;
        }

        public bool IsEndGame(Button bt)
        {
            return IsEndHorizontal(bt) || IsEndVertical(bt) || IsEndPrimaryDiagonal(bt) || IsEndSubDiagonal(bt);
        }
        private bool IsEndHorizontal(Button bt)
        {
            Point point = GetChessPoint(bt);

            int countLeft = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (ChessMatrix[point.X][i].BackgroundImage != bt.BackgroundImage) break;

                countLeft++;
            }

            int countRight = 0;
            for (int i = point.Y + 1; i < Constant.CHESSBOARD_WIDTH; i++)
            {
                if (ChessMatrix[point.X][i].BackgroundImage != bt.BackgroundImage) break;

                countRight++;
            }

            return countLeft + countRight == 5;
        }
        private bool IsEndVertical(Button bt)
        {
            Point point = GetChessPoint(bt);

            int countTop = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (ChessMatrix[i][point.Y].BackgroundImage != bt.BackgroundImage) break;

                countTop++;
            }

            int countBottom = 0;
            for (int i = point.X + 1; i < Constant.CHESSBOARD_HEIGHT; i++)
            {
                if (ChessMatrix[i][point.Y].BackgroundImage != bt.BackgroundImage) break;

                countBottom++;
            }

            return countTop + countBottom == 5;
        }
        private bool IsEndPrimaryDiagonal(Button bt)
        {
            Point point = GetChessPoint(bt);

            int countLeft = 0;
            int a = 0;

            for (int i = point.X; i >= 0; i--)
            {
                if (point.Y + a >= Constant.CHESSBOARD_WIDTH) break;
                if (ChessMatrix[i][point.Y + a].BackgroundImage != bt.BackgroundImage) break;
                a++;
                countLeft++;
            }

            int countRight = 0;
            int b = 1;
            for (int i = point.X + 1; i < Constant.CHESSBOARD_HEIGHT; i++)
            {
                if (point.Y - b < 0) break;
                if (ChessMatrix[i][point.Y - b].BackgroundImage != bt.BackgroundImage) break;
                b++;
                countRight++;
            }

            return countLeft + countRight == 5;
        }
        private bool IsEndSubDiagonal(Button bt)
        {
            Point point = GetChessPoint(bt);

            int countLeft = 0;
            int a = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (point.Y - a < 0) break;
                if (ChessMatrix[i][point.Y - a].BackgroundImage != bt.BackgroundImage) break;
                a++;
                countLeft++;
            }

            int countRight = 0;
            int b = 1;
            for (int i = point.X + 1; i < Constant.CHESSBOARD_HEIGHT; i++)
            {
                if (point.Y + b >= Constant.CHESSBOARD_WIDTH) break;
                if (ChessMatrix[i][point.Y + b].BackgroundImage != bt.BackgroundImage) break;
                b++;
                countRight++;
            }

            return countLeft + countRight == 5;
        }

        /// <summary>
        /// Load Themes into combobox
        /// </summary>
        private void LoadTheme()
        {
            ExcelPackage themeFile = new ExcelPackage(new FileInfo(Constant.THEME_FOLDER_PATH + "\\Theme.xlsx"));
            ExcelWorksheet themeWs = themeFile.Workbook.Worksheets[1];
            List<string> themeNameList = new List<string>();
            ThemeList = new List<Theme>();
            for (int i = 2; i <= themeWs.Dimension.End.Row; i++)
            {
                Theme t = new Theme()
                {
                    Code = Convert.ToInt32(themeWs.Cells[i, 1].Value),
                    Name = themeWs.Cells[i, 2].Value.ToString(),
                    Background = themeWs.Cells[i, 3].Value.ToString(),
                    ServerMark = themeWs.Cells[i, 4].Value.ToString(),
                    ClientMark = themeWs.Cells[i, 5].Value.ToString()
                };
                themeNameList.Add(t.Name);
                ThemeList.Add(t);
            }
            CbbTheme.DataSource = themeNameList;

        }

        /// <summary>
        /// Display Theme
        /// </summary>
        public void DisplayTheme()
        {
            ChessBoard.Image = Image.FromFile(Constant.THEME_FOLDER_PATH + "\\" + ThemeList[CbbTheme.SelectedIndex].Background);
            ServerPlayer.Mark = Image.FromFile(Constant.THEME_FOLDER_PATH + "\\" + ThemeList[CbbTheme.SelectedIndex].ServerMark + ".png");
            ClientPlayer.Mark = Image.FromFile(Constant.THEME_FOLDER_PATH + "\\" + ThemeList[CbbTheme.SelectedIndex].ClientMark + ".png");
        }

        /// <summary>
        /// Create event EndedGame
        /// </summary>
        public void EndGame()
        {
            if (endedGame != null) endedGame(this, new EventArgs());
        }

        /// <summary>
        /// Change player
        /// </summary>
        public void ChangePlayer()
        {
            FlpServer.BackgroundImage = ServerTurn == true ? ImTurn : null;
            FlpClient.BackgroundImage = ServerTurn == true ? null : ImTurn;
        }

        public void Undo()
        {
            if (playTimeLine.Count <= 0) return;

            PlayInfo playInfo = playTimeLine.Pop();
            Button bt = ChessMatrix[playInfo.Point.X][playInfo.Point.Y];
            ServerTurn = playInfo.ServerTurn;

            bt.BackgroundImage = null;

            ChangePlayer();
        }
        #endregion

        #region Computer Character algorithm mark
        public void Rank1Mark()
        {

        }
        #endregion
        public class ButtonClickEvent : EventArgs
        {
            private Point clickedPoint;

            public Point ClickedPoint { get => clickedPoint; set => clickedPoint = value; }

            public ButtonClickEvent(Point point)
            {
                this.ClickedPoint = point;
            }
        }
    }
}
