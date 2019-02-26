using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstraite2
{
    class Patron : Employe
    {
        static float _CA = 10000000;
        double _pourcentage;


        /// <summary>
        /// Constructeur patron
        /// </summary>
        /// <param name="myName"></param>
        /// <param name="myFirstName"></param>
        /// <param name="myBirthDate"></param>
        /// <param name="myMatricule"></param>
        /// <param name="myPourcentage"></param>
        public Patron(string myName, string myFirstName, DateTime myBirthDate, string myMatricule, double myPourcentage) : base(myName, myFirstName, myBirthDate, myMatricule)
        {
            this._pourcentage = myPourcentage;
        }

        /// <summary>
        /// méthode getsalaire
        /// </summary>
        /// <returns>salaire d'un patron</returns>
        public override double GetSalaire()
        {
            double Salaire = _CA * this._pourcentage / 100;
            return Salaire;
        }

        /// <summary>
        /// méthode tostring
        /// </summary>
        /// <returns>Description d'un patron</returns>
        public override string ToString()
        {
            string str = "Patron\n" + base.ToString();
            str += "\nSalaire : " + this.GetSalaire() + " euros";
            return str;
        }
    }
}
