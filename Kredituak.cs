﻿using System;
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
    public partial class Kredituak : Form
    {
        public Kredituak()
        {
            InitializeComponent();
        }

        private void WO_BT_Click(object sender, EventArgs e)
        {

            string linka = "https://tsbenpresa.github.io/";

            try { 

                System.Diagnostics.Process.Start(linka);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ezin izan da web orria ireki, kontaktatu teknikariarekin mesedez: " + e);

            }


        }

        private void Kredituak_Load(object sender, EventArgs e)
        {




        }

        private void Ander_Ibanez_Click(object sender, EventArgs e)
        {

            string ander = "https://www.instagram.com/anderibanez_/";

            try
            {

                System.Diagnostics.Process.Start(ander);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ezin izan da web orria ireki, kontaktatu teknikariarekin mesedez: " + e);

            }

        }

        private void ITXI_BT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lander_Chamorro_Click(object sender, EventArgs e)
        {

            string lander = "https://www.instagram.com/lander_chamorro/";

            try
            {

                System.Diagnostics.Process.Start(lander);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ezin izan da web orria ireki, kontaktatu teknikariarekin mesedez: " + e);

            }

        }
    }
}