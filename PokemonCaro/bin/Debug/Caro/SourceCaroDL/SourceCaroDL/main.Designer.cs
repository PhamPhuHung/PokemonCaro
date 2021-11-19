namespace CaroDL
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.moving = new System.Windows.Forms.Label();
            this.newgame = new System.Windows.Forms.Button();
            this.opengame = new System.Windows.Forms.Button();
            this.savegame = new System.Windows.Forms.Button();
            this.undo = new System.Windows.Forms.Button();
            this.music = new System.Windows.Forms.Button();
            this.op = new System.Windows.Forms.Button();
            this.quitgame = new System.Windows.Forms.Button();
            this.level = new System.Windows.Forms.GroupBox();
            this.extreme = new System.Windows.Forms.RadioButton();
            this.hard = new System.Windows.Forms.RadioButton();
            this.normal = new System.Windows.Forms.RadioButton();
            this.chessB = new System.Windows.Forms.PictureBox();
            this.chessA = new System.Windows.Forms.PictureBox();
            this.shape = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.status = new System.Windows.Forms.Label();
            this.time_playing = new System.Windows.Forms.Timer(this.components);
            this.tplaying = new System.Windows.Forms.Label();
            this.lastchess = new System.Windows.Forms.PictureBox();
            this.themeRed = new System.Windows.Forms.PictureBox();
            this.themeGreen = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.congatulation = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.board = new System.Windows.Forms.PictureBox();
            this.loadtimer = new System.Windows.Forms.Timer(this.components);
            this.level.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chessB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chessA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastchess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            this.SuspendLayout();
            // 
            // moving
            // 
            this.moving.AutoSize = true;
            this.moving.BackColor = System.Drawing.Color.Transparent;
            this.moving.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moving.Location = new System.Drawing.Point(2, 2);
            this.moving.Name = "moving";
            this.moving.Size = new System.Drawing.Size(539, 20);
            this.moving.TabIndex = 1;
            this.moving.Text = "---------------------------------------------------------------------------------" +
                "-------------------------";
            // 
            // newgame
            // 
            this.newgame.BackColor = System.Drawing.Color.Transparent;
            this.newgame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newgame.BackgroundImage")));
            this.newgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newgame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newgame.ForeColor = System.Drawing.Color.White;
            this.newgame.Location = new System.Drawing.Point(5, 24);
            this.newgame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(60, 60);
            this.newgame.TabIndex = 2;
            this.newgame.Text = "new game";
            this.newgame.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.newgame.UseVisualStyleBackColor = false;
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // opengame
            // 
            this.opengame.BackColor = System.Drawing.Color.Transparent;
            this.opengame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("opengame.BackgroundImage")));
            this.opengame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.opengame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.opengame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opengame.ForeColor = System.Drawing.Color.White;
            this.opengame.Location = new System.Drawing.Point(75, 24);
            this.opengame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.opengame.Name = "opengame";
            this.opengame.Size = new System.Drawing.Size(60, 60);
            this.opengame.TabIndex = 3;
            this.opengame.Text = "open";
            this.opengame.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.opengame.UseVisualStyleBackColor = false;
            this.opengame.Click += new System.EventHandler(this.opengame_Click);
            // 
            // savegame
            // 
            this.savegame.BackColor = System.Drawing.Color.Transparent;
            this.savegame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("savegame.BackgroundImage")));
            this.savegame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.savegame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.savegame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savegame.ForeColor = System.Drawing.Color.White;
            this.savegame.Location = new System.Drawing.Point(75, 95);
            this.savegame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.savegame.Name = "savegame";
            this.savegame.Size = new System.Drawing.Size(60, 60);
            this.savegame.TabIndex = 4;
            this.savegame.Text = "save";
            this.savegame.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.savegame.UseVisualStyleBackColor = false;
            this.savegame.Click += new System.EventHandler(this.savegame_Click);
            // 
            // undo
            // 
            this.undo.BackColor = System.Drawing.Color.Transparent;
            this.undo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("undo.BackgroundImage")));
            this.undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.undo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undo.ForeColor = System.Drawing.Color.White;
            this.undo.Location = new System.Drawing.Point(5, 95);
            this.undo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(60, 60);
            this.undo.TabIndex = 5;
            this.undo.Text = "undo";
            this.undo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.undo.UseVisualStyleBackColor = false;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // music
            // 
            this.music.BackColor = System.Drawing.Color.Transparent;
            this.music.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("music.BackgroundImage")));
            this.music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.music.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.music.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.music.ForeColor = System.Drawing.Color.White;
            this.music.Location = new System.Drawing.Point(74, 164);
            this.music.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.music.Name = "music";
            this.music.Size = new System.Drawing.Size(60, 60);
            this.music.TabIndex = 6;
            this.music.Text = "music";
            this.music.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.music.UseVisualStyleBackColor = false;
            // 
            // op
            // 
            this.op.BackColor = System.Drawing.Color.Transparent;
            this.op.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("op.BackgroundImage")));
            this.op.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.op.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.op.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op.ForeColor = System.Drawing.Color.White;
            this.op.Location = new System.Drawing.Point(4, 164);
            this.op.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(60, 60);
            this.op.TabIndex = 7;
            this.op.Text = "option";
            this.op.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.op.UseVisualStyleBackColor = false;
            this.op.Click += new System.EventHandler(this.option_Click);
            // 
            // quitgame
            // 
            this.quitgame.BackColor = System.Drawing.Color.Transparent;
            this.quitgame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quitgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitgame.ForeColor = System.Drawing.Color.White;
            this.quitgame.Location = new System.Drawing.Point(490, 2);
            this.quitgame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quitgame.Name = "quitgame";
            this.quitgame.Size = new System.Drawing.Size(54, 20);
            this.quitgame.TabIndex = 8;
            this.quitgame.Text = "quit";
            this.quitgame.UseVisualStyleBackColor = false;
            this.quitgame.Click += new System.EventHandler(this.quitgame_Click);
            // 
            // level
            // 
            this.level.BackColor = System.Drawing.Color.Transparent;
            this.level.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("level.BackgroundImage")));
            this.level.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.level.Controls.Add(this.extreme);
            this.level.Controls.Add(this.hard);
            this.level.Controls.Add(this.normal);
            this.level.ForeColor = System.Drawing.Color.Gold;
            this.level.Location = new System.Drawing.Point(5, 225);
            this.level.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.level.Name = "level";
            this.level.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.level.Size = new System.Drawing.Size(130, 95);
            this.level.TabIndex = 9;
            this.level.TabStop = false;
            this.level.Text = "level";
            // 
            // extreme
            // 
            this.extreme.AutoSize = true;
            this.extreme.Location = new System.Drawing.Point(7, 69);
            this.extreme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.extreme.Name = "extreme";
            this.extreme.Size = new System.Drawing.Size(62, 17);
            this.extreme.TabIndex = 2;
            this.extreme.Text = "extreme";
            this.extreme.UseVisualStyleBackColor = true;
            this.extreme.CheckedChanged += new System.EventHandler(this.extreme_CheckedChanged);
            // 
            // hard
            // 
            this.hard.AutoSize = true;
            this.hard.Checked = true;
            this.hard.Location = new System.Drawing.Point(7, 44);
            this.hard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(46, 17);
            this.hard.TabIndex = 1;
            this.hard.TabStop = true;
            this.hard.Text = "hard";
            this.hard.UseVisualStyleBackColor = true;
            this.hard.CheckedChanged += new System.EventHandler(this.hard_CheckedChanged);
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Location = new System.Drawing.Point(7, 20);
            this.normal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(56, 17);
            this.normal.TabIndex = 0;
            this.normal.Text = "normal";
            this.normal.UseVisualStyleBackColor = true;
            this.normal.CheckedChanged += new System.EventHandler(this.normal_CheckedChanged);
            // 
            // chessB
            // 
            this.chessB.BackColor = System.Drawing.Color.Transparent;
            this.chessB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chessB.BackgroundImage")));
            this.chessB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chessB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chessB.Image = ((System.Drawing.Image)(resources.GetObject("chessB.Image")));
            this.chessB.Location = new System.Drawing.Point(94, 376);
            this.chessB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chessB.Name = "chessB";
            this.chessB.Size = new System.Drawing.Size(40, 40);
            this.chessB.TabIndex = 10;
            this.chessB.TabStop = false;
            this.chessB.Click += new System.EventHandler(this.red_Click);
            // 
            // chessA
            // 
            this.chessA.BackColor = System.Drawing.Color.Transparent;
            this.chessA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chessA.BackgroundImage")));
            this.chessA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chessA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chessA.Image = ((System.Drawing.Image)(resources.GetObject("chessA.Image")));
            this.chessA.Location = new System.Drawing.Point(95, 328);
            this.chessA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chessA.Name = "chessA";
            this.chessA.Size = new System.Drawing.Size(40, 40);
            this.chessA.TabIndex = 11;
            this.chessA.TabStop = false;
            this.chessA.Click += new System.EventHandler(this.black_Click);
            // 
            // shape
            // 
            this.shape.BackColor = System.Drawing.Color.Transparent;
            this.shape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.shape.Location = new System.Drawing.Point(204, 236);
            this.shape.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shape.Name = "shape";
            this.shape.Size = new System.Drawing.Size(20, 20);
            this.shape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.shape.TabIndex = 12;
            this.shape.TabStop = false;
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.BackColor = System.Drawing.Color.Transparent;
            this.player1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1.ForeColor = System.Drawing.Color.Gold;
            this.player1.Location = new System.Drawing.Point(12, 328);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(56, 17);
            this.player1.TabIndex = 13;
            this.player1.Text = "human";
            this.player1.Click += new System.EventHandler(this.player1_Click);
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.BackColor = System.Drawing.Color.Transparent;
            this.player2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2.ForeColor = System.Drawing.Color.Gold;
            this.player2.Location = new System.Drawing.Point(12, 370);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(75, 17);
            this.player2.TabIndex = 14;
            this.player2.Text = "computer";
            this.player2.Click += new System.EventHandler(this.player2_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Orange;
            this.status.Location = new System.Drawing.Point(7, 398);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(20, 29);
            this.status.TabIndex = 15;
            this.status.Text = ".";
            // 
            // time_playing
            // 
            this.time_playing.Enabled = true;
            this.time_playing.Interval = 1000;
            this.time_playing.Tick += new System.EventHandler(this.time_playing_Tick);
            // 
            // tplaying
            // 
            this.tplaying.AutoSize = true;
            this.tplaying.BackColor = System.Drawing.Color.Transparent;
            this.tplaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tplaying.ForeColor = System.Drawing.Color.Gold;
            this.tplaying.Location = new System.Drawing.Point(9, 3);
            this.tplaying.Name = "tplaying";
            this.tplaying.Size = new System.Drawing.Size(34, 17);
            this.tplaying.TabIndex = 16;
            this.tplaying.Text = "time";
            // 
            // lastchess
            // 
            this.lastchess.BackColor = System.Drawing.Color.Transparent;
            this.lastchess.Image = ((System.Drawing.Image)(resources.GetObject("lastchess.Image")));
            this.lastchess.Location = new System.Drawing.Point(17, 359);
            this.lastchess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastchess.Name = "lastchess";
            this.lastchess.Size = new System.Drawing.Size(20, 20);
            this.lastchess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lastchess.TabIndex = 17;
            this.lastchess.TabStop = false;
            // 
            // themeRed
            // 
            this.themeRed.Location = new System.Drawing.Point(329, 225);
            this.themeRed.Name = "themeRed";
            this.themeRed.Size = new System.Drawing.Size(832, 450);
            this.themeRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.themeRed.TabIndex = 18;
            this.themeRed.TabStop = false;
            this.themeRed.Visible = false;
            // 
            // themeGreen
            // 
            this.themeGreen.Location = new System.Drawing.Point(302, 294);
            this.themeGreen.Name = "themeGreen";
            this.themeGreen.Size = new System.Drawing.Size(1440, 900);
            this.themeGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.themeGreen.TabIndex = 19;
            this.themeGreen.TabStop = false;
            this.themeGreen.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(94, 376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(95, 327);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // congatulation
            // 
            this.congatulation.Enabled = true;
            this.congatulation.Interval = 500;
            this.congatulation.Tick += new System.EventHandler(this.congatulation_Tick);
            // 
            // board
            // 
            this.board.Location = new System.Drawing.Point(362, 328);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(600, 450);
            this.board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.board.TabIndex = 23;
            this.board.TabStop = false;
            this.board.Visible = false;
            // 
            // loadtimer
            // 
            this.loadtimer.Enabled = true;
            this.loadtimer.Tick += new System.EventHandler(this.loadtimer_Tick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(556, 434);
            this.Controls.Add(this.board);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lastchess);
            this.Controls.Add(this.themeGreen);
            this.Controls.Add(this.themeRed);
            this.Controls.Add(this.tplaying);
            this.Controls.Add(this.status);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.shape);
            this.Controls.Add(this.chessA);
            this.Controls.Add(this.chessB);
            this.Controls.Add(this.level);
            this.Controls.Add(this.quitgame);
            this.Controls.Add(this.op);
            this.Controls.Add(this.music);
            this.Controls.Add(this.undo);
            this.Controls.Add(this.savegame);
            this.Controls.Add(this.opengame);
            this.Controls.Add(this.newgame);
            this.Controls.Add(this.moving);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "main";
            this.Opacity = 0;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.level.ResumeLayout(false);
            this.level.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chessB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chessA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastchess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moving;
        private System.Windows.Forms.Button newgame;
        private System.Windows.Forms.Button opengame;
        private System.Windows.Forms.Button savegame;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.Button music;
        private System.Windows.Forms.Button op;
        private System.Windows.Forms.Button quitgame;
        private System.Windows.Forms.GroupBox level;
        private System.Windows.Forms.RadioButton extreme;
        private System.Windows.Forms.RadioButton hard;
        private System.Windows.Forms.RadioButton normal;
        private System.Windows.Forms.PictureBox chessB;
        private System.Windows.Forms.PictureBox chessA;
        private System.Windows.Forms.PictureBox shape;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Timer time_playing;
        private System.Windows.Forms.Label tplaying;
        private System.Windows.Forms.PictureBox lastchess;
        private System.Windows.Forms.PictureBox themeRed;
        private System.Windows.Forms.PictureBox themeGreen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer congatulation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox board;
        private System.Windows.Forms.Timer loadtimer;
    }
}

