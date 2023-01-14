using MySqlConnector;
using parapharmacie.Class;
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
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            User user = new User(0, NomTxt.Text, usernametxt.Text, Convert.ToInt32(agetxt.Text), passtxt.Text, role.SelectedItem.ToString());
            MyConnexion connextion = new MyConnexion();
            connextion.open();
            MySqlCommand cmd = connextion.getConnextion().CreateCommand();

            cmd.CommandText = "INSERT INTO `user`(`id`, `fullname`, `username`, `password`, `age`, `role`) " +
                "VALUES(@id, @fullname,@username,@password,@age,@role)";
            cmd.Parameters.AddWithValue("@id", null);
            cmd.Parameters.AddWithValue("@fullname", user.Fullname);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@age", user.Age);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@role", user.Role);
            cmd.ExecuteNonQuery();

            NomTxt.Clear();
            usernametxt.Clear();
            agetxt.Clear();
            passtxt.Clear();




        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
