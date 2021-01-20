
namespace ROVER
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblInfo = new System.Windows.Forms.ToolStripLabel();
            this.lbluName = new System.Windows.Forms.ToolStripLabel();
            this.btnAangifte = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblcaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCase = new ROVER.DataSetCase();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_caseTableAdapter = new ROVER.DataSetCaseTableAdapters.tbl_caseTableAdapter();
            this.btnAddAD = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblInfo,
            this.lbluName,
            this.tsbRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(822, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblInfo
            // 
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(33, 22);
            this.lblInfo.Text = "User:";
            // 
            // lbluName
            // 
            this.lbluName.Name = "lbluName";
            this.lbluName.Size = new System.Drawing.Size(0, 22);
            // 
            // btnAangifte
            // 
            this.btnAangifte.Location = new System.Drawing.Point(13, 47);
            this.btnAangifte.Name = "btnAangifte";
            this.btnAangifte.Size = new System.Drawing.Size(115, 67);
            this.btnAangifte.TabIndex = 1;
            this.btnAangifte.Text = "Aangifte invoeren";
            this.btnAangifte.UseVisualStyleBackColor = true;
            this.btnAangifte.Click += new System.EventHandler(this.btnAangifte_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(798, 266);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tblcaseBindingSource
            // 
            this.tblcaseBindingSource.DataMember = "tbl_case";
            this.tblcaseBindingSource.DataSource = this.dataSetCase;
            // 
            // dataSetCase
            // 
            this.dataSetCase.DataSetName = "DataSetCase";
            this.dataSetCase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lopende zaken";
            // 
            // tbl_caseTableAdapter
            // 
            this.tbl_caseTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddAD
            // 
            this.btnAddAD.Location = new System.Drawing.Point(13, 120);
            this.btnAddAD.Name = "btnAddAD";
            this.btnAddAD.Size = new System.Drawing.Size(115, 83);
            this.btnAddAD.TabIndex = 8;
            this.btnAddAD.Text = "Agent Toevoegen";
            this.btnAddAD.UseVisualStyleBackColor = true;
            this.btnAddAD.Click += new System.EventHandler(this.btnAddAD_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 161);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = global::ROVER.Properties.Resources._1200px_Refresh_icon_svg;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh.Text = "Refresh";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(265, 200);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(545, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Persoon opzoeken";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddAD);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAangifte);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "ROVER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblInfo;
        private System.Windows.Forms.ToolStripLabel lbluName;
        private System.Windows.Forms.Button btnAangifte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private DataSetCase dataSetCase;
        private System.Windows.Forms.BindingSource tblcaseBindingSource;
        private DataSetCaseTableAdapters.tbl_caseTableAdapter tbl_caseTableAdapter;
        private System.Windows.Forms.Button btnAddAD;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

