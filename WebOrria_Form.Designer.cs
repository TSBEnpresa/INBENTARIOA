namespace TSB_Inbentarioa
{
    partial class WebOrria_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebOrria_Form));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BT_WebOrriaIreki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 52);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(880, 481);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://tsbenpresa.github.io/", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // BT_WebOrriaIreki
            // 
            this.BT_WebOrriaIreki.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_WebOrriaIreki.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BT_WebOrriaIreki.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_WebOrriaIreki.BackgroundImage")));
            this.BT_WebOrriaIreki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_WebOrriaIreki.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_WebOrriaIreki.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_WebOrriaIreki.Location = new System.Drawing.Point(12, 12);
            this.BT_WebOrriaIreki.Name = "BT_WebOrriaIreki";
            this.BT_WebOrriaIreki.Size = new System.Drawing.Size(880, 33);
            this.BT_WebOrriaIreki.TabIndex = 1;
            this.BT_WebOrriaIreki.Text = "ORRIA NABIGATZAILEAN IREKI";
            this.BT_WebOrriaIreki.UseVisualStyleBackColor = true;
            this.BT_WebOrriaIreki.Click += new System.EventHandler(this.BT_WebOrriaIreki_Click);
            // 
            // WebOrria_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 545);
            this.Controls.Add(this.BT_WebOrriaIreki);
            this.Controls.Add(this.webBrowser1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1318, 710);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(920, 584);
            this.Name = "WebOrria_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSB INBENTARIOA | Web Orria";
            this.Load += new System.EventHandler(this.WebOrria_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button BT_WebOrriaIreki;
    }
}