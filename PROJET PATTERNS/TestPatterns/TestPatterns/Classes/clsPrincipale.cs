using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TestPatterns.Classes
{
    class clsPrincipale
    {
        SqlConnection con = null; // Etablir la connexion a la base de donnees 
        SqlCommand cmd = null; // Executer une commande dans une base de donnees
        SqlDataAdapter dt = null; // Lire les donnees 
        SqlDataReader dr = null; // LIre les donnees liste apres ligne
        DataSet ds = null; // convertir les donnees sous forme d'un tableau

        void innitialiseConnection()
        {
            con = new SqlConnection(clsConnexion.chemin);
        }

        public static clsPrincipale _instance = null;

        public static clsPrincipale GetInstance()
        {
            if (_instance == null)
                _instance = new clsPrincipale();
            return _instance;
        }

        public DataTable Chargement(string nomTable)
        {
            innitialiseConnection();
            con.Open();
            cmd = new SqlCommand("SELECT * FROM " + nomTable + "", con);
            dt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dt.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }
        public void Supprimer(string nomTable,string chamId,string valeur)
        {
            innitialiseConnection();
            con.Open();
            cmd = new SqlCommand("DELETE FROM "+nomTable+" WHERE "+chamId+"=@id", con);
            cmd.Parameters.AddWithValue("@id", valeur);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void chargeCombo(System.Windows.Forms.ComboBox cmb, string nomChamp, string nomTable)
        {
            innitialiseConnection();
            if (!con.State.ToString().Trim().ToLower().Equals("open")) con.Open();
            using (IDbCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = @"select distinct " + nomChamp + " from " + nomTable + "";

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    string de = rd[nomChamp].ToString();
                    cmb.Items.Add(de);
                }
                rd.Close();
                rd.Dispose();
                cmd.Dispose();
            }
        }


        public void EnregistrerClient(tClient cl)
        {
            innitialiseConnection();
            con.Open();
            cmd = new SqlCommand("INSERT INTO tClient values (@noms,@adresse,@contact)", con);
            cmd.Parameters.AddWithValue("@noms", cl.Noms);
            cmd.Parameters.AddWithValue("@adresse", cl.Adresse);
            cmd.Parameters.AddWithValue("@contact", cl.Contact);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ModifierClient(tClient cl)
        {
            con = new SqlConnection("server=DESKTOP-P64AINK;database=labo_db;uid=sa;pwd=bbbbbb");
            con.Open();
            cmd = new SqlCommand("UPDATE tClient SET noms=@noms,adresse=@adresse,contact=@contact WHERE id=@id ", con);
            cmd.Parameters.AddWithValue("@id", cl.Id);
            cmd.Parameters.AddWithValue("@noms", cl.Noms);
            cmd.Parameters.AddWithValue("@adresse", cl.Adresse);
            cmd.Parameters.AddWithValue("@contact", cl.Contact);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void EnregistrerCategorie(tCategorie cat)
        {
            con = new SqlConnection("server=DESKTOP-P64AINK;database=labo_db;uid=sa;pwd=bbbbbb");
            con.Open();
            cmd = new SqlCommand("INSERT INTO tCategorie values (@designation)", con);
            cmd.Parameters.AddWithValue("@designation", cat.Designation);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ModifierCategorie(tCategorie cat)
        {
            con = new SqlConnection("server=DESKTOP-P64AINK;database=labo_db;uid=sa;pwd=bbbbbb");
            con.Open();
            cmd = new SqlCommand("UPDATE tCategorie SET designation=@designation WHERE id=@id ", con);
            cmd.Parameters.AddWithValue("@id", cat.Id);
            cmd.Parameters.AddWithValue("@designation", cat.Designation);
            cmd.ExecuteNonQuery();
            con.Close();
        }





    }
}
