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
    public partial class Baja : Form
    {

        // KONEXIORAKO ERABILIKO DUGUN STRING-A || CONNECTION STRING
        static string connectionString = "Server=localhost;Database=tsb_datubasea;Uid=root;Pwd=Ander123;";

        public Baja()
        {
            InitializeComponent();
        }

        private void Baja_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;

            // DATU BASEAREN BARRUAN ZEIN TAULA DAUDEN ESANGO DIGUNA || IT WILL TELL US WHICH TABLES ARE INSIDE
            TaulaIzenakLortu();
        }

        private void Reset_BT_Click(object sender, EventArgs e)
        {
            // LEIHOAREN TAMAINA BERRIZ BERE LEKURA BUELTATU || RETURNS THE INITIAL SIZE OF THE WINDOW
            Size = new Size(459, 280);

            // BOTOIAK EDO AUKERAK BERRABIARAZI || RESET BUTTOMS
            BotoiakBerrabiarazi();

            // BISTARATZE LEIHOA GARBITU EGITEN DU || IT CLEANS THE DataGridView WINDOW
            dataGridView1.DataSource = null;
        }

        private void BotoiakBerrabiarazi()
        {

            //Gailua aukera (Combo box) reseteatu || It reset to null the Gailua combo box
            Gailua_CB.SelectedItem = null;

            //Atributuen aukera (Combo box) reseteatu || It clears the kolumnak combo box
            kolumnak_CB.Items.Clear();

            //Hasiera data reseteatu || It reset to null the HasieraData
            HasieraDataTime.ResetText();

            //Bukaera data reseteatu || It reset to null the BukaeraData
            BukaeraDataTime.ResetText();

            //Datuen aukera (Combo box) reseteatu || It reset to null the DatuZehatza combo box
            DatuZehatza_CB.SelectedItem = null;

            //Datuen aukera desabilitatu egiten du || It disable the DatuZehatza combo box
            DatuZehatza_CB.Enabled = false;

            // BERRABIARAZI KONTAGAILUA || RESET ROW COUNT
            ZKop_TXT.Text = "ZUTABE KOPURUA: 0";

        }

        private void Bidali_BT_Click(object sender, EventArgs e)
        {
            // Bistarazeko taula irakusteko.
            // Size = new Size(459, 483);

            // Konexioa ezartzeko string-a
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                // KONEXIOA IREKI || OPEN CONNECTION
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Datu basearekin konexioa ezin izan da ebatzi." + e);
                throw;
            }

            /* DATUAK LORTZEKO || OBTEIN DATA */
            // TAULA
            string gailuMota = "";

            // KOLUMNA
            string datuMota = "";

            // DATU ZEHATZA
            string datuZehatza = "";

            // HASIERA DATA
            string hasieraData = "";

            // BUKAERA DATA
            string bukaeraData = "";

            // KONEXIOAREN STRING
            string selQuery = "";

            /* DATUAK BISTARATZEKO AUKERAK */
            if (Gailua_CB.SelectedItem == null)
            {

                // DATU BASE BARROKO DATUAK ESKURATU || IT TAKES THE DATA FOR THE TABLES (DATABASE)
                DataTable allData = new DataTable();

                // GAILUA ComboBox-ean SARTZEN DIREN TAULEN IZENAK LORTZEKO || GET THE NAME OF THE TABLE
                for (int i = 0; i < Gailua_CB.Items.Count; i++)
                {
                    // AUKERATUTAKO BALIOA EMAN || GIVE THE SELECTED VALUE
                    gailuMota = Gailua_CB.Items[i].ToString();

                    // DENAK BISTARATUKO DITUGU || SELECT TO DO THE QUERY
                    selQuery = "SELECT * FROM " + gailuMota + " ;";

                    // DATU BASETIK DATUAK BISTARATU || SHOW DATABASE DATA
                    MySqlCommand command = new MySqlCommand(selQuery, connection);

                    // DATU BASE BARROKO DATUAK ESKURATU || IT TAKES THE DATA FOR THE TABLES (DATABASE)
                    DataTable table = new DataTable();

                    // DATU BASE BARROKO DATUAK DataGridView-rea ADAPTATU || IT FILLS THE TABLE
                    MySqlDataAdapter adaptadorea = new MySqlDataAdapter(command);
                    adaptadorea.Fill(table);

                    // DATUAK DataTable PRINTZIPALERA SARTU || ENTER THE ALL DATA IN THE DataTable
                    allData.Merge(table);

                }

                // DATU GUZTIAK DataGridView BARRUAN SARTU || IT SHOWS THE ALL DATA IN THE DataGridView
                dataGridView1.DataSource = allData;

                // ESTABLECER LA PROPIEDAD NULLVALUE DE DATAGRIDVIEW A "NULL"
                dataGridView1.DefaultCellStyle.NullValue = "-";

                // DataGridView-en BARRUAN DATORIK EZ BALDIN BA DAGO || IF THE TABLE IS EMPTY
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Ez dugu datorik, saiatu berriro.");
                }

            }
            else
            {
                /* GAILU MOTA AUKERATUTA BALDIN BA DUGU || IF GAILU MOTA IS NOT NULL IT WILL ENTER HERE */
                if (kolumnak_CB.SelectedItem == null)
                {
                    // AUKERATUTAKO BALIOA EMAN || GIVE THE SELECTED VALUE
                    gailuMota = Gailua_CB.SelectedItem.ToString();

                    // DENAK BISTARATUKO DITUGU || SELECT TO DO THE QUERY
                    selQuery = "select * from " + gailuMota + ";";

                    // DATUAK TAULAN SARTZEKO || INSERT THE DATA INTO THE TABLE
                    DatuakTaulanSartu(selQuery, connection);

                }
                else
                {
                    if (kolumnak_CB.SelectedItem.ToString().Contains("erosketa_data"))
                    {
                        /* DATA AUKERATU BALDIN BA DUGU || IF DATA IS NOT NULL IT WILL ENTER HERE */

                        // SARTUTAKO DATAK LORTZEN || GET SELECTED DATE
                        DateTime dt_HasieraData = HasieraDataTime.Value.Date;
                        DateTime dt_BukaeraData = BukaeraDataTime.Value.Date;

                        // AUKERATUTAKO BALIOA EMAN || GIVE THE SELECTED VALUE
                        hasieraData = dt_HasieraData.ToString("yyyy-MM-dd");
                        bukaeraData = dt_BukaeraData.ToString("yyyy-MM-dd");
                        gailuMota = Gailua_CB.SelectedItem.ToString();
                        datuMota = kolumnak_CB.SelectedItem.ToString();

                        // DENAK BISTARATUKO DITUGU || SELECT TO DO THE QUERY
                        selQuery = "select * from " + gailuMota +
                            " where " + datuMota + " between '" + hasieraData + "' and '" + bukaeraData + "' ;";

                        if (dt_HasieraData > dt_BukaeraData)
                        {
                            // AUKERATUTAKO DATAK ONGI DAUDELA EGIAZTATU || VERIFY THE DATE
                            MessageBox.Show("Sartutako datak ez dira egokiak, saiatu berriro.");

                        }

                        // DATUAK TAULAN SARTZEKO || INSERT THE DATA INTO THE TABLE
                        DatuakTaulanSartu(selQuery, connection);

                    }
                    else if (DatuZehatza_CB.SelectedItem == null)
                    {

                        // DATU ZEHATZA EZ BADU AUKERATZEN HONERA SARTUKO DA || SELECT DATU ZEHATZA
                        MessageBox.Show("Datu zehatz bat aukeratu behar duzu, mesedez berriro saiatu.");

                    }
                    else
                    {

                        /* DATU ZEHATZA AUKERATU BALDIN BA DUGU || IF DATU ZEHATZA IS NOT NULL IT WILL ENTER HERE */

                        // AUKERATUTAKO BALIOAK EMAN || GIVE THE SELECTED VALUE
                        gailuMota = Gailua_CB.SelectedItem.ToString();
                        datuMota = kolumnak_CB.SelectedItem.ToString();
                        datuZehatza = DatuZehatza_CB.SelectedItem.ToString();

                        // "id_mintegia" DENEAN, BERRIZ ZENBAKIETARA BUELTAKO DUGU || RETURN THE "id_mintegia" NUMBER
                        if (datuMota.Equals("id_mintegia"))
                        {


                            // MINTEGIAREN ZENBAKIA LORTZEKO || GET MINTEGIA NUMBER
                            string mintegiZenbakia =
                                "select " + datuMota + " from mintegitaula where izena = '" + datuZehatza + "';";

                            // DATU BASETIK DATUAK BISTARATU || SHOW DATABASE DATA
                            MySqlCommand command = new MySqlCommand(mintegiZenbakia, connection);

                            // DATU BASETIK DATUAK IRAKURRI || READ DATABASE DATA
                            MySqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                // datuZehatza ZENBAKIRA ALDATU || CHANGE datuZehatza TO A NUMBER
                                datuZehatza = reader.GetString(0);

                            }

                            reader.Close();

                        }

                        // DENAK BISTARATUKO DITUGU || SELECT TO DO THE QUERY
                        selQuery = "select * from " + gailuMota + " where " + datuMota + " = '" + datuZehatza + "' ;";

                        // DATUAK TAULAN SARTZEKO || INSERT THE DATA INTO THE TABLE
                        DatuakTaulanSartu(selQuery, connection);

                    }
                }
            }

            // ZENBAT LERRO DAUDEN KONTATZEN DUENA || COUNT ROW
            ZKop_TXT.Text = "ZUTABE KOPURUA: " + dataGridView1.Rows.Count.ToString();

            // KONEXIOA ITXI || CLOSE CONNECTION
            connection.Close();

        }

        private void DatuakTaulanSartu(string selQuery, MySqlConnection connection)
        {
            // DATU BASETIK DATUAK BISTARATU || SHOW DATABASE DATA
            MySqlCommand command = new MySqlCommand(selQuery, connection);

            // DATU BASE BARROKO DATUAK ESKURATU || IT TAKES THE DATA FOR THE TABLES (DATABASE)
            DataTable table = new DataTable();

            // DATU BASE BARROKO DATUAK DataGridView-rea ADAPTATU || IT FILLS THE TABLE
            MySqlDataAdapter adaptadorea = new MySqlDataAdapter(command);
            adaptadorea.Fill(table);

            // DATUAK DataGridView BARRUAN SARTU || IT SHOWS THE DATA IN THE DataGridView
            dataGridView1.DataSource = table;

            // DataGridView-en BARRUAN DATORIK EZ BALDIN BA DAGO || IF THE TABLE IS EMPTY
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Ez dugu datorik, saiatu berriro.");
            }

            dataGridView1.ClearSelection();
        }

        private void Gailua_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Gailuren bat, aukeratzerakoan, hurrengo combobox-a aktibatuko den edo ez, esaten diogu.
            //When we select the Gailu combo box, the next one will be available, if we dont select any gailu it will be disabled
            if (Gailua_CB.SelectedItem != null)
            {
                kolumnak_CB.Enabled = true;
            }
            else
            {
                kolumnak_CB.Enabled = false;
            }


            //Zein taula aukeratu dugun jakiteko. | Here we select the table that we want.
            string taulaIzena;

            switch (Gailua_CB.SelectedItem)
            {


                case "inprimagailuak":

                    //Inprimagailuak aukeratzerakoan beteko diren datuak | The information that it will be filled when we select inprimagailuak
                    taulaIzena = "inprimagailuak";
                    ColumnakLortu(taulaIzena);

                    break;
                case "mahaigainekoak":

                    //Mahaigainekoak aukeratzerakoan beteko diren datuak. | The information that it will be filled when we select mahaiganekoak
                    taulaIzena = "mahaigainekoak";
                    ColumnakLortu(taulaIzena);

                    break;
                case "mobilak":

                    //Mobilak aukeratzerakoan beteko diren datuak. | The information that it will be filled when we select mobilak
                    taulaIzena = "mobilak";
                    ColumnakLortu(taulaIzena);

                    break;
                case "monitoreak":

                    //Monitoreak aukeratzerakoan beteko diren datuak. | The information that it will be filled when we select monitoreak
                    taulaIzena = "monitoreak";
                    ColumnakLortu(taulaIzena);

                    break;
                case "portatilak":

                    //Portatilak aukeratzerakoan beteko diren datuak. | The information that it will be filled when we select portatilak
                    taulaIzena = "portatilak";
                    ColumnakLortu(taulaIzena);

                    break;
                case "telebistak":

                    //Telebistak aukeratzerakoan beteko diren datuak. | The information that it will be filled when we select telebistak
                    taulaIzena = "telebistak";
                    ColumnakLortu(taulaIzena);

                    break;

            }

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

        private void ColumnakLortu(string taulaIzena)
        {

            //Aukera aldatzen dugun bakoitzean kolumnak garbitzeko |
            //Everytime we change the column, it clears.
            kolumnak_CB.Items.Clear();

            // Datu basera konexioa izateko. | Connection to the database with a string
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {

                //Konexioa ireki | Connect to the database
                connection.Open();

            }
            catch
            {

                MessageBox.Show("Ezin izan da konexioa ezarri, mesedez jarri kontaktuan mantenukoarekin.");

            }


            //Kontsulta bat sortu | Create a query
            string query = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{taulaIzena}'";

            //Kontsulta exekutatzeko | Execute query
            MySqlCommand command = new MySqlCommand(query, connection);

            //Exekutatu kolumna izenak lortzeko | Get column names
            MySqlDataReader reader = command.ExecuteReader();

            //Kolumnak gordetzeko lista | A list to save the column names
            List<string> columns = new List<string>();

            while (reader.Read())
            {

                columns.Add(reader.GetString(0));

            }

            //Konexioak ixteko | Close conection.
            reader.Close();
            connection.Close();

            //Gailuaren combo box-a bete | Add the name of the colums to the combobox.
            kolumnak_CB.Items.AddRange(columns.ToArray());
            kolumnak_CB.Items.Remove("deskribapen_orokorra");
            kolumnak_CB.Items.Remove("baja");

        }

        private void DatuZehatza_CB_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void Kolumnak_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String datana | Data string
            string data = "erosketa_data";

            if (kolumnak_CB.SelectedItem != null)
            {
                if (kolumnak_CB.SelectedItem.Equals(data))
                {

                    //Hemen fecha datuak aukeratzerakoan aktibatuko diren kalendarioak | Calendar will be activated when we select it.
                    HasieraDataTime.Enabled = true;
                    BukaeraDataTime.Enabled = true;

                    //Datu zehatzak desaktibatu. | It disable the datu zehatza combo box
                    DatuZehatza_CB.Enabled = false;

                }
                else
                {
                    //Data aukerak desaktibatu. | It disables the date
                    HasieraDataTime.Enabled = false;
                    BukaeraDataTime.Enabled = false;

                    //Datu zehatzak combo box aktibatu | It ables the datu zehatzak combo box
                    DatuZehatza_CB.Enabled = true;

                }
            }
            else
            {
                //Data aukerak desaktibatu. | It disables the date
                HasieraDataTime.Enabled = false;
                BukaeraDataTime.Enabled = false;

                //Datu zehatzak desaktibatu | It ables the datu zehatzak combo box
                DatuZehatza_CB.Enabled = false;
            }

            //Hurrengo funtziora sartu aurretik barruko datuak kenduko ditugu, baspada ere.
            //Before we enter to another function it will clear the Datu zeatzak combo box
            DatuZehatza_CB.Items.Clear();

            //Depende ze aukeratzeken, hori irakutzikoik kolumnak_CB.SelectedItem
            //Depending on what has been selected, it will be displayed in column_CB.SelectedItem. 
            KolumnaDatuakLortzen();


        }

        private void KolumnaDatuakLortzen()
        {


            // DATU BASERA KONEXIOA IZATEKO || CONNECT TO THE DATABASE USING A CONNECTION STRING
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                // Konexioa ireki || Connect to the database
                connection.Open();
            }
            catch
            {
                // Show an error message if the connection could not be westablished.
                MessageBox.Show("Ezin izan da konexioa ezarri, mesedez jarri kontaktuan mantenukoarekin.");
            }

            // DATUAK LORTZEKO || OBTAIN DATA
            string gailua = Gailua_CB.SelectedItem.ToString();
            string kolumna = kolumnak_CB.SelectedItem.ToString();

            // SELECT KOLUMNA EGITEKO || SELECT TO DO THE QUERY
            string selectQuery = "SELECT distinct " + kolumna + " FROM " + gailua;

            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            // IRAKURRI ESKATUTAKO DATUAK || IT READS THE ASKED DATA
            MySqlDataReader reader = command.ExecuteReader();

            string datuak = "";
            string id_mintegia;

            // DATUAK SARTZEKO || ENTER DATA
            while (reader.Read())
            {

                try
                {
                    id_mintegia = reader[kolumna].ToString();

                    if (kolumna.Equals("id_mintegia"))
                    {

                        // MINTEGIAREN IZENA LORTZEKO || TO GET MINTEGI IZENA
                        datuak = MintegiIzenaLortu(id_mintegia);

                        // Combox-a bete, barruko datuak irakusteko || Fill in the combo box with the data to be shown
                        DatuZehatza_CB.Items.Add(datuak);


                    }
                    else if (kolumna.Equals("baja"))
                    {
                        // DAKIGUN BEZALA, GAILUAK BAJA "BAI" EDO "EZ" BAKARRIK IZAN DEZAKETE (HORREGATIK JARTZIN DUGU ESKUZ).
                        datuak = "EZ";

                        // Combox-a bete, barruko datuak irakusteko || Fill in the combo box with the data to be shown
                        DatuZehatza_CB.Items.Add(datuak);

                        datuak = "BAI";

                        // Combox-a bete, barruko datuak irakusteko || Fill in the combo box with the data to be shown
                        DatuZehatza_CB.Items.Add(datuak);

                        break;

                    }
                    else
                    {

                        // Sartu beharreko datua || Data to be entered.
                        datuak = reader[kolumna].ToString();

                        // Combox-a bete, barruko datuak irakusteko || Fill in the combo box with the data to be shown
                        DatuZehatza_CB.Items.Add(datuak);

                    }


                }
                catch
                {

                    // Errorea ematen badu || If it gives an error
                    MessageBox.Show("Datu basetik datuak lortzeko garaian, errorea eman du, mesedez jarri mantenuarekin kontaktuan.");

                }



            }
            // Close connection || KONEXIOA ITXI
            reader.Close();
            connection.Close();

        }

        private string MintegiIzenaLortu(string id_mintegia)
        {
            // DATU BASERA KONEXIOA IZATEKO || CONNECT TO THE DATABASE USING A CONNECTION STRING
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                //Konexioa ireki | Connect to the database
                connection.Open();
            }
            catch
            {
                //Show an error message if the connection could not be westablished.
                MessageBox.Show("Ezin izan da konexioa ezarri, mesedez jarri kontaktuan mantenukoarekin.");
            }

            //Mintegi select-a | Select Mintegia
            string selectMintegia = "SELECT izena FROM mintegitaula WHERE id_mintegia = " + id_mintegia;

            string mintegiIzena = "";

            //Mintegi izena lortzeko. | With this we can get mintegi izena
            MySqlCommand command = new MySqlCommand(selectMintegia, connection);

            //Sarrerak irakurtzeko / Datuak irakurtzeko | To read the data
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                mintegiIzena = reader["izena"].ToString();

            }

            //Bukatutakoan konexioa itxiko dugu | Close connection.
            connection.Close();

            //Return the data | Datuak bueltatu 
            return mintegiIzena;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // LEIHO HAU ITXI || CLOSE WINDOW
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            // 
            if (Gailua_CB.SelectedItem == null || Gailua_CB.SelectedItem != null && kolumnak_CB.SelectedItem == null)
            {

                if (dataGridView1.SelectedRows.Count == 0)
                {
                    BajaEman_BT.Enabled = false;
                }
                else
                {
                    BajaEman_BT.Enabled = true;
                }

            }
            else if (kolumnak_CB.SelectedItem != null && DatuZehatza_CB.SelectedItem == null && HasieraDataTime.Enabled == false)
            {

                BajaEman_BT.Enabled = false;

            }
            else 
            {

                BajaEman_BT.Enabled = true;

            }

                
        }

        private void BajaEman_BT_Click(object sender, EventArgs e)
        {
            //Konexioa ezartzeko string-a || String to do the connection
            MySqlConnection connection = new MySqlConnection(connectionString);

            //Konexioa ireki || Open connection
            connection.Open();

            //Zutabea aukeratzeko || To select the row we want
            DataGridViewRow rowSelect = dataGridView1.SelectedRows[0];
            
            string gailua = Gailua_CB.SelectedItem.ToString();

            //Kontsulta sortu update-a egiteko || Create the statement to do the update query
            string query = "UPDATE  " + gailua + " SET baja = 'Bai' WHERE serie_zbk = @serie_zbk";

            //Komandoa sortzen degu gero exekutatzeko || It creates the command to excute
            MySqlCommand command = new MySqlCommand(query, connection);

            //Parametroak balioekin gehitu || Add parameters with value
            command.Parameters.AddWithValue("@serie_zbk", rowSelect.Cells["serie_zbk"].Value);

            //Komandoa exekutatu egiten du || It executes the command
            command.ExecuteNonQuery();

            //Konexioa itxi || Close connection
            connection.Close();

            //Zutabean "Bai" balorea jartzen du || In the row it puts the value "Bai"
            rowSelect.Cells["baja"].Value = "Bai";
        }
    }
}
