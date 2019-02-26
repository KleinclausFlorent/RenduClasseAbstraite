using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstraite2
{
    class Cadre : Employe
    {
        int _indice;

        /// <summary>
        /// Constructeur Cadre
        /// </summary>
        /// <param name="myName"></param>
        /// <param name="myFirstName"></param>
        /// <param name="myBirthDate"></param>
        /// <param name="myMatricule"></param>
        /// <param name="myIndice"></param>
        public Cadre(string myName, string myFirstName, DateTime myBirthDate, string myMatricule, int myIndice) : base(myName, myFirstName, myBirthDate, myMatricule)
        {
            this._indice = myIndice;
        }

        /// <summary>
        /// méthode getsalaire
        /// </summary>
        /// <returns>salaire d'un cadre</returns>
        public override double GetSalaire()
        {
            int ind = this._indice;
            if (ind == 1)
            {
                return 13000;
            } else if (ind == 2)
            {
                return 15000;
            }
            else if (ind == 3)
            {
                return 17000;
            }
            else if (ind == 4)
            {
                return 20000;
            } else
            {
                return 13000;
            }
        }

        /// <summary>
        /// Méthode tostring
        /// </summary>
        /// <returns>la description d'un cadre</returns>
        public override string ToString()
        {
            string str = "Cadre\n" + base.ToString();
            str += "\nSalaire : " + this.GetSalaire() + " euros";
            return str;
        }
    }
}
