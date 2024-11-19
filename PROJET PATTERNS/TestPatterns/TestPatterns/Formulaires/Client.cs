using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestPatterns.Classes;

namespace TestPatterns.Formulaires
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        public void loadlist()
        {
            listeClient.DataSource = clsPrincipale.GetInstance().Chargement("tclient");
        }
        void Actualiser()
        {
            txtNom.Text = "";
            txtAdresse.Text = "";
            txtContact.Text = "";
            txtId.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clsPrincipale.GetInstance().Supprimer("tClient", "id", txtId.Text);
            loadlist();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tClient cl = new tClient();
            cl.Id = int.Parse(txtId.Text);
            cl.Noms = txtNom.Text;
            cl.Adresse = txtAdresse.Text;
            cl.Contact = txtContact.Text;
            clsPrincipale.GetInstance().ModifierClient(cl);
            loadlist();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tClient cl = new tClient();
            cl.Noms = txtNom.Text;
            cl.Adresse = txtAdresse.Text;
            cl.Contact = txtContact.Text;
            clsPrincipale.GetInstance().EnregistrerClient(cl);
            loadlist();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
