namespace testlauncher
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.playBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.homepageBTN = new System.Windows.Forms.Button();
            this.forumBTN = new System.Windows.Forms.Button();
            this.bugtrackerBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playBTN
            // 
            this.playBTN.Location = new System.Drawing.Point(442, 304);
            this.playBTN.Name = "playBTN";
            this.playBTN.Size = new System.Drawing.Size(227, 48);
            this.playBTN.TabIndex = 0;
            this.playBTN.Text = "GIOCA";
            this.playBTN.UseVisualStyleBackColor = true;
            this.playBTN.Click += new System.EventHandler(this.playBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imposta cartella di";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.Location = new System.Drawing.Point(577, 322);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "WOW";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(15, 13);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(23, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(649, 273);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.Url = new System.Uri("http://transferoil.com", System.UriKind.Absolute);
            // 
            // homepageBTN
            // 
            this.homepageBTN.Location = new System.Drawing.Point(15, 304);
            this.homepageBTN.Name = "homepageBTN";
            this.homepageBTN.Size = new System.Drawing.Size(87, 48);
            this.homepageBTN.TabIndex = 4;
            this.homepageBTN.Text = "HomePage";
            this.homepageBTN.UseVisualStyleBackColor = true;
            this.homepageBTN.Click += new System.EventHandler(this.homepageBTN_Click);
            // 
            // forumBTN
            // 
            this.forumBTN.Location = new System.Drawing.Point(110, 304);
            this.forumBTN.Name = "forumBTN";
            this.forumBTN.Size = new System.Drawing.Size(87, 48);
            this.forumBTN.TabIndex = 5;
            this.forumBTN.Text = "Forum";
            this.forumBTN.UseVisualStyleBackColor = true;
            this.forumBTN.Click += new System.EventHandler(this.forumBTN_Click);
            // 
            // bugtrackerBTN
            // 
            this.bugtrackerBTN.Location = new System.Drawing.Point(204, 304);
            this.bugtrackerBTN.Name = "bugtrackerBTN";
            this.bugtrackerBTN.Size = new System.Drawing.Size(87, 48);
            this.bugtrackerBTN.TabIndex = 6;
            this.bugtrackerBTN.Text = "Azeroth Lab";
            this.bugtrackerBTN.UseVisualStyleBackColor = true;
            this.bugtrackerBTN.Click += new System.EventHandler(this.bugtrackerBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::testlauncher.Properties.Resources.Chrysanthemum;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 367);
            this.Controls.Add(this.bugtrackerBTN);
            this.Controls.Add(this.forumBTN);
            this.Controls.Add(this.homepageBTN);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playBTN);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Azeroth Shard Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button homepageBTN;
        private System.Windows.Forms.Button forumBTN;
        private System.Windows.Forms.Button bugtrackerBTN;
    }
}

