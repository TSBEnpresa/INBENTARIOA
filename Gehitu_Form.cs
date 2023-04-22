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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            // MINTEGIA ComboBox-a BETE || FILL MINTEGIA CB
            MintegiaCB_Betetzen();

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

            // ZERBAIT AUKERATZEN DUGUN BAKOITZEAN HASIERATIK JARRIKO DUGU || RESET "PROGRAM"
            HasieranBezalaJarri();

            // GAILUA GEHITU BOTOIA AKTIBATU || ACTIVATE GAILUA GEHITU BUTTOM
            bt_GGehitu.Enabled = true;

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

                    MobilaOpzioak();

                    break;

                case "monitoreak":

                    // INPRIMAGAILUAREN IRUDIA KARGATU || LOAD THE PRINTER IMAGE
                    pictureBox2.Image = Image.FromFile("../../Diseinua/GailuMotak/Monitorea.png");

                    MonitorOpzioak();

                    break;

                case "portatilak":

                    // INPRIMAGAILUAREN IRUDIA KARGATU || LOAD THE PRINTER IMAGE
                    pictureBox2.Image = Image.FromFile("../../Diseinua/GailuMotak/Portatila.png");

                    PortatilOpzioak();

                    break;

                case "telebistak":

                    // INPRIMAGAILUAREN IRUDIA KARGATU || LOAD THE PRINTER IMAGE
                    pictureBox2.Image = Image.FromFile("../../Diseinua/GailuMotak/Telebista.png");

                    TelebistaOpzioak();

                    break;
            }


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

            // SISTEMA MOTAK BETETZEN || LOAD SISTEM TYPES
            string[] sEragilea = { "Windows 11", "Windows 10", "Windows 7/8.1", "macOS", "Linux" };
            cb_SEragileaEdoInprMota.Items.AddRange(sEragilea);

            string[] rMota = { "DDR", "DDR2", "DDR3", "DDR4", "DDR5" };
            cb_RMotaEdoReso.Items.AddRange(rMota);

            Label_SistemaEdoInprMota.Text = "Sistema Eragilea";

            // MAHAIGAINEKO MOTAK AKTIBATU || ACTIVATE PC TYPES OPTIONS
            Label_SistemaEdoInprMota.Visible = true;
            cb_SEragileaEdoInprMota.Visible= true;

            label_Puz.Visible = true;
            txt_Puz.Visible = true;

            label_RAM.Visible = true;
            cb_RamKantitatea.Visible = true;

            label_RMotaEdoReso.Visible = true;
            cb_RMotaEdoReso.Visible = true;

            label_MKantitatea.Visible = true;
            cb_MKantitatea.Visible = true;

        }

        private void MobilaOpzioak()
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

            // SISTEMA MOTAK BETETZEN || LOAD SYSTEM TYPES
            string[] sEragilea = { "Android", "iOS", "Windows Phone", "BlackBerry OS", "Tizen", "Firefox OS", "Ubuntu Touch", "Sailfish OS", "KaiOS", "HarmonyOS" };
            cb_SEragileaEdoInprMota.Items.AddRange(sEragilea);

            string[] pantailaTamaina = { "3.5\"", "4\"", "4.5\"", "5\"", "5.5\"", "6\"", "6.5\"", "7\"", "7.5\"", "8\"", "8.5\"", "9\"", "9.5\"", "10\"" };
            cb_Pantaila.Items.AddRange(pantailaTamaina);

            Label_SistemaEdoInprMota.Text = "Sistema Eragilea";

            // MOBILA MOTAK AKTIBATU || ACTIVATE PHONE TYPES OPTIONS
            Label_SistemaEdoInprMota.Visible = true;
            cb_SEragileaEdoInprMota.Visible = true;

            cb_Pantaila.Visible = true;
            label_Pantaila.Visible = true;

            cb_RamKantitatea.Visible = true;
            label_RAM.Visible = true;

            cb_Bateria.Visible = true;
            label_Bateria.Visible = true;

            label_Puz.Visible = true;
            txt_Puz.Visible = true;

            label_MKantitatea.Visible = true;
            cb_MKantitatea.Visible = true;

        }

        private void MonitorOpzioak() 
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

            // MONITORE PANTAILA MOTAK BETETZEN || LOAD RESOLUTION TYPES
            string[] pPulgadak = { "19\"", "21\"", "22\"", "24\"", "27\"", "32\"", "40\"", "42\"", "43\"", "50\"" };
            cb_Pantaila.Items.AddRange(pPulgadak);

            // MONITORE MOTAK AKTIBATU || ACTIVATE MONITORE TYPES OPTIONS
            cb_Pantaila.Visible = true;
            label_Pantaila.Visible = true;

        }

        private void PortatilOpzioak() 
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

            // MONITORE PANTAILA MOTAK BETETZEN || LOAD RESOLUTION TYPES
            string[] sEragilea = { "Windows 11", "Windows 10", "Windows 7/8.1", "macOS", "Linux" };
            cb_SEragileaEdoInprMota.Items.AddRange(sEragilea);

            string[] rMota = { "DDR", "DDR2", "DDR3", "DDR4", "DDR5" };
            cb_RMotaEdoReso.Items.AddRange(rMota);

            Label_SistemaEdoInprMota.Text = "Sistema Eragilea";

            string[] pPulgadak = { "10\"", "11\"", "12\"", "13\"", "14\"", "15\"", "16\"", "17\"", "18\"", "19\"", "20\"" };
            cb_Pantaila.Items.AddRange(pPulgadak);

            // MONITORE MOTAK AKTIBATU || ACTIVATE MONITORE TYPES OPTIONS
            cb_Pantaila.Visible = true;
            label_Pantaila.Visible = true;

            cb_SEragileaEdoInprMota.Visible = true;
            Label_SistemaEdoInprMota.Visible = true;

            cb_RMotaEdoReso.Visible = true;
            label_RMotaEdoReso.Visible = true;

            txt_Puz.Visible = true;
            label_Puz.Visible = true;

            cb_RamKantitatea.Visible = true;
            label_RAM.Visible = true;

            cb_RMotaEdoReso.Visible = true;
            label_RMotaEdoReso.Visible = true;

            cb_MKantitatea.Visible = true;
            label_MKantitatea.Visible = true;

        }

        private void TelebistaOpzioak() 
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
            string[] pTamaina = { "22\"", "24\"", "28\"", "32\"", "40\"", "42\"", "43\"", "48\"", "49\"", "50\"", 
                                    "55\"", "60\"", "65\"", "70\"", "75\"", "77\"", "80\"", "85\"" };
            cb_Pantaila.Items.AddRange(pTamaina);

            string[] resoluciones = { "1280x720", "1920x1080", "2048x1080", "2560x1440", "3840x2160", "4096x2160", "7680x4320" };
            cb_RMotaEdoReso.Items.AddRange(resoluciones);

            string[] SEragilea = { "Android TV", "WebOS", "Saphi", "Tizen", "VIDAA", "tvOS" };

            Label_SistemaEdoInprMota.Text = "Sistema Eragilea";

            // INPRESORA MOTAK AKTIBATU || ACTIVATE PRINTER TYPES OPTIONS
            cb_SEragileaEdoInprMota.Visible = true;
            Label_SistemaEdoInprMota.Visible = true;
            
            cb_Pantaila.Visible = true;
            label_Pantaila.Visible = true;

            cb_RMotaEdoReso.Visible = true;
            label_RMotaEdoReso.Visible = true;



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
            cb_SEragileaEdoInprMota.SelectedItem = null;
            cb_RMotaEdoReso.SelectedItem = null;
            txt_Puz.ResetText();
            cb_RamKantitatea.SelectedItem = null;
            cb_MKantitatea.SelectedItem = null;
            cb_Bateria.SelectedItem = null;
        }

        private void HasieranBezalaJarri()
        {
            Berrabiarazi();

            // FUNTZIO HONEKIN LORTZEN DUGUNA, ZUK APLIKAZIOA IREKI DUZUNEAN BEZALA USTEA || RESET OPTIONS

            // PANTAILA RESETEATZEKO || RESET PANTAILA OPTIONS
            if (cb_Pantaila.Visible == true)
            {
                cb_Pantaila.Items.Clear();
                cb_Pantaila.Visible = false;
                label_Pantaila.Visible = false;

            }

            // INPRIMAGAILU MOTA EDO SISTEMA ERAGILEA RESETEATZEKO || RESET OS OR PRINTER TYPE
            if (cb_SEragileaEdoInprMota.Visible == true || cb_SEragileaEdoInprMota.Items.Count > 0)
            {
                cb_SEragileaEdoInprMota.Items.Clear();
                cb_SEragileaEdoInprMota.Visible = false;
                Label_SistemaEdoInprMota.Visible = false;

            }

            // RAM MOTA EDO RESOLUZIOA AUKERAK RESETEATZEKO || RESET RAM OR RESOLUZIOA OPTIONS
            if (cb_RMotaEdoReso.Visible == true)
            {

                cb_RMotaEdoReso.Items.Clear();
                label_RMotaEdoReso.Visible = false;
                cb_RMotaEdoReso.Visible = false;

            }

            // PUZ AUKERAK RESETEATU || RESET CPU OPTIONS
            if (txt_Puz.Visible == true)
            {

                txt_Puz.Visible = false;
                label_Puz.Visible = false;

            }

            // RAM TAMAINA AUKERAK RESETEATU || RESET RAM SIZE OPTIONS
            if (cb_RamKantitatea.Visible == true)
            {
                cb_RamKantitatea.Visible = false;
                label_RAM.Visible = false;
            }

            // WDWA
            if (cb_MKantitatea.Visible == true)
            {
                cb_MKantitatea.Visible = false;
                label_MKantitatea.Visible = false;
            }

            // WDWA
            if (cb_Bateria.Visible == true)
            {
                cb_Bateria.Visible = false;
                label_Bateria.Visible = false;
            }



        }



        private void bt_GGehitu_Click(object sender, EventArgs e)
        {
            // GEHITU BOTOIARI SAKATZERAKOAN GERTATUKO DENA ||
            // WHAT IS GOING TO HAPPEN WHEN YOU PUSH "GEHITU" BUTTOM

            // KONEXIOA || CONNECTION
            MySqlConnection connection = new MySqlConnection(connectionString);

            // KONEXIOA EZARRI || CONNECTION OPEN
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Ezin izan da datu basearekin konexioa ezarri.");
                throw;
            }

            // INSERT QUERY
            string insQuery = "";

            // GAILUAN AUKERATUTAKO BALOREA GORDE || SAVE GAILUA SELECTED ITEM
            string gailuMota = Gailua_CB.SelectedItem.ToString();

            // DERRIGORREZKOAK DIREN DATUAK BETETA EDUKITZEKO ||
            // TO KEEP DATA THAT ARE RELATED TO EVERGREENS FULL IN EUSKERA
            if (!String.IsNullOrWhiteSpace(txt_SerieZbk.Text) && !String.IsNullOrWhiteSpace(txt_Marka.Text)
                && !String.IsNullOrWhiteSpace(txt_Modeloa.Text) && cb_Mintegia.SelectedItem != null)
            {
                // GAILU MOTAN ARABERA || ACCORDING TO "GAILU MOTAK"
                switch (Gailua_CB.SelectedItem)
                {
                    
                    case "inprimagailuak":

                        //Inprimagailuak aukeratzerakoan beteko diren datuak | The information that it will be filled when we select inprimagailuak
                        insQuery = "INSERT INTO " + gailuMota + " " 
                                 + "(serie_zbk, marka, modeloa, mota, erosketa_data, id_mintegia, baja, deskribapen_orokorra) " +
                                   "VALUES ()";

                        break;

                    case "mahaigainekoak":

                        //Mahaigainekoak aukeratzerakoan beteko diren datuak. | The information that it will be filled when we select mahaiganekoak
                        

                        break;

                    case "mobilak":

                        //Mobilak aukeratzerakoan beteko diren datuak. | The information that it will be filled when we select mobilak
                        

                        break;

                    case "monitoreak":

                        //Monitoreak aukeratzerakoan beteko diren datuak. | The information that it will be filled when we select monitoreak
                        

                        break;

                    case "portatilak":

                        //Portatilak aukeratzerakoan beteko diren datuak. | The information that it will be filled when we select portatilak
                        

                        break;

                    case "telebistak":

                        //Telebistak aukeratzerakoan beteko diren datuak. | The information that it will be filled when we select telebistak
                        

                        break;
                }

                string intQuery = "INSERT INTO mi_tabla (campo1, campo2, campo3) VALUES (@valor1, @valor2, @valor3)";
                MySqlCommand command = new MySqlCommand(intQuery, connection);

            }
            else
            {
                MessageBox.Show("Mesedez, gailu bati ALTA emateko, '*' duten aukerak beteta egon behar dute.");
            }

        }
    }
}
