﻿namespace TSB_Inbentarioa
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
            this.txt_SerieZbk = new System.Windows.Forms.TextBox();
            this.label_SerieZBK = new System.Windows.Forms.Label();
            this.label_marka = new System.Windows.Forms.Label();
            this.txt_Marka = new System.Windows.Forms.TextBox();
            this.label_Modeloa = new System.Windows.Forms.Label();
            this.txt_Modeloa = new System.Windows.Forms.TextBox();
            this.label_Pantaila = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_ErosketaData = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Desc = new System.Windows.Forms.TextBox();
            this.dtp_ErosketaData = new System.Windows.Forms.DateTimePicker();
            this.Label_SistemaEdoInprMota = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_Puz = new System.Windows.Forms.Label();
            this.label_RMotaEdoReso = new System.Windows.Forms.Label();
            this.cb_Mintegia = new System.Windows.Forms.ComboBox();
            this.label_RAM = new System.Windows.Forms.Label();
            this.label_MKantitatea = new System.Windows.Forms.Label();
            this.label_Bateria = new System.Windows.Forms.Label();
            this.bt_GGehitu = new System.Windows.Forms.Button();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.txt_Puz = new System.Windows.Forms.TextBox();
            this.cb_Pantaila = new System.Windows.Forms.ComboBox();
            this.cb_RMotaEdoReso = new System.Windows.Forms.ComboBox();
            this.cb_SEragileaEdoInprMota = new System.Windows.Forms.ComboBox();
            this.cb_RamKantitatea = new System.Windows.Forms.ComboBox();
            this.cb_MKantitatea = new System.Windows.Forms.ComboBox();
            this.cb_Bateria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gGehitu_TXT
            // 
            this.gGehitu_TXT.AutoSize = true;
            this.gGehitu_TXT.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gGehitu_TXT.Location = new System.Drawing.Point(358, 21);
            this.gGehitu_TXT.Name = "gGehitu_TXT";
            this.gGehitu_TXT.Size = new System.Drawing.Size(180, 32);
            this.gGehitu_TXT.TabIndex = 29;
            this.gGehitu_TXT.Text = "GAILUA GEHITU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 76);
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
            this.Gailua_CB.Location = new System.Drawing.Point(20, 92);
            this.Gailua_CB.Name = "Gailua_CB";
            this.Gailua_CB.Size = new System.Drawing.Size(250, 33);
            this.Gailua_CB.TabIndex = 33;
            this.Gailua_CB.SelectedIndexChanged += new System.EventHandler(this.Gailua_CB_SelectedIndexChanged);
            // 
            // txt_SerieZbk
            // 
            this.txt_SerieZbk.Enabled = false;
            this.txt_SerieZbk.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.txt_SerieZbk.Location = new System.Drawing.Point(33, 167);
            this.txt_SerieZbk.Name = "txt_SerieZbk";
            this.txt_SerieZbk.Size = new System.Drawing.Size(180, 29);
            this.txt_SerieZbk.TabIndex = 34;
            this.txt_SerieZbk.TextChanged += new System.EventHandler(this.txt_SerieZbk_TextChanged);
            // 
            // label_SerieZBK
            // 
            this.label_SerieZBK.AutoSize = true;
            this.label_SerieZBK.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_SerieZBK.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SerieZBK.ForeColor = System.Drawing.Color.Black;
            this.label_SerieZBK.Location = new System.Drawing.Point(34, 151);
            this.label_SerieZBK.Name = "label_SerieZBK";
            this.label_SerieZBK.Size = new System.Drawing.Size(87, 13);
            this.label_SerieZBK.TabIndex = 35;
            this.label_SerieZBK.Text = "Serie Zenbakia *";
            this.label_SerieZBK.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_marka
            // 
            this.label_marka.AutoSize = true;
            this.label_marka.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_marka.Location = new System.Drawing.Point(34, 225);
            this.label_marka.Name = "label_marka";
            this.label_marka.Size = new System.Drawing.Size(46, 13);
            this.label_marka.TabIndex = 37;
            this.label_marka.Text = "Marka *";
            // 
            // txt_Marka
            // 
            this.txt_Marka.Enabled = false;
            this.txt_Marka.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.txt_Marka.Location = new System.Drawing.Point(33, 241);
            this.txt_Marka.Name = "txt_Marka";
            this.txt_Marka.Size = new System.Drawing.Size(180, 29);
            this.txt_Marka.TabIndex = 36;
            this.txt_Marka.TextChanged += new System.EventHandler(this.txt_Marka_TextChanged);
            // 
            // label_Modeloa
            // 
            this.label_Modeloa.AutoSize = true;
            this.label_Modeloa.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Modeloa.Location = new System.Drawing.Point(34, 302);
            this.label_Modeloa.Name = "label_Modeloa";
            this.label_Modeloa.Size = new System.Drawing.Size(58, 13);
            this.label_Modeloa.TabIndex = 39;
            this.label_Modeloa.Text = "Modeloa *";
            // 
            // txt_Modeloa
            // 
            this.txt_Modeloa.Enabled = false;
            this.txt_Modeloa.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.txt_Modeloa.Location = new System.Drawing.Point(33, 318);
            this.txt_Modeloa.Name = "txt_Modeloa";
            this.txt_Modeloa.Size = new System.Drawing.Size(180, 29);
            this.txt_Modeloa.TabIndex = 38;
            // 
            // label_Pantaila
            // 
            this.label_Pantaila.AutoSize = true;
            this.label_Pantaila.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pantaila.Location = new System.Drawing.Point(254, 301);
            this.label_Pantaila.Name = "label_Pantaila";
            this.label_Pantaila.Size = new System.Drawing.Size(47, 13);
            this.label_Pantaila.TabIndex = 45;
            this.label_Pantaila.Text = "Pantaila";
            this.label_Pantaila.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Mintegia *";
            // 
            // label_ErosketaData
            // 
            this.label_ErosketaData.AutoSize = true;
            this.label_ErosketaData.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ErosketaData.Location = new System.Drawing.Point(251, 151);
            this.label_ErosketaData.Name = "label_ErosketaData";
            this.label_ErosketaData.Size = new System.Drawing.Size(84, 13);
            this.label_ErosketaData.TabIndex = 41;
            this.label_ErosketaData.Text = "Erosketa Data *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Deskribapen Motza";
            // 
            // txt_Desc
            // 
            this.txt_Desc.Enabled = false;
            this.txt_Desc.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.txt_Desc.Location = new System.Drawing.Point(33, 392);
            this.txt_Desc.Multiline = true;
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Size = new System.Drawing.Size(398, 32);
            this.txt_Desc.TabIndex = 46;
            // 
            // dtp_ErosketaData
            // 
            this.dtp_ErosketaData.Enabled = false;
            this.dtp_ErosketaData.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ErosketaData.Location = new System.Drawing.Point(250, 170);
            this.dtp_ErosketaData.Name = "dtp_ErosketaData";
            this.dtp_ErosketaData.Size = new System.Drawing.Size(180, 23);
            this.dtp_ErosketaData.TabIndex = 48;
            // 
            // Label_SistemaEdoInprMota
            // 
            this.Label_SistemaEdoInprMota.AutoSize = true;
            this.Label_SistemaEdoInprMota.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SistemaEdoInprMota.Location = new System.Drawing.Point(473, 151);
            this.Label_SistemaEdoInprMota.Name = "Label_SistemaEdoInprMota";
            this.Label_SistemaEdoInprMota.Size = new System.Drawing.Size(46, 13);
            this.Label_SistemaEdoInprMota.TabIndex = 50;
            this.Label_SistemaEdoInprMota.Text = "Sistema";
            this.Label_SistemaEdoInprMota.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.Location = new System.Drawing.Point(681, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // label_Puz
            // 
            this.label_Puz.AutoSize = true;
            this.label_Puz.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Puz.Location = new System.Drawing.Point(473, 300);
            this.label_Puz.Name = "label_Puz";
            this.label_Puz.Size = new System.Drawing.Size(114, 13);
            this.label_Puz.TabIndex = 53;
            this.label_Puz.Text = "Prozesagailua | PUZ-a";
            this.label_Puz.Visible = false;
            // 
            // label_RMotaEdoReso
            // 
            this.label_RMotaEdoReso.AutoSize = true;
            this.label_RMotaEdoReso.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RMotaEdoReso.Location = new System.Drawing.Point(473, 225);
            this.label_RMotaEdoReso.Name = "label_RMotaEdoReso";
            this.label_RMotaEdoReso.Size = new System.Drawing.Size(60, 13);
            this.label_RMotaEdoReso.TabIndex = 55;
            this.label_RMotaEdoReso.Text = "RAM Mota";
            this.label_RMotaEdoReso.Visible = false;
            // 
            // cb_Mintegia
            // 
            this.cb_Mintegia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Mintegia.Enabled = false;
            this.cb_Mintegia.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.cb_Mintegia.IntegralHeight = false;
            this.cb_Mintegia.Location = new System.Drawing.Point(250, 240);
            this.cb_Mintegia.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Mintegia.Name = "cb_Mintegia";
            this.cb_Mintegia.Size = new System.Drawing.Size(180, 29);
            this.cb_Mintegia.TabIndex = 56;
            // 
            // label_RAM
            // 
            this.label_RAM.AutoSize = true;
            this.label_RAM.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RAM.Location = new System.Drawing.Point(687, 151);
            this.label_RAM.Name = "label_RAM";
            this.label_RAM.Size = new System.Drawing.Size(85, 13);
            this.label_RAM.TabIndex = 60;
            this.label_RAM.Text = "RAM Kantitatea";
            this.label_RAM.Visible = false;
            // 
            // label_MKantitatea
            // 
            this.label_MKantitatea.AutoSize = true;
            this.label_MKantitatea.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MKantitatea.Location = new System.Drawing.Point(687, 225);
            this.label_MKantitatea.Name = "label_MKantitatea";
            this.label_MKantitatea.Size = new System.Drawing.Size(105, 13);
            this.label_MKantitatea.TabIndex = 62;
            this.label_MKantitatea.Text = "Memoria Kantitatea";
            this.label_MKantitatea.Visible = false;
            // 
            // label_Bateria
            // 
            this.label_Bateria.AutoSize = true;
            this.label_Bateria.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Bateria.Location = new System.Drawing.Point(687, 303);
            this.label_Bateria.Name = "label_Bateria";
            this.label_Bateria.Size = new System.Drawing.Size(102, 13);
            this.label_Bateria.TabIndex = 64;
            this.label_Bateria.Text = "Bateria kapazitatea";
            this.label_Bateria.Visible = false;
            // 
            // bt_GGehitu
            // 
            this.bt_GGehitu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_GGehitu.BackgroundImage")));
            this.bt_GGehitu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_GGehitu.Enabled = false;
            this.bt_GGehitu.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GGehitu.ForeColor = System.Drawing.SystemColors.Control;
            this.bt_GGehitu.Location = new System.Drawing.Point(250, 461);
            this.bt_GGehitu.Margin = new System.Windows.Forms.Padding(2);
            this.bt_GGehitu.Name = "bt_GGehitu";
            this.bt_GGehitu.Size = new System.Drawing.Size(401, 43);
            this.bt_GGehitu.TabIndex = 66;
            this.bt_GGehitu.Text = "GAILUA GEHITU";
            this.bt_GGehitu.UseVisualStyleBackColor = true;
            this.bt_GGehitu.Click += new System.EventHandler(this.bt_GGehitu_Click);
            // 
            // bt_Reset
            // 
            this.bt_Reset.BackColor = System.Drawing.SystemColors.Window;
            this.bt_Reset.Enabled = false;
            this.bt_Reset.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.bt_Reset.Location = new System.Drawing.Point(472, 392);
            this.bt_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(393, 32);
            this.bt_Reset.TabIndex = 67;
            this.bt_Reset.Text = "RESET";
            this.bt_Reset.UseVisualStyleBackColor = false;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // txt_Puz
            // 
            this.txt_Puz.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.txt_Puz.Location = new System.Drawing.Point(472, 316);
            this.txt_Puz.Name = "txt_Puz";
            this.txt_Puz.Size = new System.Drawing.Size(180, 29);
            this.txt_Puz.TabIndex = 52;
            this.txt_Puz.Visible = false;
            // 
            // cb_Pantaila
            // 
            this.cb_Pantaila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Pantaila.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.cb_Pantaila.IntegralHeight = false;
            this.cb_Pantaila.Location = new System.Drawing.Point(250, 316);
            this.cb_Pantaila.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Pantaila.Name = "cb_Pantaila";
            this.cb_Pantaila.Size = new System.Drawing.Size(180, 29);
            this.cb_Pantaila.TabIndex = 57;
            this.cb_Pantaila.Visible = false;
            // 
            // cb_RMotaEdoReso
            // 
            this.cb_RMotaEdoReso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_RMotaEdoReso.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.cb_RMotaEdoReso.IntegralHeight = false;
            this.cb_RMotaEdoReso.Location = new System.Drawing.Point(472, 240);
            this.cb_RMotaEdoReso.Margin = new System.Windows.Forms.Padding(2);
            this.cb_RMotaEdoReso.Name = "cb_RMotaEdoReso";
            this.cb_RMotaEdoReso.Size = new System.Drawing.Size(180, 29);
            this.cb_RMotaEdoReso.TabIndex = 58;
            this.cb_RMotaEdoReso.Visible = false;
            // 
            // cb_SEragileaEdoInprMota
            // 
            this.cb_SEragileaEdoInprMota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SEragileaEdoInprMota.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.cb_SEragileaEdoInprMota.IntegralHeight = false;
            this.cb_SEragileaEdoInprMota.Location = new System.Drawing.Point(472, 166);
            this.cb_SEragileaEdoInprMota.Margin = new System.Windows.Forms.Padding(2);
            this.cb_SEragileaEdoInprMota.Name = "cb_SEragileaEdoInprMota";
            this.cb_SEragileaEdoInprMota.Size = new System.Drawing.Size(180, 29);
            this.cb_SEragileaEdoInprMota.TabIndex = 59;
            this.cb_SEragileaEdoInprMota.Visible = false;
            // 
            // cb_RamKantitatea
            // 
            this.cb_RamKantitatea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_RamKantitatea.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.cb_RamKantitatea.IntegralHeight = false;
            this.cb_RamKantitatea.Items.AddRange(new object[] {
            "2 GB",
            "4 GB",
            "8 GB",
            "16 GB",
            "32 GB",
            "64 GB",
            "128 GB"});
            this.cb_RamKantitatea.Location = new System.Drawing.Point(686, 166);
            this.cb_RamKantitatea.Margin = new System.Windows.Forms.Padding(2);
            this.cb_RamKantitatea.Name = "cb_RamKantitatea";
            this.cb_RamKantitatea.Size = new System.Drawing.Size(180, 29);
            this.cb_RamKantitatea.TabIndex = 61;
            this.cb_RamKantitatea.Visible = false;
            // 
            // cb_MKantitatea
            // 
            this.cb_MKantitatea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MKantitatea.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.cb_MKantitatea.IntegralHeight = false;
            this.cb_MKantitatea.Items.AddRange(new object[] {
            "16 GB",
            "32 GB",
            "64 GB",
            "128 GB",
            "256 GB",
            "512 GB",
            "1 TB"});
            this.cb_MKantitatea.Location = new System.Drawing.Point(686, 240);
            this.cb_MKantitatea.Margin = new System.Windows.Forms.Padding(2);
            this.cb_MKantitatea.Name = "cb_MKantitatea";
            this.cb_MKantitatea.Size = new System.Drawing.Size(180, 29);
            this.cb_MKantitatea.TabIndex = 63;
            this.cb_MKantitatea.Visible = false;
            // 
            // cb_Bateria
            // 
            this.cb_Bateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Bateria.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.cb_Bateria.IntegralHeight = false;
            this.cb_Bateria.Items.AddRange(new object[] {
            "1000 mAh",
            "1500 mAh",
            "2000 mAh",
            "2500 mAh",
            "3000 mAh",
            "3500 mAh",
            "4000 mAh",
            "4500 mAh",
            "5000 mAh",
            "5500 mAh",
            "6000 mAh",
            "6500 mAh",
            "7000 mAh",
            "8000 mAh"});
            this.cb_Bateria.Location = new System.Drawing.Point(686, 318);
            this.cb_Bateria.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Bateria.Name = "cb_Bateria";
            this.cb_Bateria.Size = new System.Drawing.Size(180, 29);
            this.cb_Bateria.TabIndex = 65;
            this.cb_Bateria.Visible = false;
            // 
            // GailuaGehitu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 544);
            this.Controls.Add(this.bt_Reset);
            this.Controls.Add(this.bt_GGehitu);
            this.Controls.Add(this.cb_Bateria);
            this.Controls.Add(this.label_Bateria);
            this.Controls.Add(this.cb_MKantitatea);
            this.Controls.Add(this.label_MKantitatea);
            this.Controls.Add(this.cb_RamKantitatea);
            this.Controls.Add(this.label_RAM);
            this.Controls.Add(this.cb_SEragileaEdoInprMota);
            this.Controls.Add(this.cb_RMotaEdoReso);
            this.Controls.Add(this.cb_Pantaila);
            this.Controls.Add(this.cb_Mintegia);
            this.Controls.Add(this.label_RMotaEdoReso);
            this.Controls.Add(this.label_Puz);
            this.Controls.Add(this.txt_Puz);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Label_SistemaEdoInprMota);
            this.Controls.Add(this.dtp_ErosketaData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Desc);
            this.Controls.Add(this.label_Pantaila);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_ErosketaData);
            this.Controls.Add(this.label_Modeloa);
            this.Controls.Add(this.txt_Modeloa);
            this.Controls.Add(this.label_marka);
            this.Controls.Add(this.txt_Marka);
            this.Controls.Add(this.label_SerieZBK);
            this.Controls.Add(this.txt_SerieZbk);
            this.Controls.Add(this.Gailua_CB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gGehitu_TXT);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1318, 710);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(920, 583);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(920, 583);
            this.Name = "GailuaGehitu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSB INBENTARIOA | Gailua Gehitu";
            this.Load += new System.EventHandler(this.GailuaGehitu_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label gGehitu_TXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Gailua_CB;
        private System.Windows.Forms.TextBox txt_SerieZbk;
        private System.Windows.Forms.Label label_SerieZBK;
        private System.Windows.Forms.Label label_marka;
        private System.Windows.Forms.TextBox txt_Marka;
        private System.Windows.Forms.Label label_Modeloa;
        private System.Windows.Forms.TextBox txt_Modeloa;
        private System.Windows.Forms.Label label_Pantaila;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_ErosketaData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Desc;
        private System.Windows.Forms.DateTimePicker dtp_ErosketaData;
        private System.Windows.Forms.Label Label_SistemaEdoInprMota;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_Puz;
        private System.Windows.Forms.Label label_RMotaEdoReso;
        private System.Windows.Forms.ComboBox cb_Mintegia;
        private System.Windows.Forms.Label label_RAM;
        private System.Windows.Forms.Label label_MKantitatea;
        private System.Windows.Forms.Label label_Bateria;
        private System.Windows.Forms.Button bt_GGehitu;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.TextBox txt_Puz;
        private System.Windows.Forms.ComboBox cb_Pantaila;
        private System.Windows.Forms.ComboBox cb_RMotaEdoReso;
        private System.Windows.Forms.ComboBox cb_SEragileaEdoInprMota;
        private System.Windows.Forms.ComboBox cb_RamKantitatea;
        private System.Windows.Forms.ComboBox cb_MKantitatea;
        private System.Windows.Forms.ComboBox cb_Bateria;
    }
}