using parapharmacie.Connexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parapharmacie.usercontrols
{
    public partial class validitycheck : UserControl
    {
        MyConnexion c = new MyConnexion();
        String query;
        public validitycheck()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(guna2ComboBox1.SelectedIndex == 0)
            {
                query = "select * from produit where date_exp >= NOW()";
                DataSet ds = c.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                label3.Text = "Médicaments validés";
                label3.ForeColor = Color.Black;
            } else if(guna2ComboBox1.SelectedIndex == 1)
            {

                query = "select * from produit where date_exp <= NOW()";
                DataSet ds = c.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                label3.Text = "Médicaments expirés";
                label3.ForeColor = Color.Black;
            }
        }

        private void validitycheck_Load(object sender, EventArgs e)
        {
            label3.Text = "";
        }
    }
}
