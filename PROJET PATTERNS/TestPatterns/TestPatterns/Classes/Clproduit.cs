using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Classes
{
    class Clproduit
    {
        int id;
        string nom;
        decimal pu;
        int idcat;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public decimal Pu
        {
            get
            {
                return pu;
            }

            set
            {
                pu = value;
            }
        }

        public int Idcat
        {
            get
            {
                return idcat;
            }

            set
            {
                idcat = value;
            }
        }
    }
}
