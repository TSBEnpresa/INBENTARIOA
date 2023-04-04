using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        }

        private void Reset_BT_Click(object sender, EventArgs e)
        {
            //Lehioaren tamaina berriz bere lekura bueltatu.
            Size = new Size(459, 280);

            //Gailua aukera (Combo box) reseteatu
            Gailua_CB.SelectedItem = null;

            //Atributuen aukera (Combo box) reseteatu
            kolumnak_CB.SelectedItem = null;

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
            //Gailuren bat, aukeratzerakoan, hurrengo combobox-a aktibatuko den edo ez, esaten diogu.
            if (Gailua_CB.SelectedItem != null)
            {
                kolumnak_CB.Enabled = true;
            }
            else
            {
                kolumnak_CB.Enabled = false;
            }


            //Datu basera konexioa izateko.
            string connectionString = "Server=localhost;Database=tsb_datubasea;Uid=root;Pwd=Ander123;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            //Zein taula aukeratu dugun jakiteko.
            string taulaIzena;

            switch (Gailua_CB.SelectedItem)
            {
            
                
                case "Inprimagailuak":

                    //Inprimagailuak aukeratzerakoan beteko diren datuak
                    taulaIzena = "Inprimagailuak";
                    ColumnakLortu(taulaIzena, connection);

                    break;
                case "Mahaigainekoak":

                    //Mahaigainekoak aukeratzerakoan beteko diren datuak.
                    taulaIzena = "Mahaigainekoak";
                    ColumnakLortu(taulaIzena, connection);

                    break;
                case "Mobilak":

                    //Mobilak aukeratzerakoan beteko diren datuak.
                    taulaIzena = "Mobilak";
                    ColumnakLortu(taulaIzena, connection);

                    break;
                case "Monitoreak":

                    //Monitoreak aukeratzerakoan beteko diren datuak.
                    taulaIzena = "Monitoreak";
                    ColumnakLortu(taulaIzena, connection);

                    break;
                case "Portatilak":

                    //Portatilak aukeratzerakoan beteko diren datuak.
                    taulaIzena = "Portatilak";
                    ColumnakLortu(taulaIzena, connection);

                    break;
                case "Telebistak":

                    //Telebistak aukeratzerakoan beteko diren datuak.
                    taulaIzena = "Telebistak";
                    ColumnakLortu(taulaIzena, connection);

                    break;

            }

        }

        private void ColumnakLortu(string taulaIzena, MySqlConnection connection)
        {

            //Aukera aldatzen dugun bakoitzean kolumnak garbitzeko.
            kolumnak_CB.Items.Clear();

            try
            {

                //Konexioa ireki | Connect to the database
                connection.Open();

            } catch {

                MessageBox.Show("Ezin izan da konexioa ezarri, mesedez jarri kontaktuan mantenukoarekin.");

            }
            

            //Kontsulta bat sortu | Create a query
            string query = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{taulaIzena}'";

            //Kontsulta exekutatzeko | execute query
            MySqlCommand command = new MySqlCommand(query, connection);

            //Exekutatu kolumna izenak lortzeko | Get colum names
            MySqlDataReader reader = command.ExecuteReader();

            //Kolumnak gordetzeko lista | A list to save the colum names
            List<string> columns = new List<string>();

            while (reader.Read()) {

                if (reader.Read().Equals("deskribapen_orokorra")) { 
                
                    //Ezerre ez du egingo, ze ez dugu nahi, deskribapena azaltzea filtroan.
                    //
                
                } else {

                    columns.Add(reader.GetString(0));

                }
            
                

            }

            //Konexioak ixteko | Close conection.
            reader.Close();
            connection.Close();

            //Gailuaren combo box-a bete | Add the name of the colums to the combobox.
            kolumnak_CB.Items.AddRange(columns.ToArray());

        }


        private void Kolumnak_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

            string data = "erosketa_data";

            if (kolumnak_CB.SelectedItem != null)
            {
                if (kolumnak_CB.SelectedItem.Equals(data))
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
