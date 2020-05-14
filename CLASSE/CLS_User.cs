using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESCOM.CLASSE
{
    class CLS_User
    {
        private DBGescomContext db = new DBGescomContext();
        private Utilisateur Ur;

        public bool Save_User(string nlogin, string passwd, string nom, string prenom, int idprofil)
        {
            Ur = new Utilisateur();
            Ur.nom_login = nlogin;
            Ur.mdp = passwd;
            Ur.nom = nom;
            Ur.prenom = prenom;
            Ur.ID_Profil = idprofil;

            if (db.Utilisateurs.SingleOrDefault(s=>s.nom_login==nlogin && s.mdp == passwd)==null)
            {
                db.Utilisateurs.Add(Ur);
                db.SaveChanges();
                return true;
            }else
            {
                return false;
            }
        }


    }
}
