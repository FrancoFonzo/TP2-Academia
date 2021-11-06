
namespace UI.Desktop
{
    partial class InscripcionDesktop
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
            this.lblCondicion = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlpInscripcion = new System.Windows.Forms.TableLayoutPanel();
            this.cbxCondicion = new System.Windows.Forms.ComboBox();
            this.lblCursos = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio_calendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpInscripcion.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCondicion
            // 
            this.lblCondicion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(362, 12);
            this.lblCondicion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(70, 17);
            this.lblCondicion.TabIndex = 3;
            this.lblCondicion.Text = "Condicion";
            // 
            // lblAlumno
            // 
            this.lblAlumno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(4, 12);
            this.lblAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(55, 17);
            this.lblAlumno.TabIndex = 4;
            this.lblAlumno.Text = "Alumno";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.Location = new System.Drawing.Point(638, 12);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 33);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Location = new System.Drawing.Point(534, 12);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 33);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tlpInscripcion
            // 
            this.tlpInscripcion.AutoSize = true;
            this.tlpInscripcion.ColumnCount = 4;
            this.tlpInscripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInscripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInscripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInscripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInscripcion.Controls.Add(this.cbxCondicion, 3, 0);
            this.tlpInscripcion.Controls.Add(this.lblCursos, 0, 1);
            this.tlpInscripcion.Controls.Add(this.lblCondicion, 2, 0);
            this.tlpInscripcion.Controls.Add(this.lblAlumno, 0, 0);
            this.tlpInscripcion.Controls.Add(this.txtAlumno, 1, 0);
            this.tlpInscripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpInscripcion.Location = new System.Drawing.Point(0, 0);
            this.tlpInscripcion.Margin = new System.Windows.Forms.Padding(0);
            this.tlpInscripcion.Name = "tlpInscripcion";
            this.tlpInscripcion.RowCount = 2;
            this.tlpInscripcion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInscripcion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInscripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInscripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInscripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInscripcion.Size = new System.Drawing.Size(732, 82);
            this.tlpInscripcion.TabIndex = 7;
            // 
            // cbxCondicion
            // 
            this.cbxCondicion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCondicion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCondicion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCondicion.DisplayMember = "Condicion";
            this.cbxCondicion.Enabled = false;
            this.cbxCondicion.FormattingEnabled = true;
            this.cbxCondicion.Location = new System.Drawing.Point(441, 9);
            this.cbxCondicion.Margin = new System.Windows.Forms.Padding(5);
            this.cbxCondicion.Name = "cbxCondicion";
            this.cbxCondicion.Size = new System.Drawing.Size(286, 24);
            this.cbxCondicion.TabIndex = 9;
            // 
            // lblCursos
            // 
            this.lblCursos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCursos.AutoSize = true;
            this.tlpInscripcion.SetColumnSpan(this.lblCursos, 4);
            this.lblCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursos.Location = new System.Drawing.Point(0, 52);
            this.lblCursos.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(732, 20);
            this.lblCursos.TabIndex = 8;
            this.lblCursos.Text = "Cursos";
            this.lblCursos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAlumno
            // 
            this.txtAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlumno.Location = new System.Drawing.Point(68, 10);
            this.txtAlumno.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.ReadOnly = true;
            this.txtAlumno.Size = new System.Drawing.Size(285, 22);
            this.txtAlumno.TabIndex = 6;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnAceptar);
            this.panelButtons.Controls.Add(this.btnCancelar);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 242);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(732, 50);
            this.panelButtons.TabIndex = 8;
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materia,
            this.comision,
            this.anio_calendario});
            this.dgvCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCursos.Location = new System.Drawing.Point(0, 82);
            this.dgvCursos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowHeadersWidth = 51;
            this.dgvCursos.RowTemplate.Height = 24;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(732, 160);
            this.dgvCursos.TabIndex = 9;
            // 
            // materia
            // 
            this.materia.DataPropertyName = "Materia";
            this.materia.HeaderText = "Materia";
            this.materia.MinimumWidth = 6;
            this.materia.Name = "materia";
            this.materia.ReadOnly = true;
            // 
            // comision
            // 
            this.comision.DataPropertyName = "Comision";
            this.comision.HeaderText = "Comision";
            this.comision.MinimumWidth = 6;
            this.comision.Name = "comision";
            this.comision.ReadOnly = true;
            // 
            // anio_calendario
            // 
            this.anio_calendario.DataPropertyName = "AnioCalendario";
            this.anio_calendario.HeaderText = "Año calendario";
            this.anio_calendario.MinimumWidth = 6;
            this.anio_calendario.Name = "anio_calendario";
            this.anio_calendario.ReadOnly = true;
            // 
            // InscripcionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(732, 292);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.tlpInscripcion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InscripcionDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inscripcion";
            this.Load += new System.EventHandler(this.Cursos_Load);
            this.tlpInscripcion.ResumeLayout(false);
            this.tlpInscripcion.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TableLayoutPanel tlpInscripcion;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Label lblCursos;
        private System.Windows.Forms.ComboBox cbxCondicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio_calendario;
    }
}