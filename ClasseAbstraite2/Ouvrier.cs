using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstraite2
{
    class Ouvrier : Employe
    {
        static double SMIC = 1521.22;
        DateTime _entree;

        /// <summary>
        /// Constructeur Ouvrier
        /// </summary>
        /// <param name="myName"></param>
        /// <param name="myFirstName"></param>
        /// <param name="myBirthDate"></param>
        /// <param name="myMatricule"></param>
        /// <param name="myEntree"></param>
        public Ouvrier(string myName, string myFirstName, DateTime myBirthDate, string myMatricule, DateTime myEntree) : base(myName, myFirstName, myBirthDate, myMatricule)
        {
            this._entree = myEntree;
        }

        /// <summary>
        /// méthode GetSalaire
        /// </summary>
        /// <returns>le salaire d'un ouvrier</returns>
        public override double GetSalaire() {
            int dt = Convert.ToInt32(Math.Floor((DateTime.Now - this._entree).TotalDays / 365));
            double salaire = SMIC + dt * 100;
            if ( salaire < 2 * SMIC)
            {
                return salaire;
            } else
            {
                return 2 * SMIC;
            }
        }

        /// <summary>
        /// Méthode ToString
        /// </summary>
        /// <returns>Description ouvrier</returns>
        public override string ToString()
        {
            string str = "Ouvrier\n" + base.ToString();
            str += "\nSalaire : " + this.GetSalaire() + " euros";
            return str;
        }
    }
}
