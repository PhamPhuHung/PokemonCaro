namespace PokemonCaro
{
    partial class PokemonCollection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokemonCollection));
            this.flpCollection = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbGen = new System.Windows.Forms.Label();
            this.btLeftGen = new System.Windows.Forms.Button();
            this.btRightGen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpCollection
            // 
            this.flpCollection.Location = new System.Drawing.Point(13, 13);
            this.flpCollection.Name = "flpCollection";
            this.flpCollection.Size = new System.Drawing.Size(655, 530);
            this.flpCollection.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbGen);
            this.panel1.Controls.Add(this.btLeftGen);
            this.panel1.Controls.Add(this.btRightGen);
            this.panel1.Location = new System.Drawing.Point(211, 549);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 60);
            this.panel1.TabIndex = 21;
            // 
            // lbGen
            // 
            this.lbGen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbGen.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGen.Location = new System.Drawing.Point(55, 3);
            this.lbGen.Name = "lbGen";
            this.lbGen.Size = new System.Drawing.Size(157, 55);
            this.lbGen.TabIndex = 3;
            this.lbGen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLeftGen
            // 
            this.btLeftGen.BackColor = System.Drawing.Color.Transparent;
            this.btLeftGen.BackgroundImage = global::PokemonCaro.Properties.Resources.LeftArrow;
            this.btLeftGen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btLeftGen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLeftGen.Location = new System.Drawing.Point(3, 2);
            this.btLeftGen.Name = "btLeftGen";
            this.btLeftGen.Size = new System.Drawing.Size(46, 55);
            this.btLeftGen.TabIndex = 2;
            this.btLeftGen.UseVisualStyleBackColor = false;
            this.btLeftGen.Click += new System.EventHandler(this.btLeftGen_Click);
            // 
            // btRightGen
            // 
            this.btRightGen.BackgroundImage = global::PokemonCaro.Properties.Resources.RightArrow;
            this.btRightGen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRightGen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRightGen.Location = new System.Drawing.Point(218, 2);
            this.btRightGen.Name = "btRightGen";
            this.btRightGen.Size = new System.Drawing.Size(46, 55);
            this.btRightGen.TabIndex = 2;
            this.btRightGen.UseVisualStyleBackColor = true;
            this.btRightGen.Click += new System.EventHandler(this.btRightGen_Click);
            // 
            // PokemonCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpCollection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(690, 650);
            this.MinimumSize = new System.Drawing.Size(690, 650);
            this.Name = "PokemonCollection";
            this.Text = "PokemonCollection";
            this.Shown += new System.EventHandler(this.PokemonCollection_Shown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCollection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbGen;
        private System.Windows.Forms.Button btLeftGen;
        private System.Windows.Forms.Button btRightGen;
    }
}