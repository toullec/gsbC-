using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFenetreMDI
{
    class Localite
    {

        private string codePostal;
        private string ville;

        public Localite(string codePostal, string ville)
        {

            this.codePostal = codePostal;
            this.ville = ville;
        }


        public string CodePostal
        {

            get { return codePostal; }
            set { codePostal = value; }

        }

        public string Ville
        {

            get { return ville; }
            set { ville = value; }

        }

    }
}
