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
    public partial class Kredituak : Form
    {
        public Kredituak()
        {
            InitializeComponent();
        }

        private void WO_BT_Click(object sender, EventArgs e)
        {
            // BISTARATUAREN KONSTRUKTOREARI HOTS EGITEKO || CALL THE BUILDER OF "Bistaratu"
            using (WebOrria_Form WebOrria = new WebOrria_Form())
            {
                try
                {
                    // Hide honekin, hasiera lehioa kentzea/ixkutatzea lortze deu.
                    this.Hide();

                    // Behin aurreko hide ejekutatzen denean, "ShowDialog"-ekin hurrengo leixue irikiko deu.
                    WebOrria.ShowDialog();

                    // Behin dana egin eta gero, ixkutun daon aplikaixue berriro irakutsiko dugu
                    this.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ezin izan da lehio ireki: " + ex.Message);
                }
            }


        }

        private void Kredituak_Load(object sender, EventArgs e)
        {

            MessageBox.Show("Ixkutuko leiho bat topatu duzu!");


        }

        private void Ander_Ibanez_Click(object sender, EventArgs e)
        {

            string ander = "https://www.instagram.com/anderibanez_/";

            try
            {

                System.Diagnostics.Process.Start(ander);

            }
            catch (Exception)
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
            catch (Exception)
            {

                MessageBox.Show("Ezin izan da web orria ireki, kontaktatu teknikariarekin mesedez: " + e);

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string ander = "https://www.instagram.com/anderibanez_/";

            try
            {

                System.Diagnostics.Process.Start(ander);

            }
            catch (Exception)
            {

                MessageBox.Show("Ezin izan da web orria ireki, kontaktatu teknikariarekin mesedez: " + e);

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string lander = "https://www.instagram.com/lander_chamorro/";

            try
            {

                System.Diagnostics.Process.Start(lander);

            }
            catch (Exception)
            {

                MessageBox.Show("Ezin izan da web orria ireki, kontaktatu teknikariarekin mesedez: " + e);

            }
        }
    }
}
