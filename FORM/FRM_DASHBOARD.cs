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
    public partial class FRM_DASHBOARD : Form
    {
        public FRM_DASHBOARD()
        {
            InitializeComponent();
        }

        void desactiverForm()
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_DASHBOARD_Load(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if(!pnlaficher.Controls.Contains(USER_LIST.Instance))
            {
                pnlaficher.Controls.Add(USER_LIST.Instance);
                USER_LIST.Instance.Dock = DockStyle.Fill;
                USER_LIST.Instance.BringToFront();
            }else
            {
                USER_LIST.Instance.BringToFront();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlaficher_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnArticle_Click(object sender, EventArgs e)
        {
            if (!pnlaficher.Controls.Contains(USER_LIST_PRODUIT.Instance))
            {
                pnlaficher.Controls.Add(USER_LIST_PRODUIT.Instance);
                USER_LIST_PRODUIT.Instance.Dock = DockStyle.Fill;
                USER_LIST_PRODUIT.Instance.BringToFront();
            }
            else
            {
                USER_LIST_PRODUIT.Instance.BringToFront();
            }
        }

        private void btnAjoutC_Click(object sender, EventArgs e)
        {
        }
    }
}
