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
    public partial class Modification : UserControl
    {
        MyConnexion c = new MyConnexion();
        String query;
        public Modification()
        {
            InitializeComponent();
        }

     
        private void PrixTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (IdText.Text != "")
            {
                query="select * from produit where id ='"+ IdText.Text + "'";
                DataSet ds = c.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    NomTxt.Text = ds.Tables[0].Rows[0][1].ToString();
                    NumTxt.Text = ds.Tables[0].Rows[0][2].ToString();
                    Datepro.Text = ds.Tables[0].Rows[0][3].ToString();
                    DateExp.Text = ds.Tables[0].Rows[0][4].ToString();
                    PrixTxt.Text = ds.Tables[0].Rows[0][5].ToString();
                    QuantTxt.Text = ds.Tables[0].Rows[0][6].ToString();
                    guna2ComboBox1.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("Pas de produit trouvé");
                }
            }
            else
            {
                NomTxt.Clear();
                NumTxt.Clear();
                Datepro.ResetText();
                DateExp.ResetText();
                PrixTxt.Clear();
                QuantTxt.Clear();
                guna2ComboBox1.ResetText();
                if(guna2TextBox1.Text != "0")
                {
                    guna2TextBox1.Text = "0";

                }
                else
                {
                    guna2TextBox1.Text = "0";
                }
            }
        }

        Int64 totalQuntie;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String nom = NomTxt.Text;
            String num = NumTxt.Text;
            String datep = Datepro.Text;
            String datee = DateExp.Text;
            String categorie = guna2ComboBox1.Text;
            Int64 quantite = Int64.Parse(QuantTxt.Text);
            Int64 addquantite = Int64.Parse(guna2TextBox1.Text);
            Int64 prix = Int64.Parse(PrixTxt.Text);

            totalQuntie = quantite + addquantite;

            query = "update produit set nom='" + nom + "', numero='" + num + "', date_prod='" + datep + "',date_exp='" + datee + "' ,prix='" + prix + "',  quantite='" + totalQuntie + "',categorie='" + categorie + "' where nom='"+NomTxt.Text+ "'";
            c.setData(query, "Produi a été modifié");
            NomTxt.Clear();
            NumTxt.Clear();
            Datepro.ResetText();
            DateExp.ResetText();
            PrixTxt.Clear();
            QuantTxt.Clear();
            guna2ComboBox1.ResetText();

        }
    }
}
