
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
            this.Nuevo = new System.Windows.Forms.ToolStripButton();
            this.Editar = new System.Windows.Forms.ToolStripButton();
            this.Eliminar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.ID_Materias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_Materias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hs_semanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hs_totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tsMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMaterias
            // 
            this.tsMaterias.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMaterias.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMaterias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nuevo,
            this.Editar,
            this.Eliminar});
            this.tsMaterias.Location = new System.Drawing.Point(0, 0);
            this.tsMaterias.Name = "tsMaterias";
            this.tsMaterias.Size = new System.Drawing.Size(800, 28);
            this.tsMaterias.TabIndex = 8;
            // 
            // Nuevo
            // 
            this.Nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo.Image")));
            this.Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Nuevo.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(29, 24);
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
            this.Editar.Size = new System.Drawing.Size(29, 24);
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
            this.Eliminar.Size = new System.Drawing.Size(29, 24);
            this.Eliminar.Text = "toolStripButton3";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(622, 4);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(93, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(720, 4);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
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
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnSalir);
            this.panelBottom.Controls.Add(this.btnActualizar);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 418);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(800, 32);
            this.panelBottom.TabIndex = 9;
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.tsMaterias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Materias";
            this.Text = "Materias";
            this.tsMaterias.ResumeLayout(false);
            this.tsMaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMaterias;
        private System.Windows.Forms.ToolStripButton Nuevo;
        private System.Windows.Forms.ToolStripButton Editar;
        private System.Windows.Forms.ToolStripButton Eliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Materias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Materias;
        private System.Windows.Forms.DataGridViewTextBoxColumn hs_semanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn hs_totales;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_plan;
        private System.Windows.Forms.Panel panelBottom;
    }
}