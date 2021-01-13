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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 0)
                return;

            System.Windows.Forms.Form Form = new Form();
            int count = 0;
            foreach (DataGridViewCell cell in this.dataGridView1.SelectedRows[0].Cells)
            {
                string value = cell.Value == null ? string.Empty : cell.Value.ToString();

                TextBox textBox = new TextBox()
                {
                    Text = value,
                    Top = 27 * count + 10
                };
                Form.Controls.Add(textBox);
                count++;
            }
            Form.Height = (count + 1) * 37;
            Form.Show();
        }
    }
}
