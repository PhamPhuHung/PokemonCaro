
namespace PokemonCaro
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.lbResult = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.lbRank = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lbResult
            // 
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(15, 9);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(333, 23);
            this.lbResult.TabIndex = 0;
            this.lbResult.Text = "RESULT";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(15, 339);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(333, 35);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "EXIT";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // pbResult
            // 
            this.pbResult.BackgroundImage = global::PokemonCaro.Properties.Resources.YouLose1;
            this.pbResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbResult.Location = new System.Drawing.Point(15, 36);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(333, 256);
            this.pbResult.TabIndex = 1;
            this.pbResult.TabStop = false;
            // 
            // lbRank
            // 
            this.lbRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRank.Location = new System.Drawing.Point(12, 295);
            this.lbRank.Name = "lbRank";
            this.lbRank.Size = new System.Drawing.Size(333, 23);
            this.lbRank.TabIndex = 3;
            this.lbRank.Text = "RESULT";
            this.lbRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(360, 386);
            this.Controls.Add(this.lbRank);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.lbResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Result";
            this.Text = "Result";
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbRank;
    }
}