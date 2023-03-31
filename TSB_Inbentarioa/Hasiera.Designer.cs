namespace TSB_Inbentarioa
{
    partial class Hasiera_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hasiera_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SARTU_BT = new System.Windows.Forms.Button();
            this.Erabiltzaileak_CB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pasahitza_TB = new System.Windows.Forms.TextBox();
            this.ITXI_BT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(356, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F);
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "HASIERA MENUA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SARTU_BT
            // 
            this.SARTU_BT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SARTU_BT.Location = new System.Drawing.Point(151, 361);
            this.SARTU_BT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SARTU_BT.Name = "SARTU_BT";
            this.SARTU_BT.Size = new System.Drawing.Size(176, 49);
            this.SARTU_BT.TabIndex = 2;
            this.SARTU_BT.Text = "LOGIN EGIN";
            this.SARTU_BT.UseVisualStyleBackColor = true;
            this.SARTU_BT.Click += new System.EventHandler(this.SARTU_BT_Click);
            // 
            // Erabiltzaileak_CB
            // 
            this.Erabiltzaileak_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Erabiltzaileak_CB.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Erabiltzaileak_CB.FormattingEnabled = true;
            this.Erabiltzaileak_CB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Erabiltzaileak_CB.Items.AddRange(new object[] {
            "administraria",
            "langilea"});
            this.Erabiltzaileak_CB.Location = new System.Drawing.Point(35, 181);
            this.Erabiltzaileak_CB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Erabiltzaileak_CB.Name = "Erabiltzaileak_CB";
            this.Erabiltzaileak_CB.Size = new System.Drawing.Size(409, 36);
            this.Erabiltzaileak_CB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Erabiltzailea aukeratu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pasahitza sartu";
            // 
            // pasahitza_TB
            // 
            this.pasahitza_TB.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasahitza_TB.Location = new System.Drawing.Point(35, 284);
            this.pasahitza_TB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pasahitza_TB.Name = "pasahitza_TB";
            this.pasahitza_TB.PasswordChar = '*';
            this.pasahitza_TB.Size = new System.Drawing.Size(409, 34);
            this.pasahitza_TB.TabIndex = 8;
            // 
            // ITXI_BT
            // 
            this.ITXI_BT.Location = new System.Drawing.Point(151, 416);
            this.ITXI_BT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ITXI_BT.Name = "ITXI_BT";
            this.ITXI_BT.Size = new System.Drawing.Size(176, 28);
            this.ITXI_BT.TabIndex = 9;
            this.ITXI_BT.Text = "ITXI";
            this.ITXI_BT.UseVisualStyleBackColor = true;
            this.ITXI_BT.Click += new System.EventHandler(this.ITXI_BT_Click);
            // 
            // Hasiera_Form
            // 
            this.AcceptButton = this.SARTU_BT;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.ITXI_BT);
            this.Controls.Add(this.pasahitza_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Erabiltzaileak_CB);
            this.Controls.Add(this.SARTU_BT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(501, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(501, 497);
            this.Name = "Hasiera_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSB INBENTARIOA | HASIERA";
            this.Load += new System.EventHandler(this.Hasiera_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SARTU_BT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Erabiltzaileak_CB;
        private System.Windows.Forms.TextBox pasahitza_TB;
        private System.Windows.Forms.Button ITXI_BT;
    }
}

