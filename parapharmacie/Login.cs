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

namespace parapharmacie
{
    public partial class Login : Form
    {
        private string username;
        private string password;
        private DataTable dt = new DataTable();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            username = guna2TextBox1.Text;
            password = guna2TextBox2.Text;
            MyConnexion connextion = new MyConnexion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();
            cmd.CommandText = "SELECT *  FROM user WHERE username='" + username + "' AND password='" + password + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            List<string> data = new List<string>();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dt.Rows)
                {
                    foreach (var item in dataRow.ItemArray)
                    {
                        data.Add(item.ToString());
                    }
                }
                 Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                this.errorMessage.Visible = true;
                this.guna2TextBox2.BorderColor = Color.Red;
                this.guna2TextBox1.BorderColor = Color.Red;
            }
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
