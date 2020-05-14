using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESCOM.FORM
{
    public partial class FRM_Conexion : Form
    {
        public DBGescomContext db;

        CLASSE.CLS_Connexion C = new CLASSE.CLS_Connexion();

        public FRM_Conexion()
        {
            InitializeComponent();
            db = new DBGescomContext();
        }
        
        string testconnection()
        {
            if (txtLogin.Text=="")
            {
                return "Entrer votre Login";
            }
            if (txtPwd.Text=="")
            {
                return "Entrer votre Mot de passe";
            }
            return null;
        }

        private void FRM_Conexion_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (testconnection()==null)
            {
                if(C.ConnexionValide(db,txtLogin.Text, txtPwd.Text)==true)
                {
                    MessageBox.Show("Connexion a réussi", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Connexion a échoué", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show(testconnection(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPwd_Enter(object sender, EventArgs e)
        {
            if(txtPwd.Text=="")
            {
                txtLogin.Text = "";
                txtPwd.UseSystemPasswordChar = false;
                txtPwd.PasswordChar = '*';
            }
        }
    }
}
