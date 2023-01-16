using DGVPrinterHelper;
using Guna.UI2.WinForms;
using parapharmacie.Connexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parapharmacie.usercontrols
{
    public partial class vendre : UserControl
    {
        MyConnexion c = new MyConnexion();
        String query;
        DataSet ds;
        public vendre()
        {
            InitializeComponent();
        }

        private void vendre_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "select nom from produit where date_exp >= NOW() and quantite > 0" ;
            ds = c.getData(query);
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }



        }

        private void Cherche_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "SELECT nom FROM produit where nom like '" + Cherche.Text + "%' and  date_exp >= NOW() and quantite > 0";
            DataSet ds = c.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuantTxt.Clear();
            string name = listBox1.GetItemText(listBox1.SelectedItem);
            NomTxt.Text = name;

            query = "select numero,date_exp,prix from produit where nom ='" + name + "'";
            ds = c.getData(query);
            NumTxt.Text= ds.Tables[0].Rows[0][0].ToString();
            Dateexp.Text = ds.Tables[0].Rows[0][1].ToString();
           prixTxt.Text = ds.Tables[0].Rows[0][2].ToString();

            vendre_Load(this, null);

        }

        private void QuantTxt_TextChanged(object sender, EventArgs e)
        {
            if (QuantTxt.Text != "")
            {
                Int64 prixunit = Int64.Parse(prixTxt.Text);
                Int64 quant = Int64.Parse(QuantTxt.Text);
                Int64 total = prixunit * quant;
                prixtotTxt.Text = total.ToString();
            }
            else
            {
                prixtotTxt.Clear();
            }
        }

        protected int n, totalprix = 0;
        protected Int64 quantite, newQuantite;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (NomTxt.Text != "")
            {
                query = "select quantite from produit where nom = '" + NomTxt.Text + "'";
                ds=c.getData(query);
                quantite = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantite = quantite - Int64.Parse(QuantTxt.Text);

                if(newQuantite>= 0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = NomTxt.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = NumTxt.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = Dateexp.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = prixTxt.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = QuantTxt.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = prixtotTxt.Text;

                    totalprix = totalprix + int.Parse(prixtotTxt.Text);
                    label8.Text = "MAD " + totalprix.ToString();

                    query = "update produit set quantite='" + newQuantite + "' where nom = '" + NomTxt.Text + "'";
                    c.setData(query, "Produit Ajouté");

                }
                else
                {
                    MessageBox.Show("Rupture de stock . \n il ne reste que "+quantite+"","Warning!!",MessageBoxButtons.OK,MessageBoxIcon.Warning );
                }
                ClearAll();
                vendre_Load(this, null);
            }
            else
            {
                MessageBox.Show("Choisir le produit", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
   
        }
        }
        private void ClearAll()
        {
            NomTxt.Clear();
            NumTxt.Clear();
            Dateexp.ResetText();
            QuantTxt.Clear();
            prixTxt.Clear();

        }

        int value;
        String valueNom;
        protected Int64 unit;

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Facture de Produit";
            print.SubTitle = String.Format("Date: -{0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Le prix Total " + label8.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(guna2DataGridView1);


            totalprix = 0;
            label8.Text = " MAD. 00";
            guna2DataGridView1.DataSource = 0;

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            vendre_Load(this, null);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(valueNom!= null)

              try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch (Exception) { }
                finally
                {
                    query="select quantite from produit where nom ='"+valueNom+"'";
                    ds = c.getData(query);
                    quantite = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantite = quantite + unit;

                    query = "update produit set quantite='" + newQuantite + "' where nom = '" + valueNom + "'";
                    c.setData(query, "Produit supprimé de la carte");

                    totalprix = totalprix - value;
                    label8.Text = "Mad " + totalprix.ToString();
                     
                }
            vendre_Load(this, null);
        }

        
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                value = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueNom = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                unit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception) { }
        }
    }
}
