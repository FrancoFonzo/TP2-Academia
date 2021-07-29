
namespace UI.Desktop
{
    partial class MateriasDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MateriasDesktop));
            this.tlMaterias = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblHsSeman = new System.Windows.Forms.Label();
            this.lblHsTot = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtHsSemanales = new System.Windows.Forms.TextBox();
            this.txtHsTotales = new System.Windows.Forms.TextBox();
            this.cbxPlan = new System.Windows.Forms.ComboBox();
            this.tlMaterias.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlMaterias
            // 
            this.tlMaterias.AutoSize = true;
            this.tlMaterias.ColumnCount = 4;
            this.tlMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlMaterias.Controls.Add(this.lblID, 0, 0);
            this.tlMaterias.Controls.Add(this.lblDescripcion, 0, 1);
            this.tlMaterias.Controls.Add(this.lblHsSeman, 2, 0);
            this.tlMaterias.Controls.Add(this.lblHsTot, 2, 1);
            this.tlMaterias.Controls.Add(this.lblPlan, 0, 2);
            this.tlMaterias.Controls.Add(this.btnAceptar, 2, 4);
            this.tlMaterias.Controls.Add(this.btnCancelar, 3, 4);
            this.tlMaterias.Controls.Add(this.txtID, 1, 0);
            this.tlMaterias.Controls.Add(this.txtDescripcion, 1, 1);
            this.tlMaterias.Controls.Add(this.txtHsSemanales, 3, 0);
            this.tlMaterias.Controls.Add(this.txtHsTotales, 3, 1);
            this.tlMaterias.Controls.Add(this.cbxPlan, 1, 2);
            this.tlMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMaterias.Location = new System.Drawing.Point(0, 0);
            this.tlMaterias.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tlMaterias.Name = "tlMaterias";
            this.tlMaterias.RowCount = 5;
            this.tlMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMaterias.Size = new System.Drawing.Size(683, 151);
            this.tlMaterias.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(4, 7);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(4, 39);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblHsSeman
            // 
            this.lblHsSeman.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHsSeman.AutoSize = true;
            this.lblHsSeman.Location = new System.Drawing.Point(326, 7);
            this.lblHsSeman.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHsSeman.Name = "lblHsSeman";
            this.lblHsSeman.Size = new System.Drawing.Size(120, 17);
            this.lblHsSeman.TabIndex = 4;
            this.lblHsSeman.Text = "Horas Semanales";
            // 
            // lblHsTot
            // 
            this.lblHsTot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHsTot.AutoSize = true;
            this.lblHsTot.Location = new System.Drawing.Point(326, 39);
            this.lblHsTot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHsTot.Name = "lblHsTot";
            this.lblHsTot.Size = new System.Drawing.Size(97, 17);
            this.lblHsTot.TabIndex = 6;
            this.lblHsTot.Text = "Horas Totales";
            // 
            // lblPlan
            // 
            this.lblPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(4, 72);
            this.lblPlan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(36, 17);
            this.lblPlan.TabIndex = 8;
            this.lblPlan.Text = "Plan";
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.Location = new System.Drawing.Point(326, 102);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 27);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(454, 102);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 26);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Cursor = System.Windows.Forms.Cursors.No;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(95, 5);
            this.txtID.Margin = new System.Windows.Forms.Padding(5);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(222, 22);
            this.txtID.TabIndex = 1;
            this.txtID.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(95, 37);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(222, 22);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtHsSemanales
            // 
            this.txtHsSemanales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHsSemanales.Location = new System.Drawing.Point(455, 5);
            this.txtHsSemanales.Margin = new System.Windows.Forms.Padding(5);
            this.txtHsSemanales.Name = "txtHsSemanales";
            this.txtHsSemanales.Size = new System.Drawing.Size(223, 22);
            this.txtHsSemanales.TabIndex = 5;
            // 
            // txtHsTotales
            // 
            this.txtHsTotales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHsTotales.Location = new System.Drawing.Point(455, 37);
            this.txtHsTotales.Margin = new System.Windows.Forms.Padding(5);
            this.txtHsTotales.Name = "txtHsTotales";
            this.txtHsTotales.Size = new System.Drawing.Size(223, 22);
            this.txtHsTotales.TabIndex = 7;
            // 
            // cbxPlan
            // 
            this.cbxPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPlan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxPlan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPlan.DisplayMember = "Descripcion";
            this.cbxPlan.FormattingEnabled = true;
            this.cbxPlan.Location = new System.Drawing.Point(95, 69);
            this.cbxPlan.Margin = new System.Windows.Forms.Padding(5);
            this.cbxPlan.Name = "cbxPlan";
            this.cbxPlan.Size = new System.Drawing.Size(222, 24);
            this.cbxPlan.TabIndex = 9;
            this.cbxPlan.ValueMember = "ID";
            // 
            // MateriasDesktop
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(683, 151);
            this.Controls.Add(this.tlMaterias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MateriasDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MateriasDesktop";
            this.tlMaterias.ResumeLayout(false);
            this.tlMaterias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlMaterias;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblHsSeman;
        private System.Windows.Forms.Label lblHsTot;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtHsSemanales;
        private System.Windows.Forms.TextBox txtHsTotales;
        private System.Windows.Forms.ComboBox cbxPlan;
    }
}