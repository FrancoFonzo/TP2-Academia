
namespace UI.Desktop
{
    partial class Dictados
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
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.tsDocenteCurso = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.idDocenteCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyaDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.tsDocenteCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDocenteCurso,
            this.idDocente,
            this.nyaDocente,
            this.idCurso,
            this.descCurso,
            this.cargo});
            this.dgvDocentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocentes.Location = new System.Drawing.Point(0, 28);
            this.dgvDocentes.Margin = new System.Windows.Forms.Padding(5);
            this.dgvDocentes.MultiSelect = false;
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.RowHeadersWidth = 51;
            this.dgvDocentes.RowTemplate.Height = 24;
            this.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentes.Size = new System.Drawing.Size(982, 425);
            this.dgvDocentes.TabIndex = 13;
            // 
            // tsDocenteCurso
            // 
            this.tsDocenteCurso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsDocenteCurso.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsDocenteCurso.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsDocenteCurso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsDocenteCurso.Location = new System.Drawing.Point(0, 0);
            this.tsDocenteCurso.Name = "tsDocenteCurso";
            this.tsDocenteCurso.Size = new System.Drawing.Size(982, 28);
            this.tsDocenteCurso.TabIndex = 14;
            // 
            // tsbAgregar
            // 
            this.tsbAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAgregar.Image = global::UI.Desktop.Properties.Resources.plus_math_32;
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(29, 24);
            this.tsbAgregar.Text = "toolStripButton1";
            this.tsbAgregar.ToolTipText = "Agregar";
            this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = global::UI.Desktop.Properties.Resources.edit_32;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(29, 24);
            this.tsbEditar.Text = "toolStripButton2";
            this.tsbEditar.ToolTipText = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = global::UI.Desktop.Properties.Resources.delete_32;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(29, 24);
            this.tsbEliminar.Text = "toolStripButton3";
            this.tsbEliminar.ToolTipText = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // idDocenteCurso
            // 
            this.idDocenteCurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDocenteCurso.DataPropertyName = "ID";
            this.idDocenteCurso.HeaderText = "ID";
            this.idDocenteCurso.MinimumWidth = 6;
            this.idDocenteCurso.Name = "idDocenteCurso";
            this.idDocenteCurso.ReadOnly = true;
            this.idDocenteCurso.Width = 50;
            // 
            // idDocente
            // 
            this.idDocente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDocente.DataPropertyName = "DocenteId";
            this.idDocente.HeaderText = "ID_Docente";
            this.idDocente.MinimumWidth = 6;
            this.idDocente.Name = "idDocente";
            this.idDocente.ReadOnly = true;
            this.idDocente.Width = 111;
            // 
            // nyaDocente
            // 
            this.nyaDocente.DataPropertyName = "Docente";
            this.nyaDocente.HeaderText = "Docente";
            this.nyaDocente.MinimumWidth = 6;
            this.nyaDocente.Name = "nyaDocente";
            this.nyaDocente.ReadOnly = true;
            // 
            // idCurso
            // 
            this.idCurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idCurso.DataPropertyName = "CursoId";
            this.idCurso.HeaderText = "ID_Curso";
            this.idCurso.MinimumWidth = 6;
            this.idCurso.Name = "idCurso";
            this.idCurso.ReadOnly = true;
            this.idCurso.Width = 95;
            // 
            // descCurso
            // 
            this.descCurso.DataPropertyName = "Curso";
            this.descCurso.HeaderText = "Descripcion";
            this.descCurso.MinimumWidth = 6;
            this.descCurso.Name = "descCurso";
            this.descCurso.ReadOnly = true;
            // 
            // cargo
            // 
            this.cargo.DataPropertyName = "Cargo";
            this.cargo.HeaderText = "Cargo";
            this.cargo.MinimumWidth = 6;
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            // 
            // Dictados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.dgvDocentes);
            this.Controls.Add(this.tsDocenteCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dictados";
            this.Text = "Dictados";
            this.Load += new System.EventHandler(this.DocenteCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.tsDocenteCurso.ResumeLayout(false);
            this.tsDocenteCurso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.ToolStrip tsDocenteCurso;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocenteCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nyaDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn descCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
    }
}