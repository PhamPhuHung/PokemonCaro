namespace PokemonCaro
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btLogIn = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(83, 9);
            this.tbCode.Multiline = true;
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(118, 23);
            this.tbCode.TabIndex = 0;
            this.tbCode.Text = "1013";
            this.tbCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(83, 41);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(118, 23);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Text = "1111";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btLogIn
            // 
            this.btLogIn.Location = new System.Drawing.Point(12, 70);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(189, 23);
            this.btLogIn.TabIndex = 2;
            this.btLogIn.Text = "Log In";
            this.btLogIn.UseVisualStyleBackColor = true;
            this.btLogIn.Click += new System.EventHandler(this.btLogIn_Click);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(12, 117);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(189, 23);
            this.btCreate.TabIndex = 2;
            this.btCreate.Text = "Create new account";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "---------------------------or---------------------------";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogIn
            // 
            this.AcceptButton = this.btLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(216, 146);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.btLogIn);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(232, 185);
            this.MinimumSize = new System.Drawing.Size(232, 185);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btLogIn;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Label label3;
    }
}