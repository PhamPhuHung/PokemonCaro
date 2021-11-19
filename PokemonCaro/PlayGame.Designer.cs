namespace PokemonCaro
{
    partial class PlayGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayGame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.flpClient = new System.Windows.Forms.FlowLayoutPanel();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.flpServer = new System.Windows.Forms.FlowLayoutPanel();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.pbCountDown = new System.Windows.Forms.ProgressBar();
            this.cbbTheme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tmCountDown = new System.Windows.Forms.Timer(this.components);
            this.media = new AxWMPLib.AxWindowsMediaPlayer();
            this.btMusic = new System.Windows.Forms.Button();
            this.pbChessBoard = new System.Windows.Forms.PictureBox();
            this.flpChat = new System.Windows.Forms.FlowLayoutPanel();
            this.pbClient = new System.Windows.Forms.PictureBox();
            this.pbServer = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.flpClient.SuspendLayout();
            this.flpServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.media)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChessBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbServer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.startGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1180, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.startGameToolStripMenuItem.Text = "Start Game";
            this.startGameToolStripMenuItem.Click += new System.EventHandler(this.startGameToolStripMenuItem_Click);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(6, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(526, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Players Information";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flpClient
            // 
            this.flpClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpClient.Controls.Add(this.pbClient);
            this.flpClient.Controls.Add(this.tbClient);
            this.flpClient.Location = new System.Drawing.Point(272, 104);
            this.flpClient.Name = "flpClient";
            this.flpClient.Size = new System.Drawing.Size(260, 288);
            this.flpClient.TabIndex = 7;
            // 
            // tbClient
            // 
            this.tbClient.Location = new System.Drawing.Point(3, 264);
            this.tbClient.Name = "tbClient";
            this.tbClient.ReadOnly = true;
            this.tbClient.Size = new System.Drawing.Size(250, 20);
            this.tbClient.TabIndex = 4;
            this.tbClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flpServer
            // 
            this.flpServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpServer.Controls.Add(this.pbServer);
            this.flpServer.Controls.Add(this.tbServer);
            this.flpServer.Location = new System.Drawing.Point(6, 104);
            this.flpServer.Name = "flpServer";
            this.flpServer.Size = new System.Drawing.Size(260, 288);
            this.flpServer.TabIndex = 0;
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(3, 264);
            this.tbServer.Name = "tbServer";
            this.tbServer.ReadOnly = true;
            this.tbServer.Size = new System.Drawing.Size(250, 20);
            this.tbServer.TabIndex = 3;
            this.tbServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbCountDown
            // 
            this.pbCountDown.Location = new System.Drawing.Point(544, 27);
            this.pbCountDown.Maximum = 1000;
            this.pbCountDown.Name = "pbCountDown";
            this.pbCountDown.Size = new System.Drawing.Size(628, 13);
            this.pbCountDown.Step = 1;
            this.pbCountDown.TabIndex = 9;
            // 
            // cbbTheme
            // 
            this.cbbTheme.FormattingEnabled = true;
            this.cbbTheme.Location = new System.Drawing.Point(333, 51);
            this.cbbTheme.Name = "cbbTheme";
            this.cbbTheme.Size = new System.Drawing.Size(199, 21);
            this.cbbTheme.TabIndex = 10;
            this.cbbTheme.SelectedIndexChanged += new System.EventHandler(this.cbbTheme_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(333, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Theme";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmCountDown
            // 
            this.tmCountDown.Tick += new System.EventHandler(this.tmCountDown_Tick);
            // 
            // media
            // 
            this.media.Enabled = true;
            this.media.Location = new System.Drawing.Point(114, 27);
            this.media.Name = "media";
            this.media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("media.OcxState")));
            this.media.Size = new System.Drawing.Size(213, 45);
            this.media.TabIndex = 19;
            // 
            // btMusic
            // 
            this.btMusic.Location = new System.Drawing.Point(6, 27);
            this.btMusic.Name = "btMusic";
            this.btMusic.Size = new System.Drawing.Size(102, 45);
            this.btMusic.TabIndex = 20;
            this.btMusic.Text = "Choose Music Playlist";
            this.btMusic.UseVisualStyleBackColor = true;
            this.btMusic.Click += new System.EventHandler(this.btMusic_Click);
            // 
            // pbChessBoard
            // 
            this.pbChessBoard.BackColor = System.Drawing.Color.White;
            this.pbChessBoard.Enabled = false;
            this.pbChessBoard.Location = new System.Drawing.Point(544, 46);
            this.pbChessBoard.MaximumSize = new System.Drawing.Size(628, 628);
            this.pbChessBoard.Name = "pbChessBoard";
            this.pbChessBoard.Size = new System.Drawing.Size(628, 628);
            this.pbChessBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChessBoard.TabIndex = 17;
            this.pbChessBoard.TabStop = false;
            // 
            // flpChat
            // 
            this.flpChat.BackgroundImage = global::PokemonCaro.Properties.Resources.PokemonCaro;
            this.flpChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flpChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpChat.Location = new System.Drawing.Point(6, 398);
            this.flpChat.MaximumSize = new System.Drawing.Size(550, 298);
            this.flpChat.Name = "flpChat";
            this.flpChat.Size = new System.Drawing.Size(526, 276);
            this.flpChat.TabIndex = 8;
            // 
            // pbClient
            // 
            this.pbClient.BackColor = System.Drawing.Color.Transparent;
            this.pbClient.Location = new System.Drawing.Point(3, 3);
            this.pbClient.Name = "pbClient";
            this.pbClient.Size = new System.Drawing.Size(250, 255);
            this.pbClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClient.TabIndex = 1;
            this.pbClient.TabStop = false;
            // 
            // pbServer
            // 
            this.pbServer.BackColor = System.Drawing.Color.Transparent;
            this.pbServer.Location = new System.Drawing.Point(3, 3);
            this.pbServer.Name = "pbServer";
            this.pbServer.Size = new System.Drawing.Size(250, 255);
            this.pbServer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbServer.TabIndex = 0;
            this.pbServer.TabStop = false;
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 677);
            this.Controls.Add(this.btMusic);
            this.Controls.Add(this.media);
            this.Controls.Add(this.pbChessBoard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbTheme);
            this.Controls.Add(this.pbCountDown);
            this.Controls.Add(this.flpChat);
            this.Controls.Add(this.flpClient);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.flpServer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1200, 720);
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "PlayGame";
            this.Text = "PlayGame";
            this.Shown += new System.EventHandler(this.PlayGame_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flpClient.ResumeLayout(false);
            this.flpClient.PerformLayout();
            this.flpServer.ResumeLayout(false);
            this.flpServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.media)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChessBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbServer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpServer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbServer;
        private System.Windows.Forms.PictureBox pbClient;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.FlowLayoutPanel flpClient;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.FlowLayoutPanel flpChat;
        private System.Windows.Forms.ProgressBar pbCountDown;
        private System.Windows.Forms.ComboBox cbbTheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbChessBoard;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.Timer tmCountDown;
        private AxWMPLib.AxWindowsMediaPlayer media;
        private System.Windows.Forms.Button btMusic;
    }
}