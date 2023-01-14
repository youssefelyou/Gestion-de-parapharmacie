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
    public partial class AjoutProd : UserControl
    {
        public AjoutProd()
        {
            InitializeComponent();
            guna2ComboBox1.Items.Add("Cosmetique");
            guna2ComboBox1.Items.Add("Nutritif");
            guna2ComboBox1.Items.Add("Hygiène");
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MyConnexion connextion = new MyConnexion();
            connextion.open();
            if (NomTxt.Text != "" && NumTxt.Text != "" && PrixTxt.Text != "" && QuantTxt.Text != "")
            {
                MySqlCommand cmd = connextion.getConnextion().CreateCommand();

                cmd.CommandText = "INSERT INTO `produit`(`id`, `nom`, `numero`, `date_prod`, `date_exp`, `prix`, `quantite`,`categorie`) " +
                    "VALUES(@id , @nom , @numero , @date_prod , @date_exp , @prix , @quantite , @categorie)";
                cmd.Parameters.AddWithValue("@id", null);
                cmd.Parameters.AddWithValue("@nom", NomTxt.Text);
                cmd.Parameters.AddWithValue("@numero", NumTxt.Text);
                cmd.Parameters.AddWithValue("@date_prod", this.Datepro.Text);
                cmd.Parameters.AddWithValue("@date_exp", this.DateExp.Text);
                cmd.Parameters.AddWithValue("@prix", PrixTxt.Text);
                cmd.Parameters.AddWithValue("@quantite", QuantTxt.Text);
                cmd.Parameters.AddWithValue("@categorie", guna2ComboBox1.SelectedItem.ToString());
                
                cmd.ExecuteNonQuery();
                NomTxt.Clear();
                NumTxt.Clear();
                PrixTxt.Clear();
                QuantTxt.Clear();
                
            }
            else
            {
                MessageBox.Show("Entrer tout les champs");
            }
            
        }
    }
}
