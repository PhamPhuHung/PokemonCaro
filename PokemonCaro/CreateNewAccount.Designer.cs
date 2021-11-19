namespace PokemonCaro
{
    partial class CreateNewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewAccount));
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btCreate = new System.Windows.Forms.Button();
            this.cbbGen = new System.Windows.Forms.ComboBox();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(83, 73);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(118, 23);
            this.tbName.TabIndex = 2;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(83, 9);
            this.tbCode.Multiline = true;
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(118, 23);
            this.tbCode.TabIndex = 0;
            this.tbCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(83, 41);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(118, 23);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(12, 157);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(189, 23);
            this.btCreate.TabIndex = 7;
            this.btCreate.Text = "Create New Account";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // cbbGen
            // 
            this.cbbGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGen.FormattingEnabled = true;
            this.cbbGen.Location = new System.Drawing.Point(84, 105);
            this.cbbGen.Name = "cbbGen";
            this.cbbGen.Size = new System.Drawing.Size(117, 21);
            this.cbbGen.TabIndex = 8;
            // 
            // pbPicture
            // 
            this.pbPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPicture.Image = ((System.Drawing.Image)(resources.GetObject("pbPicture.Image")));
            this.pbPicture.Location = new System.Drawing.Point(207, 9);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(155, 171);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 6;
            this.pbPicture.TabStop = false;
            this.pbPicture.Click += new System.EventHandler(this.pbPicture_Click);
            // 
            // CreateNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(367, 189);
            this.Controls.Add(this.cbbGen);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(383, 228);
            this.MinimumSize = new System.Drawing.Size(383, 228);
            this.Name = "CreateNewAccount";
            this.Text = "CreateNewAccount";
            this.Shown += new System.EventHandler(this.CreateNewAccount_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.ComboBox cbbGen;
    }
}