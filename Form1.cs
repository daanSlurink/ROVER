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

        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            lbluName.Text = UsernameControl.Username;
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
            dataGridView1.Update();
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

            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConn.Close();

        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ArrestatieOpenForm form = new ArrestatieOpenForm();
            form.txtTemp.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            form.txtVnaam.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form.txtAnaam.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            form.txtBsn.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            form.txtMisdrijf.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            form.txtEigenWN.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //form.dateTimePicker1.Value = this.dataGridView1.CurrentRow.Cells[6].Value.ToString("hh:mm tt");
            form.txtVhVerdachte.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            form.txtVhGetuige.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            form.ShowDialog();
        }

        private void btnAddAD_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("anaam like '%{0}%'", txtSearch.Text);
                dataGridView1.DataSource = dv.ToTable();
            }
        }
    }
}
