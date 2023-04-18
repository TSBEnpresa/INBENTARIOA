﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TSB_Inbentarioa
{
    public partial class Bistaratu : Form
    {

        //Administradorea baldin bada, programak aukera diferenteak izango ditu | 
        //If he's an administrator, the program will have different options.
        bool admin = false;


        public Bistaratu()
        {
            InitializeComponent();
        }

        public Bistaratu(bool administrador)
        {
            InitializeComponent();

            //Administradorea baldin bada, programak aukera diferenteak izango ditu.
            //If he's an administrator, the program will have different options.
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

            TaulaIzenakLortu();
            

        }

        private void Reset_BT_Click(object sender, EventArgs e)
        {
            //Lehioaren tamaina berriz bere lekura bueltatu | Returns the initial size of the window
            Size = new Size(459, 280);

            //Gailua aukera (Combo box) reseteatu | It reset to null the Gailua combo box
            Gailua_CB.SelectedItem = null;

            //Atributuen aukera (Combo box) reseteatu | It clears the kolumnak combo box
            kolumnak_CB.Items.Clear();

            //Hasiera data reseteatu | It reset to null the HasieraData
            HasieraData.ResetText();

            //Bukaera data reseteatu | It reset to null the BukaeraData
            BukaeraData.ResetText();

            //Datuen aukera (Combo box) reseteatu | It reset to null the DatuZehatza combo box
            DatuZehatza_CB.SelectedItem = null;

            //Datuen aukera desabilitatu egiten du | It disable the DatuZehatza combo box
            DatuZehatza_CB.Enabled = false;
            
            //Bistaratze lehioa garbitu egiten du | It cleans the datagridview window
            dataGridView1.DataSource = null;
        }

        private void Bidali_BT_Click(object sender, EventArgs e)
        {
            Size = new Size(459, 483);

            DatuakBistaratu();
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
            string connectionString = "Server=localhost;Database=tsb_datubasea;Uid=root;Pwd=lanchajim;";
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

            //Datu basera konexioa izateko. | Connection to the database with a string
            string connectionString = "Server=localhost;Database=tsb_datubasea;Uid=root;Pwd=lanchajim;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {

                //Konexioa ireki | Connect to the database
                connection.Open();

            } catch {

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

            while (reader.Read()) {

                columns.Add(reader.GetString(0));

            }

            //Konexioak ixteko | Close conection.
            reader.Close();
            connection.Close();

            //Gailuaren combo box-a bete | Add the name of the colums to the combobox.
            kolumnak_CB.Items.AddRange(columns.ToArray());
            kolumnak_CB.Items.Remove("deskribapen_orokorra");

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
                    HasieraData.Enabled = true;
                    BukaeraData.Enabled = true;

                    //Datu zehatzak desaktibatu. | It disable the datu zehatza combo box
                    DatuZehatza_CB.Enabled = false;

                }
                else
                {
                    //Data aukerak desaktibatu. | It disables the date
                    HasieraData.Enabled = false;
                    BukaeraData.Enabled = false;

                    //Datu zehatzak combo box aktibatu | It ables the datu zehatzak combo box
                    DatuZehatza_CB.Enabled = true;

                }
            }
            else
            {
                //Data aukerak desaktibatu. | It disables the date
                HasieraData.Enabled = false;
                BukaeraData.Enabled = false;

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


            //Datu basera konexioa izateko | Connect to the database using a connection string.
            string connectionString = "Server=localhost;Database=tsb_datubasea;Uid=root;Pwd=lanchajim;";
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

            //Datuak lortzeko | obtain data
            string gailua = Gailua_CB.SelectedItem.ToString();
            string kolumna = kolumnak_CB.SelectedItem.ToString();

            //Select kontsulta egiteko | Select to do the query
            string selectQuery = "SELECT " + kolumna + " FROM " + gailua;

            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            //Irakurri eskatutako datuak. | It reads the asked data
            MySqlDataReader reader = command.ExecuteReader();

            

            string datuak = "";
            string id_mintegia;

            //Datuak sartzeko | enter data
            while (reader.Read())
            {

                try
                {
                    id_mintegia = reader[kolumna].ToString();

                    if (kolumna.Equals( "id_mintegia"))
                    {

                        //Mintegiaren izena lortzeko. | To get mintegi izena
                        datuak = MintegiIzenaLortu(id_mintegia);


                    }
                    else
                    {

                        //Sartu beharreko datua. | Data to be entered.
                        datuak = reader[kolumna].ToString();

                    }


                    //Combox-a bete, barruko datuak irakusteko. | Fill in the combo box with the data to be shown
                    DatuZehatza_CB.Items.Add(datuak);


                }
                catch
                {

                    //Errorea ematen badu. | If it gives an error
                    MessageBox.Show("Datu basetik datuak lortzeko garaian, errorea eman du, mesedez jarri mantenuarekin kontaktuan.");

                }
                


            }
            //Close connection
            reader.Close();
            connection.Close();

        }

        private string MintegiIzenaLortu(string id_mintegia)
        {
            string connectionString = "Server=localhost;Database=tsb_datubasea;Uid=root;Pwd=lanchajim;";
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

            while(reader.Read()) { 

                mintegiIzena = reader["izena"].ToString();

            }

            //Bukatutakoan konexioa itxiko dugu | Close connection.
            connection.Close();

            //Return the data | Datuak bueltatu 
            return mintegiIzena;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatuakBistaratu()
        {
            string connectionString = "Server=localhost;Database=tsb_datubasea;Uid=root;Pwd=lanchajim;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            //Datuak lortzeko | obtain data
            string gailua = "";
            string kolumna = "";
            try
            {
                if (Gailua_CB.SelectedItem == null)
                {
                    MessageBox.Show("Ezin dezu aukera hau hutsa laga");
                }
                else
                {
                    gailua = Gailua_CB.SelectedItem.ToString();
                    //Select kontsulta egiteko | Select to do the query
                    string selectQuery = "SELECT * FROM " + gailua;

                    MySqlCommand command = new MySqlCommand(selectQuery, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                if (kolumnak_CB.Visible = false)
                {
                    

                }
                else if (kolumnak_CB.Visible = true)
                {
                    if (kolumnak_CB.SelectedItem == null)
                    {

                    }
                    else
                    {
                        kolumna = kolumnak_CB.SelectedItem.ToString();
                        //Select kontsulta egiteko | Select to do the query
                        string selectQuery = "SELECT " + kolumna + " FROM " + gailua;

                        MySqlCommand command = new MySqlCommand(selectQuery, connection);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
                    }

                }
            }
            catch
            {
                MessageBox.Show("Aukerarik ez duzu egin");
            }
           
        }

    }
}
