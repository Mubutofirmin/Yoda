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
using TestPatterns.Classes;

namespace TestPatterns.Formulaires
{
    public partial class frmCategorie : Form
    {
        public frmCategorie()
        {
            InitializeComponent();
        }

 
        void Actualiser()
        {
            txtDesignation.Text = "";
            txtId.Text = "";
        }


        private void frmCategorie_Load(object sender, EventArgs e)
        {
            listeClient.DataSource = clsPrincipale.GetInstance().Chargement("tCategorie");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tCategorie cat = new tCategorie();
            cat.Designation = txtDesignation.Text;
            clsPrincipale.GetInstance().EnregistrerCategorie(cat);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tCategorie cat = new tCategorie();
            cat.Designation = txtDesignation.Text;
            cat.Id = int.Parse(txtId.Text);
            clsPrincipale.GetInstance().ModifierCategorie(cat);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clsPrincipale.GetInstance().Supprimer("tCategorie", "id", txtId.Text);
        }
    }
}
