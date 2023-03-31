using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSB_Inbentarioa
{
    public partial class Bistaratu : Form
    {

        //Administradorea baldin bada, programak aukera diferenteak izango ditu.
        bool admin = false;


        public Bistaratu()
        {
            InitializeComponent();
        }

        public Bistaratu(bool administrador)
        {
            InitializeComponent();

            //Administradorea baldin bada, programak aukera diferenteak izango ditu.
            admin = administrador;

        }

        private void Bistaratu_Load(object sender, EventArgs e)
        {
            if (admin == true)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void Reset_BT_Click(object sender, EventArgs e)
        {
            //Lehioaren tamaina berriz bere lekura bueltatu.
            Size = new Size(459, 280);

            //Gailua aukera (Combo box) reseteatu
            Gailua_CB.SelectedItem = null;

            //Atributuen aukera (Combo box) reseteatu
            Atributuak_CB.SelectedItem = null;

            //Hasiera data reseteatu
            HasieraData.ResetText();

            //Bukaera data reseteatu
            BukaeraData.ResetText();

            //Datuen aukera (Combo box) reseteatu
            DatuZehatza_CB.SelectedItem = null;

        }

        private void Bidali_BT_Click(object sender, EventArgs e)
        {
            Size = new Size(459, 483);
        }

        private void Gailua_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Gailua_CB.SelectedItem != null)
            {
                Atributuak_CB.Enabled = true;
            }
            else
            {
                Atributuak_CB.Enabled = false;
            }

        }

        private void Atributuak_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

            string data = "EskaeraData";

            if (Atributuak_CB.SelectedItem != null)
            {
                if (Atributuak_CB.SelectedItem.Equals(data))
                {

                    //Hemen fecha datuak aukeratzerakoan aktibatuko diren kalendarioak
                    HasieraData.Enabled = true;
                    BukaeraData.Enabled = true;

                    //Datu zehatzak desaktibatu.
                    DatuZehatza_CB.Enabled = false;

                }
                else
                {
                    //Data aukerak desaktibatu.
                    HasieraData.Enabled = false;
                    BukaeraData.Enabled = false;

                    //Datu zehatzak combo box aktibatu
                    DatuZehatza_CB.Enabled = true;

                }
            }
            else
            {
                //Data aukerak desaktibatu.
                HasieraData.Enabled = false;
                BukaeraData.Enabled = false;

                //Datu zehatzak desaktibatu
                DatuZehatza_CB.Enabled = false;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
