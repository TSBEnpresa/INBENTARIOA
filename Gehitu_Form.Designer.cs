namespace TSB_Inbentarioa
{
    partial class GailuaGehitu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GailuaGehitu_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gGehitu_TXT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gailua_CB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // gGehitu_TXT
            // 
            this.gGehitu_TXT.AutoSize = true;
            this.gGehitu_TXT.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gGehitu_TXT.Location = new System.Drawing.Point(324, 21);
            this.gGehitu_TXT.Name = "gGehitu_TXT";
            this.gGehitu_TXT.Size = new System.Drawing.Size(180, 32);
            this.gGehitu_TXT.TabIndex = 29;
            this.gGehitu_TXT.Text = "GAILUA GEHITU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Gailu Motak";
            // 
            // Gailua_CB
            // 
            this.Gailua_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gailua_CB.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gailua_CB.FormattingEnabled = true;
            this.Gailua_CB.Location = new System.Drawing.Point(49, 98);
            this.Gailua_CB.Name = "Gailua_CB";
            this.Gailua_CB.Size = new System.Drawing.Size(234, 33);
            this.Gailua_CB.TabIndex = 33;
            this.Gailua_CB.SelectedIndexChanged += new System.EventHandler(this.Gailua_CB_SelectedIndexChanged);
            // 
            // GailuaGehitu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 545);
            this.Controls.Add(this.Gailua_CB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gGehitu_TXT);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1318, 710);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(920, 584);
            this.Name = "GailuaGehitu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSB INBENTARIOA | Gailua Gehitu";
            this.Load += new System.EventHandler(this.GailuaGehitu_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label gGehitu_TXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Gailua_CB;
    }
}