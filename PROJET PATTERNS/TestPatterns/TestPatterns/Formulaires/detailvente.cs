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
    public partial class detailvente : Form
    {
        public detailvente()
        {
            InitializeComponent();
        }
        public void loadlist()
        {
            tbdet.DataSource = clsPrincipale.GetInstance().Chargement("tdetailvente");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void detailvente_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Cldetail de = new Cldetail();
                de.Idprod = int.Parse(txtidprod.Text);
                de.Qte= int.Parse(txtqte.Text);
                de.Prixven= int.Parse(txtvent.Text);
                clsPrincipale.GetInstance().Enregistrerdetail(de);
                loadlist();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cldetail de = new Cldetail();
            de.Id = int.Parse(txtId.Text);
            clsPrincipale.GetInstance().Supprimer("tdetailvente", "id", txtId.Text);
            loadlist();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Cldetail de = new Cldetail();
                de.Id = int.Parse(txtId.Text);
                de.Idprod = int.Parse(txtidprod.Text);
                de.Qte = int.Parse(txtqte.Text);
                de.Prixven = int.Parse(txtvent.Text);
                clsPrincipale.GetInstance().modifierdetail(de);
                loadlist();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
