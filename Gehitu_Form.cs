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
            // Gailuren bat, aukeratzerakoan, hurrengo combobox-a aktibatuko den edo ez, esaten diogu.
            // When we select the Gailu combo box, the next one will be available, if we dont select any gailu it will be disabled
            string taulaIzena;
            
            switch (Gailua_CB.SelectedItem)
            {


                case "inprimagailuak":

                    // INPRIMAGAILUAREN IRUDIA KARGATU || LOAD THE PRINTER IMAGE
                    pictureBox2.Image = Image.FromFile("../../Diseinua/GailuMotak/Inprimagailua.png");

                    //Inprimagailuak aukeratzerakoan beteko diren datuak | The information that it will be filled when we select inprimagailuak
                    taulaIzena = "inprimagailuak";
                    

                    break;
                case "mahaigainekoak":

                    //Mahaigainekoak aukeratzerakoan beteko diren datuak. | The information that it will be filled when we select mahaiganekoak
                    taulaIzena = "mahaigainekoak";
                    

                    break;
                case "mobilak":

                    //Mobilak aukeratzerakoan beteko diren datuak. | The information that it will be filled when we select mobilak
                    taulaIzena = "mobilak";

                    break;
                case "monitoreak":

                    //Monitoreak aukeratzerakoan beteko diren datuak. | The information that it will be filled when we select monitoreak
                    taulaIzena = "monitoreak";

                    break;
                case "portatilak":

                    //Portatilak aukeratzerakoan beteko diren datuak. | The information that it will be filled when we select portatilak
                    taulaIzena = "portatilak";

                    break;
                case "telebistak":

                    //Telebistak aukeratzerakoan beteko diren datuak. | The information that it will be filled when we select telebistak
                    taulaIzena = "telebistak";

                    break;

            }


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
    }
}
