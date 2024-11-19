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
    public partial class ventefrm : Form
    {
        public ventefrm()
        {
            InitializeComponent();
        }
          
        public void loadlist()
        {
            listeClient.DataSource = clsPrincipale.GetInstance().Chargement("tvente");
        }

        private void ventefrm_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Clvente ven = new Clvente();
                ven.Date = txtdate.Text;
                ven.Idcli = int.Parse(txtcli.Text);
                clsPrincipale.GetInstance().Enregistrervente(ven);
                loadlist();
                txtId.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cbcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Clvente ven = new Clvente();
                ven.Date = txtdate.Text;
                ven.Id =int.Parse(txtId.Text);
                ven.Idcli = int.Parse(txtcli.Text);
                clsPrincipale.GetInstance().modifiervente(ven);
                loadlist();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clvente ven = new Clvente();
            ven.Id = int.Parse(txtId.Text);
            clsPrincipale.GetInstance().Supprimer("tvente", "id", txtId.Text);
            loadlist();
        }
    }
}
