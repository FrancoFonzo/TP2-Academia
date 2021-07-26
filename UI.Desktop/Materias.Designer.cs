
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
            this.tcMateria = new System.Windows.Forms.ToolStripContainer();
            this.tsMaterias = new System.Windows.Forms.ToolStrip();
            this.Nuevo = new System.Windows.Forms.ToolStripButton();
            this.Editar = new System.Windows.Forms.ToolStripButton();
            this.Eliminar = new System.Windows.Forms.ToolStripButton();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.ID_Materias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_Materias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hs_semanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hs_totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tcMateria.ContentPanel.SuspendLayout();
            this.tcMateria.TopToolStripPanel.SuspendLayout();
            this.tcMateria.SuspendLayout();
            this.tsMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMateria
            // 
            // 
            // tcMateria.ContentPanel
            // 
            this.tcMateria.ContentPanel.Controls.Add(this.btnActualizar);
            this.tcMateria.ContentPanel.Controls.Add(this.btnSalir);
            this.tcMateria.ContentPanel.Controls.Add(this.dgvMaterias);
            this.tcMateria.ContentPanel.Size = new System.Drawing.Size(600, 341);
            this.tcMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMateria.Location = new System.Drawing.Point(0, 0);
            this.tcMateria.Margin = new System.Windows.Forms.Padding(2);
            this.tcMateria.Name = "tcMateria";
            this.tcMateria.Size = new System.Drawing.Size(600, 366);
            this.tcMateria.TabIndex = 0;
            this.tcMateria.Text = "toolStripContainer1";
            // 
            // tcMateria.TopToolStripPanel
            // 
            this.tcMateria.TopToolStripPanel.Controls.Add(this.tsMaterias);
            // 
            // tsMaterias
            // 
            this.tsMaterias.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMaterias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nuevo,
            this.Editar,
            this.Eliminar});
            this.tsMaterias.Location = new System.Drawing.Point(4, 0);
            this.tsMaterias.Name = "tsMaterias";
            this.tsMaterias.Size = new System.Drawing.Size(111, 25);
            this.tsMaterias.TabIndex = 0;
            // 
            // Nuevo
            // 
            this.Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo.Image")));
            this.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Nuevo.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(23, 21);
            this.Nuevo.Text = "toolStripButton1";
            this.Nuevo.ToolTipText = "Nuevo";
            // 
            // Editar
            // 
            this.Editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Editar.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(23, 21);
            this.Editar.Text = "toolStripButton2";
            this.Editar.ToolTipText = "Editar";
            // 
            // Eliminar
            // 
            this.Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eliminar.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(23, 21);
            this.Eliminar.Text = "toolStripButton3";
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Materias,
            this.Desc_Materias,
            this.hs_semanales,
            this.hs_totales,
            this.ID_plan});
            this.dgvMaterias.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMaterias.Location = new System.Drawing.Point(0, 0);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersWidth = 51;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(600, 311);
            this.dgvMaterias.TabIndex = 1;
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
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(542, 317);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 19);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(468, 317);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(70, 19);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tcMateria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Materias";
            this.Text = "Materias";
            this.tcMateria.ContentPanel.ResumeLayout(false);
            this.tcMateria.TopToolStripPanel.ResumeLayout(false);
            this.tcMateria.TopToolStripPanel.PerformLayout();
            this.tcMateria.ResumeLayout(false);
            this.tcMateria.PerformLayout();
            this.tsMaterias.ResumeLayout(false);
            this.tsMaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer tcMateria;
        private System.Windows.Forms.ToolStrip tsMaterias;
        private System.Windows.Forms.ToolStripButton Nuevo;
        private System.Windows.Forms.ToolStripButton Editar;
        private System.Windows.Forms.ToolStripButton Eliminar;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Materias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Materias;
        private System.Windows.Forms.DataGridViewTextBoxColumn hs_semanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn hs_totales;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_plan;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
    }
}