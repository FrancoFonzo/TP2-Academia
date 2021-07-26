
namespace UI.Desktop
{
    partial class Materias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materias));
            this.tsMaterias = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.ID_Materias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_Materias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hs_semanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hs_totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMaterias
            // 
            this.tsMaterias.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMaterias.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMaterias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsMaterias.Location = new System.Drawing.Point(0, 0);
            this.tsMaterias.Name = "tsMaterias";
            this.tsMaterias.Size = new System.Drawing.Size(800, 28);
            this.tsMaterias.TabIndex = 8;
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
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Materias,
            this.Desc_Materias,
            this.hs_semanales,
            this.hs_totales,
            this.ID_plan});
            this.dgvMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterias.Location = new System.Drawing.Point(0, 28);
            this.dgvMaterias.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersWidth = 51;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(800, 422);
            this.dgvMaterias.TabIndex = 5;
            // 
            // ID_Materias
            // 
            this.ID_Materias.HeaderText = "ID";
            this.ID_Materias.MinimumWidth = 6;
            this.ID_Materias.Name = "ID_Materias";
            this.ID_Materias.ReadOnly = true;
            // 
            // Desc_Materias
            // 
            this.Desc_Materias.HeaderText = "Descripcion";
            this.Desc_Materias.MinimumWidth = 6;
            this.Desc_Materias.Name = "Desc_Materias";
            this.Desc_Materias.ReadOnly = true;
            // 
            // hs_semanales
            // 
            this.hs_semanales.HeaderText = "Horas_Semanales";
            this.hs_semanales.MinimumWidth = 6;
            this.hs_semanales.Name = "hs_semanales";
            this.hs_semanales.ReadOnly = true;
            // 
            // hs_totales
            // 
            this.hs_totales.HeaderText = "Horas_Totales";
            this.hs_totales.MinimumWidth = 6;
            this.hs_totales.Name = "hs_totales";
            this.hs_totales.ReadOnly = true;
            // 
            // ID_plan
            // 
            this.ID_plan.HeaderText = "ID_Plan";
            this.ID_plan.MinimumWidth = 6;
            this.ID_plan.Name = "ID_plan";
            this.ID_plan.ReadOnly = true;
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.tsMaterias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Materias";
            this.Text = "Materias";
            this.tsMaterias.ResumeLayout(false);
            this.tsMaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMaterias;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Materias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Materias;
        private System.Windows.Forms.DataGridViewTextBoxColumn hs_semanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn hs_totales;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_plan;
    }
}