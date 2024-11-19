using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Classes
{
    class Cldetail
    {
        int id;
        int idprod;
        decimal prixven;
        int qte;

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

        public int Idprod
        {
            get
            {
                return idprod;
            }

            set
            {
                idprod = value;
            }
        }

        public decimal Prixven
        {
            get
            {
                return prixven;
            }

            set
            {
                prixven = value;
            }
        }

        public int Qte
        {
            get
            {
                return qte;
            }

            set
            {
                qte = value;
            }
        }
    }
}
