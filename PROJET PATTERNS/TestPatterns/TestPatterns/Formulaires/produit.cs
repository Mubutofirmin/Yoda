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
    public partial class produit : Form
    {
        public produit()
        {
            InitializeComponent();
        }
        
        public void loadlist()
        {
            tbprod.DataSource = clsPrincipale.GetInstance().Chargement("tproduit");
        }
        void clearfield()
        {
            txtId.Text = "";
            txtnom.Text = "";
            txtpu.Text = "";
        }

        private void produit_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Clproduit prod = new Clproduit();
                prod.Nom = txtnom.Text;
                prod.Pu = int.Parse(txtpu.Text);
                prod.Idcat = int.Parse(txtcat.Text);
                clsPrincipale.GetInstance().Enregistrerprod(prod);
                loadlist();
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Clproduit prod = new Clproduit();
                prod.Id = int.Parse(txtId.Text);
                prod.Nom = txtnom.Text;
                prod.Pu = int.Parse(txtpu.Text);
                prod.Idcat = int.Parse(txtcat.Text);
                clsPrincipale.GetInstance().modifierprod(prod);
                loadlist();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Clproduit prod = new Clproduit();
                prod.Id = int.Parse(txtId.Text);
                clsPrincipale.GetInstance().Supprimer("tproduit","id",txtId.Text);
                loadlist();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
