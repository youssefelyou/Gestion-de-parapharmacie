using parapharmacie.Connexion;
using System;
using System.Collections;
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
    public partial class ListUsers : UserControl
    {
        DataTable dataTable = new DataTable();
        MyConnexion c = new MyConnexion();
        String query;
        public ListUsers()
        {
            InitializeComponent();
        }

        private void ListUsers_Load(object sender, EventArgs e)
        {
            query = "select * from user";
            DataSet ds = c.getData(query);
            Listuser.DataSource = ds.Tables[0];
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM user where fullname like '" + guna2TextBox1.Text + "%'";
            DataSet ds = c.getData(query);
            Listuser.DataSource = ds.Tables[0];
        }

        string userid;
        private void Listuser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            userid  = Listuser.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer ce utilisateur", "Confirmation suppression!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                query = "delete from user where id = '" + userid + "'";
                c.setData(query, "L'utilisateur a été supprimé");
                ListUsers_Load(this, null);
            }
        }
    }
}
