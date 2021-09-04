
namespace UI.Desktop
{
    partial class Cursos
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
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.tsCursos = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añoCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.tsCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descripcion,
            this.añoCalendario,
            this.cupo,
            this.materia,
            this.comision});
            this.dgvCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCursos.Location = new System.Drawing.Point(0, 28);
            this.dgvCursos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowHeadersWidth = 51;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(800, 422);
            this.dgvCursos.TabIndex = 9;
            // 
            // tsCursos
            // 
            this.tsCursos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsCursos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsCursos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsCursos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsCursos.Location = new System.Drawing.Point(0, 0);
            this.tsCursos.Name = "tsCursos";
            this.tsCursos.Size = new System.Drawing.Size(800, 28);
            this.tsCursos.TabIndex = 0;
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
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "Descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // añoCalendario
            // 
            this.añoCalendario.DataPropertyName = "AnioCalendario";
            this.añoCalendario.HeaderText = "Año Calendario";
            this.añoCalendario.MinimumWidth = 6;
            this.añoCalendario.Name = "añoCalendario";
            this.añoCalendario.ReadOnly = true;
            // 
            // cupo
            // 
            this.cupo.DataPropertyName = "Cupo";
            this.cupo.HeaderText = "Cupo";
            this.cupo.MinimumWidth = 6;
            this.cupo.Name = "cupo";
            this.cupo.ReadOnly = true;
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
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.tsCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.tsCursos.ResumeLayout(false);
            this.tsCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.ToolStrip tsCursos;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn añoCalendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn comision;
    }
}