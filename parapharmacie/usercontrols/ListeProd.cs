using MySqlConnector;
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
    public partial class ListeProd : UserControl
    {

        DataTable dataTable = new DataTable();
        MySqlConnection connexion = new MySqlConnection($"datasource=localhost;port=3306;username=root;password=root;database=para");
        MyConnexion c = new MyConnexion();
        String query;

        public ListeProd()
        {
            InitializeComponent();
           
        }

      

        private void ListeProd_Load(object sender, EventArgs e)
        {

            query = "select * from produit";
            DataSet ds = c.getData(query);
            List.DataSource = ds.Tables[0];
         


        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM produit where nom like '" + guna2TextBox1.Text + "%'";
            DataSet ds = c.getData(query);
            List.DataSource = ds.Tables[0];


        }
        string prodId;
        private void List_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            
                prodId = List.Rows[e.RowIndex].Cells[0].Value.ToString();
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez vous vraiment supprimer ce produit","Confirmation suppression!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
               
                query = "delete from produit where id = '" + prodId + "'";
                c.setData(query, "Le produit a été supprimé");
                ListeProd_Load(this, null);


            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            ListeProd_Load(this, null);
        }
    }
}
