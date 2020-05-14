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
    public partial class USER_LIST : UserControl
    {

        public static USER_LIST UserList;
        private DBGescomContext db;
        private UserControl userlst;

        public static USER_LIST Instance
        {
            get
            {
                if(UserList==null)
                {
                    UserList= new USER_LIST();
                }
                return UserList;
            }
        }

        public USER_LIST(UserControl userL)
        {
            InitializeComponent();
            this.userlst = userL;

            db = new DBGescomContext();

        }

        public USER_LIST()
        {
            InitializeComponent();
            UserControl userL = null;
            this.userlst = userL;
            db = new DBGescomContext();
            comboprofil.DataSource = db.Profils.ToList();
            comboprofil.DisplayMember = "Nom_Profil";
            comboprofil.ValueMember = "ID_Profil";
        }

        public void Ajoutdatagrid()
        {
            dvgUser.Rows.Clear();
            foreach(var S in db.Utilisateurs)
            {
                dvgUser.Rows.Add(S.nom_login, S.mdp, S.nom, S.prenom);
            }
        }

        string testverif()
        {
            if (txtLog.Text == "" || txtLog.Text == "Entrer Votre Login")
            {
                return "Entrer un Login";
            }
            if (txtmdp.Text == "" || txtmdp.Text == "Enter Votre Mot de Passe")
            {
                return "Entrer un Mot de passe";
            }
            if (txtNom.Text == "" || txtNom.Text== "Entrer un Nom")
            {
                return "Entrer un Nom d'utilisateur";
            }
            if (txtPrenom.Text == "" || txtPrenom.Text== "Entrer un Prenom")
            {
                return "Entrer un Prenom d'utilisateur";
            }
            return null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void USER_LIST_Load(object sender, EventArgs e)
        {
            Ajoutdatagrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(testverif()!=null)
            { 
                MessageBox.Show(testverif(),"Obligatoire", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }else
            {
                CLASSE.CLS_User cluser = new CLASSE.CLS_User();
                if (cluser.Save_User(txtLog.Text,txtmdp.Text,txtNom.Text,txtPrenom.Text, Convert.ToInt32(comboprofil.SelectedValue))==true)
                {
                    MessageBox.Show("Utilisateur Ajouté avec succés", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (userlst as USER_LIST).Ajoutdatagrid();
                }
                else
                {
                    MessageBox.Show("Login et Mot de passe existe déja", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtLog_Enter(object sender, EventArgs e)
        {
            if(txtLog.Text=="Enter Votre Login")
            {
                txtLog.Text = "";
                txtLog.ForeColor = Color.White;
            }
        }

        private void txtmdp_Enter(object sender, EventArgs e)
        {
            if (txtmdp.Text == "Enter Votre Mot de Passe")
            {
                txtmdp.Text = "";
                txtmdp.ForeColor = Color.White;
            }
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if(txtNom.Text == "Enter Votre Nom")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.White;
            }
        }

        private void txtPrenom_Enter(object sender, EventArgs e)
        {
            if (txtPrenom.Text == "Enter Votre Prenom")
            {
                txtPrenom.Text = "";
                txtPrenom.ForeColor = Color.White;
            }

        }

        private void txtLog_Leave(object sender, EventArgs e)
        {
            if (txtLog.Text == "")
            {
                txtLog.Text = "Enter Votre Login";
                txtLog.ForeColor = Color.Silver;
            }
        }

        private void txtmdp_Leave(object sender, EventArgs e)
        {
            if (txtmdp.Text == "")
            {
                txtmdp.Text = "Enter Votre Mot de Passe";
                txtmdp.ForeColor = Color.Silver;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Enter Votre Nom";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void txtPrenom_Leave(object sender, EventArgs e)
        {
            if (txtPrenom.Text == "")
            {
                txtPrenom.Text = "Enter Votre Prenom";
                txtPrenom.ForeColor = Color.Silver;
            }
        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void profilBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dvgUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
