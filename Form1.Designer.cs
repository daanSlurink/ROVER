﻿
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
            this.lblVnaam = new System.Windows.Forms.ToolStripLabel();
            this.lblAnaam = new System.Windows.Forms.ToolStripLabel();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnAangifte = new System.Windows.Forms.Button();
            this.btnOpenAangifte = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataSetCase = new ROVER.DataSetCase();
            this.tblcaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_caseTableAdapter = new ROVER.DataSetCaseTableAdapters.tbl_caseTableAdapter();
            this.btnAddAD = new System.Windows.Forms.Button();
            this.meldingsnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.misdrijfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waarnemingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumVoorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.samenvattingVerdachteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.samenvattingGetuigeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblInfo,
            this.lblVnaam,
            this.lblAnaam,
            this.tsbRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(552, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblInfo
            // 
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(33, 22);
            this.lblInfo.Text = "User:";
            // 
            // lblVnaam
            // 
            this.lblVnaam.Name = "lblVnaam";
            this.lblVnaam.Size = new System.Drawing.Size(61, 22);
            this.lblVnaam.Text = "Voornaam";
            // 
            // lblAnaam
            // 
            this.lblAnaam.Name = "lblAnaam";
            this.lblAnaam.Size = new System.Drawing.Size(72, 22);
            this.lblAnaam.Text = "Achternaam";
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh.Text = "Refresh";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // btnAangifte
            // 
            this.btnAangifte.Location = new System.Drawing.Point(13, 47);
            this.btnAangifte.Name = "btnAangifte";
            this.btnAangifte.Size = new System.Drawing.Size(115, 46);
            this.btnAangifte.TabIndex = 1;
            this.btnAangifte.Text = "Aangifte invoeren";
            this.btnAangifte.UseVisualStyleBackColor = true;
            this.btnAangifte.Click += new System.EventHandler(this.btnAangifte_Click);
            // 
            // btnOpenAangifte
            // 
            this.btnOpenAangifte.Location = new System.Drawing.Point(12, 99);
            this.btnOpenAangifte.Name = "btnOpenAangifte";
            this.btnOpenAangifte.Size = new System.Drawing.Size(115, 34);
            this.btnOpenAangifte.TabIndex = 3;
            this.btnOpenAangifte.Text = "Aangifte openen";
            this.btnOpenAangifte.UseVisualStyleBackColor = true;
            this.btnOpenAangifte.Click += new System.EventHandler(this.btnOpenAangifte_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.meldingsnummerDataGridViewTextBoxColumn,
            this.misdrijfDataGridViewTextBoxColumn,
            this.waarnemingDataGridViewTextBoxColumn,
            this.datumVoorDataGridViewTextBoxColumn,
            this.samenvattingVerdachteDataGridViewTextBoxColumn,
            this.samenvattingGetuigeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblcaseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 212);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(13, 139);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 29);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Gegevens opzoeken";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 158);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // dataSetCase
            // 
            this.dataSetCase.DataSetName = "DataSetCase";
            this.dataSetCase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcaseBindingSource
            // 
            this.tblcaseBindingSource.DataMember = "tbl_case";
            this.tblcaseBindingSource.DataSource = this.dataSetCase;
            // 
            // tbl_caseTableAdapter
            // 
            this.tbl_caseTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddAD
            // 
            this.btnAddAD.Location = new System.Drawing.Point(13, 174);
            this.btnAddAD.Name = "btnAddAD";
            this.btnAddAD.Size = new System.Drawing.Size(115, 29);
            this.btnAddAD.TabIndex = 8;
            this.btnAddAD.Text = "Agent Toevoegen";
            this.btnAddAD.UseVisualStyleBackColor = true;
            // 
            // meldingsnummerDataGridViewTextBoxColumn
            // 
            this.meldingsnummerDataGridViewTextBoxColumn.DataPropertyName = "meldingsnummer";
            this.meldingsnummerDataGridViewTextBoxColumn.HeaderText = "meldingsnummer";
            this.meldingsnummerDataGridViewTextBoxColumn.Name = "meldingsnummerDataGridViewTextBoxColumn";
            // 
            // misdrijfDataGridViewTextBoxColumn
            // 
            this.misdrijfDataGridViewTextBoxColumn.DataPropertyName = "misdrijf";
            this.misdrijfDataGridViewTextBoxColumn.HeaderText = "misdrijf";
            this.misdrijfDataGridViewTextBoxColumn.Name = "misdrijfDataGridViewTextBoxColumn";
            // 
            // waarnemingDataGridViewTextBoxColumn
            // 
            this.waarnemingDataGridViewTextBoxColumn.DataPropertyName = "waarneming";
            this.waarnemingDataGridViewTextBoxColumn.HeaderText = "waarneming";
            this.waarnemingDataGridViewTextBoxColumn.Name = "waarnemingDataGridViewTextBoxColumn";
            // 
            // datumVoorDataGridViewTextBoxColumn
            // 
            this.datumVoorDataGridViewTextBoxColumn.DataPropertyName = "datumVoor";
            this.datumVoorDataGridViewTextBoxColumn.HeaderText = "datumVoor";
            this.datumVoorDataGridViewTextBoxColumn.Name = "datumVoorDataGridViewTextBoxColumn";
            // 
            // samenvattingVerdachteDataGridViewTextBoxColumn
            // 
            this.samenvattingVerdachteDataGridViewTextBoxColumn.DataPropertyName = "samenvattingVerdachte";
            this.samenvattingVerdachteDataGridViewTextBoxColumn.HeaderText = "samenvattingVerdachte";
            this.samenvattingVerdachteDataGridViewTextBoxColumn.Name = "samenvattingVerdachteDataGridViewTextBoxColumn";
            // 
            // samenvattingGetuigeDataGridViewTextBoxColumn
            // 
            this.samenvattingGetuigeDataGridViewTextBoxColumn.DataPropertyName = "samenvattingGetuige";
            this.samenvattingGetuigeDataGridViewTextBoxColumn.HeaderText = "samenvattingGetuige";
            this.samenvattingGetuigeDataGridViewTextBoxColumn.Name = "samenvattingGetuigeDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.btnAddAD);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOpenAangifte);
            this.Controls.Add(this.btnAangifte);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "ROVER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblInfo;
        private System.Windows.Forms.ToolStripLabel lblVnaam;
        private System.Windows.Forms.ToolStripLabel lblAnaam;
        private System.Windows.Forms.Button btnAangifte;
        private System.Windows.Forms.Button btnOpenAangifte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private DataSetCase dataSetCase;
        private System.Windows.Forms.BindingSource tblcaseBindingSource;
        private DataSetCaseTableAdapters.tbl_caseTableAdapter tbl_caseTableAdapter;
        private System.Windows.Forms.Button btnAddAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn meldingsnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn misdrijfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waarnemingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumVoorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn samenvattingVerdachteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn samenvattingGetuigeDataGridViewTextBoxColumn;
    }
}

