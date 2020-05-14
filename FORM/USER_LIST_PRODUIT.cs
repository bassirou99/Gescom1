using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESCOM.FORM
{
    public partial class USER_LIST_PRODUIT : UserControl
    {
        public static USER_LIST_PRODUIT UserProd;
        private DBGescomContext db;
        private UserControl userArticle;

        public static USER_LIST_PRODUIT Instance
        {
            get
            {
                if (UserProd == null)
                {
                    UserProd = new USER_LIST_PRODUIT();
                }
                return UserProd;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string testverif()
        {
            if (txtRef.Text == "")
            {
                return "Entrer un référence";
            }
            if (txtLbl.Text == "")
            {
                return "Entrer un Libellé";
            }
            if (txtSck.Text == "")
            {
                return "Entrer le stock";
            }
            if (txtPrix.Text == "")
            {
                return "Entrer le prix";
            }
            return null;
        }

        public USER_LIST_PRODUIT(UserControl User)
        {
            InitializeComponent();
            db = new DBGescomContext();
            this.userArticle = User;
            combocategorie.DataSource = db.Categories.ToList();
            combocategorie.DisplayMember = "Nom_Categorie";
            combocategorie.ValueMember = "ID_Categorie";

        }

        public USER_LIST_PRODUIT()
        {
            InitializeComponent();
            db = new DBGescomContext();
            combocategorie.DataSource = db.Categories.ToList();
            combocategorie.DisplayMember = "Nom_Categorie";
            combocategorie.ValueMember = "ID_Categorie";
        }

        public void Ajoutdatagrida()
        {
            db = new DBGescomContext();
            dvgAricle.Rows.Clear();
            Categorie C = new Categorie();
            foreach(var P in db.Articles)
            {
                C = db.Categories.SingleOrDefault(s => s.ID_Categorie == P.ID_Categorie);
                if(C!=null)
                {
                    dvgAricle.Rows.Add(false,P.ID_Article,P.Reference_Article, P.Libelle_Article, P.Stock_Article, P.Prix_Article, C.Nom_Categorie);
                }
            }
        }

        private void USER_LIST_PRODUIT_Load(object sender, EventArgs e)
        {
            Ajoutdatagrida();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (testverif() != null)
            {
                MessageBox.Show(testverif(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CLASSE.CLS_Article sartcle = new CLASSE.CLS_Article();
                if (sartcle.Add_Article(txtLog.Text, txtLib.Text, int.Parse(textSck.Text), textPrix.Text, Convert.ToInt32(combocategorie.SelectedValue)) == true)
                {
                    MessageBox.Show("Articke Ajouté avec succés", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (userArticle as USER_LIST_PRODUIT).Ajoutdatagrida();
                }
                else
                {
                    MessageBox.Show("Article existe déja", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
