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
            string sqlQuery = "SELECT tbl_case.meldingsnummer, tbl_Persoon.vNaam,tbl_Persoon.aNaam, tbl_Persoon.bsn, tbl_case.misdrijf,tbl_case.waarneming,tbl_case.datumVoor,tbl_case.samenvattingVerdachte,tbl_case.samenvattingVerdachte";
            sqlQuery += " FROM tbl_case inner join tbl_Persoon ON tbl_case.meldingsnummer = tbl_Persoon.meldingsnummer";
            SqlCommand sqlcomm = new SqlCommand(sqlQuery, sqlConn);
            sqlConn.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            sqlConn.Close();


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
