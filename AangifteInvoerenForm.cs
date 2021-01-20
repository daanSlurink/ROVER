using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROVER
{
    public partial class AangifteInvoerenForm : Form  
    {

        public AangifteInvoerenForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(mainconn);
            SqlCommand cmd;
            SqlCommand cmd2;
            sqlConn.Open();
            cmd = new SqlCommand("INSERT into  tbl_case(meldingsnummer, misdrijf,waarneming,datumvoor,samenvattingVerdachte, samenvattingGetuige) VALUES('" + txtTemp.Text + "','" + txtMisdrijf.Text + "','" + txtEigenWN.Text + "',' "+txtDate.Text+"  ','" + txtVhVerdachte.Text + "','" + txtVhGetuige.Text + "')", sqlConn); ;
            cmd2 = new SqlCommand("INSERT into  tbl_Persoon(meldingsnummer, vNaam,aNaam,bsn) VALUES('" + txtTemp.Text + "','" + txtVnaam.Text + "','" + txtAnaam.Text + "','" + txtBsn.Text + "')", sqlConn);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            sqlConn.Close();
            this.Close();

            txtEigenWN.Text = string.Empty;
            txtMisdrijf.Text = string.Empty;
            txtTemp.Text = string.Empty;
            txtAnaam.Text = string.Empty;
            txtBsn.Text = string.Empty;
            txtTemp.Text = string.Empty;
            txtVhGetuige.Text = string.Empty;
            txtVhVerdachte.Text = string.Empty;
            txtVnaam.Text = string.Empty;
           
        }

        private void btnHeenzenden_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arrestant heengezonden");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("zaak gesloten, hoezee!");
        }

        private void btnInboeken_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arrestant ingeboekt, stuk tuig!");
        }
    }
}
