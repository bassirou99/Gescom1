using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESCOM.CLASSE
{
    class CLS_Article
    {
        private DBGescomContext db = new DBGescomContext();
        private Article Ar;

        public bool Add_Article(string reference, string lib,int stk, string prix,int combocategorie)
        {
            Ar = new Article();
            Ar.Reference_Article = reference;
            Ar.Libelle_Article = lib;
            Ar.Prix_Article = prix;
            Ar.Stock_Article = stk;
            Ar.ID_Categorie = combocategorie;
      

            if (db.Articles.SingleOrDefault(a=>a.Reference_Article== reference) == null)
            {
                db.Articles.Add(Ar);
                db.SaveChanges();
                return true;
            }else
            {
                return false;
            }
        }
    }
}
