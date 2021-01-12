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

namespace ROVER
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
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
            this.tbl_caseTableAdapter.Fill(this.dataSetCase.tbl_case);

        }
    }
}
