using MySqlConnector;
using parapharmacie.Connexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parapharmacie.usercontrols
{
    public partial class uc_dashboard : UserControl
    {
        MyConnexion c = new MyConnexion();
        String query;
        DataSet ds;
        Int64 count;
        public uc_dashboard()
        {
            InitializeComponent();
        }

        private void uc_dashboard_Load(object sender, EventArgs e)
        {
            loadchart();
        }

         public void loadchart()
          {
              
              query = "select count(nom) from produit where date_exp >= NOW()";
              ds = c.getData(query);
              count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
              this.chart1.Series["Produits validés"].Points.AddXY("Validité de Produits", count);

               query = "select count(nom) from produit where date_exp <= NOW()";
               ds = c.getData(query);
               count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
               this.chart1.Series["Produits éxpirés"].Points.AddXY("Validité de Produits", count);
              
    }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Produits validés"].Points.Clear();
            chart1.Series["Produits éxpirés"].Points.Clear();
            loadchart();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
