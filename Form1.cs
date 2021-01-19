using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ROVER
{
    public partial class Form1 : Form
    {

              
        public Form1()
        {
            InitializeComponent();
            lbluName.Text = UsernameControl.Username;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        private void btnAangifte_Click(object sender, EventArgs e)
        {
            AangifteInvoerenForm aangifteInvoeren = new AangifteInvoerenForm();
            aangifteInvoeren.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchForm searchForm = new searchForm();
            searchForm.Show();
        }

        private void btnOpenAangifte_Click(object sender, EventArgs e)
        {
            ArrestatieOpenForm arrestatieOpen = new ArrestatieOpenForm();
            arrestatieOpen.Show();
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCase.tbl_case' table. You can move, or remove it, as needed.
            //  this.tbl_caseTableAdapter.Fill(this.dataSetCase.tbl_case);
            string mainconn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(mainconn);
            string sqlQuery = "SELECT tbl_case.meldingsnummer, tbl_Persoon.vNaam,tbl_Persoon.aNaam, tbl_Persoon.bsn, tbl_case.misdrijf,tbl_case.waarneming,tbl_case.datumVoor,tbl_case.samenvattingVerdachte,tbl_case.samenvattingVerdachte";
            sqlQuery += " FROM tbl_case inner join tbl_Persoon ON tbl_case.meldingsnummer = tbl_Persoon.meldingsnummer";          
            SqlCommand  sqlcomm = new SqlCommand(sqlQuery, sqlConn);
            sqlConn.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt =  new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConn.Close();

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
