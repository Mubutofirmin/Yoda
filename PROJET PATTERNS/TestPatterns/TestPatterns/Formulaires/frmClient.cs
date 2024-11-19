using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using TestPatterns.Classes;

namespace TestPatterns.Formulaires
{
    public partial class frmClient : Form
    {


 
        void Actualiser()
        {
            txtNom.Text = "";
            txtAdresse.Text = "";
            txtContact.Text = "";
            txtId.Text = "";
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            listeClient.DataSource = clsPrincipale.GetInstance().Chargement("tClient");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Actualiser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tClient cl = new tClient();
            cl.Noms = txtNom.Text;
            cl.Adresse = txtAdresse.Text;
            cl.Contact = txtContact.Text;
            clsPrincipale.GetInstance().EnregistrerClient(cl);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tClient cl = new tClient();
            cl.Id = int.Parse(txtId.Text);
            cl.Noms = txtNom.Text;
            cl.Adresse = txtAdresse.Text;
            cl.Contact = txtContact.Text;
            clsPrincipale.GetInstance().ModifierClient(cl);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clsPrincipale.GetInstance().Supprimer("tClient", "id", txtId.Text);
        }
    }
}
