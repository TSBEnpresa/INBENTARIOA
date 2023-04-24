using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSB_Inbentarioa
{
    public partial class Hasiera_Form : Form
    {

        // KONEXIORAKO ERABILIKO DUGUN STRING-A || CONNECTION STRING
        static string connectionString = "Server=localhost;Database=tsb_datubasea;Uid=root;Pwd=Ander123;";

        public Hasiera_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void Hasiera_Form_Load(object sender, EventArgs e)
        { 

        }

        private void SARTU_BT_Click(object sender, EventArgs e)
        {

            // ERABILTZAILEEN PASAHITZA || USER PASSWORD
            string adminPSW = "admin"; string langilePSW = "langilea";

            // SARTUTAKO ERABILTZAILEA ETA PASAHITZA GORDETZEKO || SAVE THE PASSWORD
            string erabiltzailea = ""; string pasahitza = "";


            try
            {
                // Erabiltzaileen izenak gordetzen dituzten string-ak, gero konparatzeko erabiliko ditugu.
                string administraria = Erabiltzaileak_CB.Items[0].ToString();
                string langilea = Erabiltzaileak_CB.Items[1].ToString();

                // Programaren login-a kontrolatuta edukitzeko.
                erabiltzailea = Erabiltzaileak_CB.SelectedItem.ToString();
                pasahitza = pasahitza_TB.Text.ToString();

                if (erabiltzailea.Equals(administraria))
                {
                    if (pasahitza.Equals(adminPSW))
                    {

                        // AdminAukerak duen konstruktoreari hotsein.
                        using (AdminAukerak admin = new AdminAukerak(erabiltzailea, connectionString))
                        {
                            try
                            {
                                // Hide honekin, hasiera lehioa kentzea/ixkutatzea lortze deu.
                                this.Hide();

                                // Behin aurreko hide ejekutatzen denean, "ShowDialog"-ekin hurrengo leixue irikiko deu.
                                admin.ShowDialog();

                                // Behin dana egin eta gero, ixkutun daon aplikaixue itxiko deu.
                                this.Close();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ezin izan da lehio ireki: " + ex.Message);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Pasahitza ez da zuzena.");
                        pasahitza_TB.Text = null;
                    }

                }
                else if(erabiltzailea.Equals(langilea))
                {

                    if (pasahitza.Equals(langilePSW))
                    {

                       // Bistaratuaren kontruktoreari hots egiteko.
                        using (Bistaratu bista = new Bistaratu(connectionString))
                        {
                            try
                            {
                                // Hide honekin, hasiera lehioa kentzea/ixkutatzea lortze deu.
                                this.Hide();

                                // Behin aurreko hide ejekutatzen denean, "ShowDialog"-ekin hurrengo leixue irikiko deu.
                                bista.ShowDialog();

                                // Behin dana egin eta gero, ixkutun daon aplikaixue itxiko deu.
                                this.Close();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ezin izan da lehio ireki: " + ex.Message);
                            }
                        }

                    }
                    else
                    {

                        MessageBox.Show("Pasahitza ez da zuzena.");
                        pasahitza_TB.Text = null;


                    }

                }
                else
                {

                    MessageBox.Show("Sartutako erabiltzailea ez da zuzena, mesedez aukeratu erabiltzaile zuzen bat edo jarri kontaktuan teknikariarekin.");
                    pasahitza_TB.Text = null;


                }
            }
            catch
            {

                MessageBox.Show("Sartutako erabiltzailea ez da zuzena, mesedez aukeratu erabiltzaile zuzen bat edo jarri kontaktuan teknikariarekin.");
                pasahitza_TB.Text = null;

            }


        }

        private void ITXI_BT_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            using (Kredituak kredituak = new Kredituak())
            {
                try
                {
                    kredituak.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ezin izan da lehio ireki: " + ex.Message);
                }
            }


        }

       
    }
}
