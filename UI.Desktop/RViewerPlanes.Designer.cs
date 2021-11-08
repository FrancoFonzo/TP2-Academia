
namespace UI.Desktop
{
    partial class RViewerPlanes
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
            this.PlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSCursos = new UI.Desktop.DSCursos();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx1 = new System.Windows.Forms.ComboBox();
            this.lblcb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rv2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PlanTableAdapter = new UI.Desktop.DSCursosTableAdapters.PlanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCursos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlanBindingSource
            // 
            this.PlanBindingSource.DataMember = "Plan";
            this.PlanBindingSource.DataSource = this.DSCursos;
            // 
            // DSCursos
            // 
            this.DSCursos.DataSetName = "DSCursos";
            this.DSCursos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.cbx1);
            this.panel1.Controls.Add(this.lblcb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 66);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbx1
            // 
            this.cbx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx1.DisplayMember = "Plan";
            this.cbx1.FormattingEnabled = true;
            this.cbx1.Location = new System.Drawing.Point(49, 23);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(690, 21);
            this.cbx1.TabIndex = 5;
            this.cbx1.ValueMember = "ID";
            this.cbx1.SelectedIndexChanged += new System.EventHandler(this.cbx1_SelectedIndexChanged);
            // 
            // lblcb
            // 
            this.lblcb.AutoSize = true;
            this.lblcb.Location = new System.Drawing.Point(12, 26);
            this.lblcb.Name = "lblcb";
            this.lblcb.Size = new System.Drawing.Size(31, 13);
            this.lblcb.TabIndex = 4;
            this.lblcb.Text = "Plan:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rv2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 380);
            this.panel2.TabIndex = 1;
            // 
            // rv2
            // 
            this.rv2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PlanBindingSource;
            this.rv2.LocalReport.DataSources.Add(reportDataSource1);
            this.rv2.LocalReport.ReportEmbeddedResource = "UI.Desktop.REPPlanes.rdlc";
            this.rv2.Location = new System.Drawing.Point(0, 0);
            this.rv2.Name = "rv2";
            this.rv2.ServerReport.BearerToken = null;
            this.rv2.Size = new System.Drawing.Size(751, 380);
            this.rv2.TabIndex = 0;
            // 
            // PlanTableAdapter
            // 
            this.PlanTableAdapter.ClearBeforeFill = true;
            // 
            // RViewerPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 446);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RViewerPlanes";
            this.Text = "RViewerPlanes";
            this.Load += new System.EventHandler(this.RViewerPlanes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCursos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer rv2;
        private System.Windows.Forms.BindingSource PlanBindingSource;
        private DSCursos DSCursos;
        private DSCursosTableAdapters.PlanTableAdapter PlanTableAdapter;
        private System.Windows.Forms.ComboBox cbx1;
        private System.Windows.Forms.Label lblcb;
    }
}