using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parapharmacie.Connexion
{
    internal class MyConnexion
    {
        private MySqlConnection connexion;

        public MyConnexion()
        {
           // MySqlConnection con = new MySqlConnection();
            this.connexion = new MySqlConnection($"datasource=localhost;port=3306;username=root;password=root;database=para"); ;
           // con = this.connexion;
        }

        public void open()
        {
            if (this.connexion.State != ConnectionState.Open)
            {
                this.connexion.Open();
            }
        }

        public MySqlConnection getConnextion()
        {
            return this.connexion;
        }

        public DataSet getData(String query)
        {
            MySqlConnection con = getConnextion();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        public void setData(String query,String msg)
        {
            MySqlConnection con = getConnextion();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
    }
}
