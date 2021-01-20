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
    public partial class ArrestatieOpenForm : Form
    {
        public ArrestatieOpenForm()
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
            cmd = new SqlCommand("UPDATE tbl_case SET waarneming=@wrn, datumvoor=@date, samenvattingVerdachte=@svv, samenvattingGetuige=@svg WHERE meldingsnummer=@nr", sqlConn); ;
            cmd2 = new SqlCommand("UPDATE  tbl_Persoon SET vNaam=@vnm, aNaam=@anm, bsn=@bsn WHERE meldingsnummer=@nr", sqlConn);
            cmd.Parameters.AddWithValue("@wrn", txtEigenWN.Text);
            cmd.Parameters.AddWithValue("@date", txtDate.Text);
            cmd.Parameters.AddWithValue("@svv", txtVhVerdachte.Text);
            cmd.Parameters.AddWithValue("@svg", txtVhGetuige.Text);
            cmd.Parameters.AddWithValue("@nr", txtTemp.Text);
            cmd2.Parameters.AddWithValue("@vnm",txtVnaam.Text);
            cmd2.Parameters.AddWithValue("@anm", txtAnaam.Text);
            cmd2.Parameters.AddWithValue("@bsn", txtBsn.Text);
            cmd2.Parameters.AddWithValue("@nr", txtTemp.Text );
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            sqlConn.Close();
            this.Close();
        }
    }
}