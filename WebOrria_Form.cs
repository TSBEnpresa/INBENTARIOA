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
    public partial class WebOrria_Form : Form
    {
        public WebOrria_Form()
        {
            InitializeComponent();
        }

        private void WebOrria_Form_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void BT_WebOrriaIreki_Click(object sender, EventArgs e)
        {
            string linka = "https://tsbenpresa.github.io/";

            try
            {

                System.Diagnostics.Process.Start(linka);

            }
            catch (Exception)
            {

                MessageBox.Show("Ezin izan da web orria ireki, kontaktatu teknikariarekin mesedez: " + e);

            }
        }
    }
}
