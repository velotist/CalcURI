using System;
using System.Windows.Forms;

// Namensraum (Paket) für meine Klasse URI_Rechner_V1
namespace URI_Rechner_V1
{
    // Öffentliche Klasse mit teilweise nicht sichtbaren Dateien
    public partial class URI : Form
    {
        public URI()
        {
            // Methode zum Erzeugen der Oberfläche
            InitializeComponent();
        }

        // Methode wird nur für diese Klasse bereitgestellt, für den Button Berechne beim Daraufklicken, wurde automatisch generiert
        private void CmdBerechne_Click(object sender, EventArgs e)
        {

        }
        // Methode wird nur für diese Klasse bereitgestellt, für den Button Ende beim Daraufklicken, wurde automatisch generiert
        private void CmdEnde_Click(object sender, EventArgs e)
        {
            // Methode zum Schließen des Formulars
            Close();
        }
    }
}
