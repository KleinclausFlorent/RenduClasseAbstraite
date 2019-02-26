using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstraite2
{

    abstract class Employe
    {
        string _nom;
        string _prenom;
        DateTime _dateNaissance;
        string _matricule;

        /// <summary>
        /// Constructeur Employé
        /// </summary>
        /// <param name="myName"></param>
        /// <param name="myFirstName"></param>
        /// <param name="myBirthDate"></param>
        /// <param name="myMatricule"></param>
        public Employe(string myName, string myFirstName, DateTime myBirthDate, string myMatricule)
        {
            this._nom = myName;
            this._prenom = myFirstName;
            this._dateNaissance = myBirthDate;
            this._matricule = myMatricule;
        }

        /// <summary>
        /// Accesseurs
        /// </summary>
        public virtual string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public virtual string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public virtual DateTime Naissance
        {
            get { return _dateNaissance; }
            set { _dateNaissance = value; }
        }

        public virtual string Matricule
        {
            get { return _matricule; }
            set { _matricule = value; }
        }

        /// <summary>
        /// Méthode ToString 
        /// </summary>
        /// <returns>Le string décrivant l'employé</returns>
        public override string ToString()
        {
            string str;
            str = "Nom : " + _nom + "\nPrénom : " + _prenom + "\nDate de naissance : " + _dateNaissance + "\nMatricule : " + _matricule;
            return str;
        }

        /// <summary>
        /// Méthode getSalaire
        /// </summary>
        /// <returns>Valeur salaire</returns>
        public abstract double GetSalaire();
    }
}
