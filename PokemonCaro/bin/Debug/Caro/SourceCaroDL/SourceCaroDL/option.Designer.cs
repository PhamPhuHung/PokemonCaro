namespace CaroDL
{
    partial class option
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(option));
            this.theme = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GREEN = new System.Windows.Forms.RadioButton();
            this.classic = new System.Windows.Forms.RadioButton();
            this.soundgame = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SizeBox = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timethinking = new System.Windows.Forms.TrackBar();
            this.OK = new System.Windows.Forms.Button();
            this.wood = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.theme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SizeBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timethinking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // theme
            // 
            this.theme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.theme.Controls.Add(this.pictureBox3);
            this.theme.Controls.Add(this.wood);
            this.theme.Controls.Add(this.pictureBox2);
            this.theme.Controls.Add(this.pictureBox1);
            this.theme.Controls.Add(this.GREEN);
            this.theme.Controls.Add(this.classic);
            this.theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theme.Location = new System.Drawing.Point(12, 12);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(368, 100);
            this.theme.TabIndex = 1;
            this.theme.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(127, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 48);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 48);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GREEN
            // 
            this.GREEN.AutoSize = true;
            this.GREEN.ForeColor = System.Drawing.Color.LimeGreen;
            this.GREEN.Location = new System.Drawing.Point(124, 10);
            this.GREEN.Name = "GREEN";
            this.GREEN.Size = new System.Drawing.Size(69, 17);
            this.GREEN.TabIndex = 1;
            this.GREEN.TabStop = true;
            this.GREEN.Text = "bamboo";
            this.GREEN.UseVisualStyleBackColor = true;
            this.GREEN.CheckedChanged += new System.EventHandler(this.black_CheckedChanged);
            // 
            // classic
            // 
            this.classic.AutoSize = true;
            this.classic.ForeColor = System.Drawing.Color.White;
            this.classic.Location = new System.Drawing.Point(6, 10);
            this.classic.Name = "classic";
            this.classic.Size = new System.Drawing.Size(64, 17);
            this.classic.TabIndex = 0;
            this.classic.TabStop = true;
            this.classic.Text = "classic";
            this.classic.UseVisualStyleBackColor = true;
            this.classic.CheckedChanged += new System.EventHandler(this.classic_CheckedChanged);
            // 
            // soundgame
            // 
            this.soundgame.AutoSize = true;
            this.soundgame.BackColor = System.Drawing.Color.Transparent;
            this.soundgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundgame.ForeColor = System.Drawing.Color.Orange;
            this.soundgame.Location = new System.Drawing.Point(6, 19);
            this.soundgame.Name = "soundgame";
            this.soundgame.Size = new System.Drawing.Size(97, 17);
            this.soundgame.TabIndex = 2;
            this.soundgame.Text = "sound effect";
            this.soundgame.UseVisualStyleBackColor = false;
            this.soundgame.CheckedChanged += new System.EventHandler(this.soundgame_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.SizeBox);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.timethinking);
            this.groupBox1.Controls.Add(this.soundgame);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 233);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // SizeBox
            // 
            this.SizeBox.BackColor = System.Drawing.Color.Transparent;
            this.SizeBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SizeBox.BackgroundImage")));
            this.SizeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SizeBox.Controls.Add(this.radioButton6);
            this.SizeBox.Controls.Add(this.radioButton5);
            this.SizeBox.Controls.Add(this.radioButton3);
            this.SizeBox.Controls.Add(this.radioButton4);
            this.SizeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeBox.ForeColor = System.Drawing.Color.Gold;
            this.SizeBox.Location = new System.Drawing.Point(6, 66);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(201, 76);
            this.SizeBox.TabIndex = 9;
            this.SizeBox.TabStop = false;
            this.SizeBox.Text = "size";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.ForeColor = System.Drawing.Color.Gold;
            this.radioButton6.Location = new System.Drawing.Point(107, 42);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(59, 17);
            this.radioButton6.TabIndex = 9;
            this.radioButton6.Text = "30x30";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.ForeColor = System.Drawing.Color.Gold;
            this.radioButton5.Location = new System.Drawing.Point(20, 42);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(59, 17);
            this.radioButton5.TabIndex = 8;
            this.radioButton5.Text = "20x30";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.Gold;
            this.radioButton3.Location = new System.Drawing.Point(20, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "20x20";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.Color.Gold;
            this.radioButton4.Location = new System.Drawing.Point(107, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(59, 17);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.Text = "25x25";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gold;
            this.groupBox2.Location = new System.Drawing.Point(213, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 76);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rule";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Gold;
            this.radioButton1.Location = new System.Drawing.Point(20, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Gomoku";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.Gold;
            this.radioButton2.Location = new System.Drawing.Point(20, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "CaroVietNam";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(175, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "time thinking";
            // 
            // timethinking
            // 
            this.timethinking.BackColor = System.Drawing.Color.Black;
            this.timethinking.Location = new System.Drawing.Point(260, 19);
            this.timethinking.Name = "timethinking";
            this.timethinking.Size = new System.Drawing.Size(102, 45);
            this.timethinking.TabIndex = 3;
            this.timethinking.Value = 6;
            // 
            // OK
            // 
            this.OK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OK.BackgroundImage")));
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.ForeColor = System.Drawing.Color.White;
            this.OK.Location = new System.Drawing.Point(168, 361);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(64, 25);
            this.OK.TabIndex = 0;
            this.OK.Text = "Ok";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // wood
            // 
            this.wood.AutoSize = true;
            this.wood.ForeColor = System.Drawing.Color.Chocolate;
            this.wood.Location = new System.Drawing.Point(260, 10);
            this.wood.Name = "wood";
            this.wood.Size = new System.Drawing.Size(55, 17);
            this.wood.TabIndex = 4;
            this.wood.TabStop = true;
            this.wood.Text = "wood";
            this.wood.UseVisualStyleBackColor = true;
            this.wood.CheckedChanged += new System.EventHandler(this.wood_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(260, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 48);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(392, 398);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.theme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "option";
            this.Opacity = 0.8;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "option";
            this.theme.ResumeLayout(false);
            this.theme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SizeBox.ResumeLayout(false);
            this.SizeBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timethinking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox theme;
        private System.Windows.Forms.RadioButton GREEN;
        private System.Windows.Forms.RadioButton classic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.CheckBox soundgame;
        public System.Windows.Forms.TrackBar timethinking;
        private System.Windows.Forms.GroupBox SizeBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton wood;
    }
}