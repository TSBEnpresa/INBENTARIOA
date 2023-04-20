using Google.Protobuf.Collections;
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
    public partial class AdminAukerak : Form
    {
        // ZEIN ERABILTZAILE ERABILIKO DUGUN GORDEKO DUGUN PARAMETROA.
        string erabiltzailea;
 
        public AdminAukerak(string erabil)
        {
            InitializeComponent();

            erabiltzailea = erabil;

        }

        public AdminAukerak()
        {
            InitializeComponent();

            erabiltzailea = "Admin";

        }

        private void AdminAukerak_Load(object sender, EventArgs e)
        {

            label1.Text = label1.Text + erabiltzailea;


        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void ITXI_BT_Click(object sender, EventArgs e)
        {
            // LEIHOA ITXI || CLOSE WINDOW
            this.Close();
        }

        private void Alta_BT_Click(object sender, EventArgs e)
        {
            // GAILUEN BAJA KUDEATZEKO LEIHOA IREKIKO DUGU || IT OPENS A WINDOW TO MANAGE DEVICE STATUS
            using (GailuaGehitu_Form gehitu = new GailuaGehitu_Form())
            {

                try
                {
                    // Hide honekin, hasiera lehioa kentzea/ixkutatzea lortze deu.
                    this.Hide();

                    // Behin aurreko hide ejekutatzen denean, "ShowDialog"-ekin hurrengo leixue irikiko deu.
                    gehitu.ShowDialog();

                    // Behin dana egin eta gero, ixkutun daon aplikaixue berriro irakutsiko dugu
                    this.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ezin izan da lehio ireki: " + ex.Message);
                }

            }
        }

        private void Baja_BT_Click(object sender, EventArgs e)
        {
            // GAILUEN BAJA KUDEATZEKO LEIHOA IREKIKO DUGU || IT OPENS A WINDOW TO MANAGE DEVICE STATUS
            using (Baja baja = new Baja())
            {

                try
                {
                    // Hide honekin, hasiera lehioa kentzea/ixkutatzea lortze deu.
                    this.Hide();

                    // Behin aurreko hide ejekutatzen denean, "ShowDialog"-ekin hurrengo leixue irikiko deu.
                    baja.ShowDialog();

                    // Behin dana egin eta gero, ixkutun daon aplikaixue berriro irakutsiko dugu
                    this.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ezin izan da lehio ireki: " + ex.Message);
                }

            }

        }

        private void Bistaratu_BT_Click(object sender, EventArgs e)
        {
            bool admin = true;

            // BISTARATUAREN KONSTRUKTOREARI HOTS EGITEKO || CALL THE BUILDER OF "Bistaratu"
            using (Bistaratu bista = new Bistaratu(admin))
            {
                try
                {
                    // Hide honekin, hasiera lehioa kentzea/ixkutatzea lortze deu.
                    this.Hide();

                    // Behin aurreko hide ejekutatzen denean, "ShowDialog"-ekin hurrengo leixue irikiko deu.
                    bista.ShowDialog();

                    // Behin dana egin eta gero, ixkutun daon aplikaixue berriro irakutsiko dugu
                    this.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ezin izan da lehio ireki: " + ex.Message);
                }
            }
        }
    }
}
