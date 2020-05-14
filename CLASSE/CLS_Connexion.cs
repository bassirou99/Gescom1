using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESCOM.CLASSE
{
    class CLS_Connexion
    {
        public bool ConnexionValide(DBGescomContext db,string login,string pwd)
        {
            Utilisateur U = new Utilisateur();
            U.nom_login = login;
            U.mdp = pwd;
            if(db.Utilisateurs.SingleOrDefault(s=>s.nom_login==login && s.mdp==pwd)!=null)
            {
                return true;
            }else
            {
                return false;
            }

        }

    }
}
