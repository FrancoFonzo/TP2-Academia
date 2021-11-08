
namespace UI.Desktop
{
    partial class RepViewer
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSCursos = new UI.Desktop.DSCursos();
            this.rv1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CursoTableAdapter = new UI.Desktop.DSCursosTableAdapters.CursoTableAdapter();
            this.academiaDBDataSet = new UI.Desktop.AcademiaDBDataSet();
            this.cursoTableAdapter1 = new UI.Desktop.AcademiaDBDataSetTableAdapters.CursoTableAdapter();
            this.cursoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblcb = new System.Windows.Forms.Label();
            this.cbx1 = new System.Windows.Forms.ComboBox();
            this.panelcbx = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).BeginInit();
            this.panelcbx.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CursoBindingSource
            // 
            this.CursoBindingSource.DataMember = "Curso";
            this.CursoBindingSource.DataSource = this.DSCursos;
            // 
            // DSCursos
            // 
            this.DSCursos.DataSetName = "DSCursos";
            this.DSCursos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rv1
            // 
            this.rv1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.CursoBindingSource;
            this.rv1.LocalReport.DataSources.Add(reportDataSource1);
            this.rv1.LocalReport.ReportEmbeddedResource = "UI.Desktop.REPCursos.rdlc";
            this.rv1.Location = new System.Drawing.Point(0, 0);
            this.rv1.Name = "rv1";
            this.rv1.ServerReport.BearerToken = null;
            this.rv1.Size = new System.Drawing.Size(685, 469);
            this.rv1.TabIndex = 0;
            // 
            // CursoTableAdapter
            // 
            this.CursoTableAdapter.ClearBeforeFill = true;
            // 
            // academiaDBDataSet
            // 
            this.academiaDBDataSet.DataSetName = "AcademiaDBDataSet";
            this.academiaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursoTableAdapter1
            // 
            this.cursoTableAdapter1.ClearBeforeFill = true;
            // 
            // cursoBindingSource1
            // 
            this.cursoBindingSource1.DataMember = "Curso";
            this.cursoBindingSource1.DataSource = this.academiaDBDataSet;
            // 
            // lblcb
            // 
            this.lblcb.AutoSize = true;
            this.lblcb.Location = new System.Drawing.Point(11, 28);
            this.lblcb.Name = "lblcb";
            this.lblcb.Size = new System.Drawing.Size(37, 13);
            this.lblcb.TabIndex = 2;
            this.lblcb.Text = "Curso:";
            this.lblcb.Click += new System.EventHandler(this.lblcb_Click);
            // 
            // cbx1
            // 
            this.cbx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx1.DisplayMember = "Curso";
            this.cbx1.FormattingEnabled = true;
            this.cbx1.Location = new System.Drawing.Point(54, 25);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(619, 21);
            this.cbx1.TabIndex = 3;
            this.cbx1.ValueMember = "ID";
            this.cbx1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panelcbx
            // 
            this.panelcbx.BackColor = System.Drawing.Color.LightGray;
            this.panelcbx.Controls.Add(this.cbx1);
            this.panelcbx.Controls.Add(this.lblcb);
            this.panelcbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcbx.Location = new System.Drawing.Point(0, 0);
            this.panelcbx.Name = "panelcbx";
            this.panelcbx.Size = new System.Drawing.Size(685, 64);
            this.panelcbx.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rv1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 469);
            this.panel1.TabIndex = 6;
            // 
            // RepViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelcbx);
            this.Name = "RepViewer";
            this.Text = "";
            this.Load += new System.EventHandler(this.RepViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).EndInit();
            this.panelcbx.ResumeLayout(false);
            this.panelcbx.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DSCursos DSCursos;
        private Microsoft.Reporting.WinForms.ReportViewer rv1;
        private DSCursosTableAdapters.CursoTableAdapter CursoTableAdapter;
        private System.Windows.Forms.BindingSource CursoBindingSource;
        private AcademiaDBDataSet academiaDBDataSet;
        private AcademiaDBDataSetTableAdapters.CursoTableAdapter cursoTableAdapter1;
        private System.Windows.Forms.BindingSource cursoBindingSource1;
        private System.Windows.Forms.Label lblcb;
        private System.Windows.Forms.ComboBox cbx1;
        private System.Windows.Forms.Panel panelcbx;
        private System.Windows.Forms.Panel panel1;
    }
}