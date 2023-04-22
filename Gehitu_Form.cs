using MySql.Data.MySqlClient;
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
    public partial class GailuaGehitu_Form : Form
    {

        // KONEXIORAKO ERABILIKO DUGUN STRING-A || CONNECTION STRING
        static string connectionString;

        public GailuaGehitu_Form(string connection)
        {
            InitializeComponent();

            connectionString = connection;
        }

        private void GailuaGehitu_Form_Load(object sender, EventArgs e)
        {
            // ZEIN TAULA DAUDEN DATU BASEAN KARGATUKO DUGU || BURDEN TABLE ROW
            TaulaIzenakLortu();

            pictureBox1.Enabled = true;
        }

        private void TaulaIzenakLortu()
        {
            //Datu basera konexioa izateko | Connect to the database using a connection string.
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                //Konexioa ireki | Connect to the database
                connection.Open();
            }
            catch
            {
                //Show an error message if the connection could not be established.
                MessageBox.Show("Ezin izan da konexioa ezarri, mesedez jarri kontaktuan mantenukoarekin.");
            }

            // Kontsulta bat sortu datu-baseko taula-izenak lortzeko | Open the connection to the database.
            string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' AND TABLE_SCHEMA='tsb_datubasea'";

            // Kontsulta exekutatzeko komando bat sortzea | Create a command to execute the query.
            MySqlCommand command = new MySqlCommand(query, connection);

            // Kontsulta exekutatu eta taularen izenak lortu | Execute the query and retrieve the table names
            MySqlDataReader reader = command.ExecuteReader();

            List<string> tableNames = new List<string>();

            while (reader.Read())
            {

                tableNames.Add(reader.GetString(0));

            }

            // Itxi MySqlDataReader objektua eta askatu baliabideak |
            // Close the MySqlDataReader object and free up resources.
            reader.Close();

            // Add the retrieved table names to the ComboBox control.
            Gailua_CB.Items.AddRange(tableNames.ToArray());

            //Taulak borratzeko. | It deletes the tables that we want
            try
            {
                Gailua_CB.Items.Remove("eraikintaula");
                Gailua_CB.Items.Remove("mintegitaula");
            }
            catch { }

            // Konexioa itxi eta baliabideak askatu |
            // Close the connection to the database and free up resources.
            connection.Close();

        }



        private void Gailua_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // MINTEGIA ComboBox-a BETE || FILL MINTEGIA CB
            MintegiaCB_Betetzen();

            // ZERBAIT AUKERATZEN DUGUN BAKOITZEAN HASIERATIK JARRIKO DUGU || RESET "PROGRAM"
            HasieranBezalaJarri();


            switch (Gailua_CB.SelectedItem)
            {

                case "inprimagailuak":

                    // INPRIMAGAILUAREN IRUDIA KARGATU || LOAD THE PRINTER IMAGE
                    pictureBox2.Image = Image.FromFile("../../Diseinua/GailuMotak/Inprimagailua.png");

                    // INPRIMAGAILUAK BEHAR DITUEN BOTOIAK AKTIBATU ||  ENABLE PRINTER BUTTONS
                    InprimagailuOpzioak();

                    break;
                    
                case "mahaigainekoak":

                    // INPRIMAGAILUAREN IRUDIA KARGATU || LOAD THE PRINTER IMAGE
                    pictureBox2.Image = Image.FromFile("../../Diseinua/GailuMotak/Mahaigainekoak.png");

                    // MAHAIGAINEKOAK BEHAR DITUEN BOTOIAK AKTIBATU || ENABLE PC BUTTONS
                    MahaigainekoOpzioak();

                    break;

                case "mobilak":

                    // INPRIMAGAILUAREN IRUDIA KARGATU || LOAD THE PRINTER IMAGE
                    pictureBox2.Image = Image.FromFile("../../Diseinua/GailuMotak/Mobilak.png");

                    break;

                case "monitoreak":

                    // INPRIMAGAILUAREN IRUDIA KARGATU || LOAD THE PRINTER IMAGE
                    pictureBox2.Image = Image.FromFile("../../Diseinua/GailuMotak/Monitorea.png");

                    break;

                case "portatilak":

                    // INPRIMAGAILUAREN IRUDIA KARGATU || LOAD THE PRINTER IMAGE
                    pictureBox2.Image = Image.FromFile("../../Diseinua/GailuMotak/Portatila.png");

                    break;

                case "telebistak":

                    // INPRIMAGAILUAREN IRUDIA KARGATU || LOAD THE PRINTER IMAGE
                    pictureBox2.Image = Image.FromFile("../../Diseinua/GailuMotak/Telebista.png");

                    break;
            }


        }

        private void HasieranBezalaJarri()
        {
            Berrabiarazi();

            // FUNTZIO HONEKIN LORTZEN DUGUNA, ZUK APLIKAZIOA IREKI DUZUNEAN BEZALA USTEA.
            txt_SerieZbk.Enabled = false;
            txt_Marka.Enabled = false;
            txt_Modeloa.Enabled = false;
            dtp_ErosketaData.Enabled = false;
            cb_Mintegia.Enabled = false;
            txt_Desc.Enabled = false;

            // INPRESORA || PRINTER
            /*if (cb_SEragileaEdoInprMota.Visible == true)
            {
                // ComboBox
                cb_SEragileaEdoInprMota.Visible = false;
                cb_SEragileaEdoInprMota.Items.Clear();
                
                // LABEL
                Label_SistemaEdoInprMota.Visible = false;
            }
            else
            {

            }*/

            
        }

        private void MintegiaCB_Betetzen()
        {
            // MINTEGIA ComboBox-a BETE || FILL MINTEGIA CB
            // KONEXIOA EDUKITZEKO || GET CONNECTION
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                //Konexioa ireki | Connect to the database
                connection.Open();
            }
            catch
            {
                //Show an error message if the connection could not be established.
                MessageBox.Show("Ezin izan da konexioa ezarri, mesedez jarri kontaktuan mantenukoarekin.");
            }

            // Kontsulta bat sortu datu-baseko taula-izenak lortzeko | Open the connection to the database.
            string selQuery = "SELECT izena FROM mintegitaula;";

            // Kontsulta exekutatzeko komando bat sortzea | Create a command to execute the query.
            MySqlCommand command = new MySqlCommand(selQuery, connection);

            // Kontsulta exekutatu eta taularen izenak lortu | Execute the query and retrieve the table names
            MySqlDataReader reader = command.ExecuteReader();

            List<string> readerList = new List<string>();

            while (reader.Read())
            {

                readerList.Add(reader.GetString(0));

            }

            // Itxi MySqlDataReader objektua eta askatu baliabideak |
            // Close the MySqlDataReader object and free up resources.
            reader.Close();

            // Add the retrieved table names to the ComboBox control.
            cb_Mintegia.Items.AddRange(readerList.ToArray());

            // Konexioa itxi eta baliabideak askatu |
            // Close the connection to the database and free up resources.
            connection.Close();
        }

        private void InprimagailuOpzioak()
        {

            // BEHAR DITUEN BOTOIAK KARGATU || LOAD NEEDED BUTTOMS
            txt_SerieZbk.Enabled = true;
            txt_Marka.Enabled = true;
            txt_Modeloa.Enabled = true;
            dtp_ErosketaData.Enabled = true;
            cb_Mintegia.Enabled = true;
            txt_Desc.Enabled = true;

            // RESET BOTOIA AKTIBATU || ACTIVATE RESET BUTTOM
            bt_Reset.Enabled = true;

            // INPRESORA MOTAK BETETZEN || LOAD PRINTER TYPES
            string[] mota = { "Tinta", "Laser", "LED", "Puntu-Matriz", "Tinta-Sublimazioa", "Termikoa", "3D" };
            cb_SEragileaEdoInprMota.Items.AddRange(mota);

            Label_SistemaEdoInprMota.Text = "Inprimagailu Motak";

            // INPRESORA MOTAK AKTIBATU || ACTIVATE PRINTER TYPES OPTIONS
            cb_SEragileaEdoInprMota.Visible = true;
            Label_SistemaEdoInprMota.Visible = true;

        }

        private void MahaigainekoOpzioak()
        {
            // BEHAR DITUEN BOTOIAK KARGATU || LOAD NEEDED BUTTOMS
            txt_SerieZbk.Enabled = true;
            txt_Marka.Enabled = true;
            txt_Modeloa.Enabled = true;
            dtp_ErosketaData.Enabled = true;
            cb_Mintegia.Enabled = true;
            txt_Desc.Enabled = true;

            // RESET BOTOIA AKTIBATU || ACTIVATE RESET BUTTOM
            bt_Reset.Enabled = true;

            // MAHAIGAINEKO MOTAK BETETZEN || LOAD PRINTER TYPES
            string[] sEragilea = { "Windows 11", "Windows 10", "Windows 7/8.1", "macOS", "Linux" };
            cb_SEragileaEdoInprMota.Items.AddRange(sEragilea);

            string[] rMota = { "DDR", "DDR2", "DDR3", "DDR4", "DDR5" };
            cb_RMotaEdoReso.Items.AddRange(rMota);

            Label_SistemaEdoInprMota.Text = "Sistema Eragilea";

            // MAHAIGAINEKO MOTAK AKTIBATU || ACTIVATE PRINTER TYPES OPTIONS
            cb_SEragileaEdoInprMota.Visible= true;
            txt_Puz.Visible = true;
            cb_RamKantitatea.Visible = true;
            cb_RMotaEdoReso.Visible = true;
            cb_MKantitatea.Visible = true;

        }



        private void txt_SerieZbk_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // LEIHO HAU ITXI || CLOSE WINDOW
            this.Close();
        }

        private void txt_Marka_TextChanged(object sender, EventArgs e)
        {

        }



        private void bt_Reset_Click(object sender, EventArgs e)
        {
            // BERRABIARAZTEKO FUNTZIOA EJEKUTATU || EXECUTE RESET FUNCTION
            Berrabiarazi();

        }

        private void Berrabiarazi()
        {
            // AUKERATUTAKO EDO IDATZITAKO BALIOAK BERRABIARAZI || RESET VALUES
            txt_SerieZbk.ResetText();
            txt_Marka.ResetText();
            txt_Modeloa.ResetText();
            txt_Desc.ResetText();
            dtp_ErosketaData.ResetText();
            cb_Mintegia.SelectedItem = null;

            cb_Pantaila.SelectedItem = null;
            cb_SEragileaEdoInprMota = null;
            cb_RMotaEdoReso.SelectedItem = null;
            txt_Puz.ResetText();
            cb_RamKantitatea.SelectedItem = null;
            cb_MKantitatea.SelectedItem = null;
            cb_Bateria.SelectedItem = null;
        }
    }
}
