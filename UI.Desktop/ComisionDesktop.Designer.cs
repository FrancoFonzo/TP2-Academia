
namespace UI.Desktop
{
    partial class ComisionDesktop
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
            this.tlComision = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbxPlan = new System.Windows.Forms.ComboBox();
            this.lblAnioEspecialidad = new System.Windows.Forms.Label();
            this.txtAnioEspecialidad = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tlComision.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlComision
            // 
            this.tlComision.AutoSize = true;
            this.tlComision.ColumnCount = 4;
            this.tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlComision.Controls.Add(this.lblID, 0, 0);
            this.tlComision.Controls.Add(this.lblDescripcion, 2, 0);
            this.tlComision.Controls.Add(this.lblPlan, 2, 1);
            this.tlComision.Controls.Add(this.txtID, 1, 0);
            this.tlComision.Controls.Add(this.txtDescripcion, 3, 0);
            this.tlComision.Controls.Add(this.cbxPlan, 3, 1);
            this.tlComision.Controls.Add(this.lblAnioEspecialidad, 0, 1);
            this.tlComision.Controls.Add(this.txtAnioEspecialidad, 1, 1);
            this.tlComision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlComision.Location = new System.Drawing.Point(0, 0);
            this.tlComision.Margin = new System.Windows.Forms.Padding(0);
            this.tlComision.Name = "tlComision";
            this.tlComision.RowCount = 2;
            this.tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlComision.Size = new System.Drawing.Size(732, 116);
            this.tlComision.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(4, 20);
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
            this.lblDescripcion.Location = new System.Drawing.Point(284, 20);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblPlan
            // 
            this.lblPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(284, 78);
            this.lblPlan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(36, 17);
            this.lblPlan.TabIndex = 3;
            this.lblPlan.Text = "Plan";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.Cursor = System.Windows.Forms.Cursors.No;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(129, 18);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(147, 22);
            this.txtID.TabIndex = 4;
            this.txtID.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(374, 18);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(354, 22);
            this.txtDescripcion.TabIndex = 6;
            // 
            // cbxPlan
            // 
            this.cbxPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPlan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxPlan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPlan.DisplayMember = "Descripcion";
            this.cbxPlan.FormattingEnabled = true;
            this.cbxPlan.Location = new System.Drawing.Point(374, 75);
            this.cbxPlan.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPlan.Name = "cbxPlan";
            this.cbxPlan.Size = new System.Drawing.Size(354, 24);
            this.cbxPlan.TabIndex = 13;
            this.cbxPlan.ValueMember = "ID";
            // 
            // lblAnioEspecialidad
            // 
            this.lblAnioEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAnioEspecialidad.AutoSize = true;
            this.lblAnioEspecialidad.Location = new System.Drawing.Point(4, 78);
            this.lblAnioEspecialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnioEspecialidad.Name = "lblAnioEspecialidad";
            this.lblAnioEspecialidad.Size = new System.Drawing.Size(117, 17);
            this.lblAnioEspecialidad.TabIndex = 2;
            this.lblAnioEspecialidad.Text = "Año Especialidad";
            // 
            // txtAnioEspecialidad
            // 
            this.txtAnioEspecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnioEspecialidad.Location = new System.Drawing.Point(129, 76);
            this.txtAnioEspecialidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnioEspecialidad.Name = "txtAnioEspecialidad";
            this.txtAnioEspecialidad.Size = new System.Drawing.Size(147, 22);
            this.txtAnioEspecialidad.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(522, 5);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 27);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.Location = new System.Drawing.Point(627, 5);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 27);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnAceptar);
            this.panelBottom.Controls.Add(this.btnCancelar);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 116);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(732, 37);
            this.panelBottom.TabIndex = 1;
            // 
            // ComisionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(732, 153);
            this.Controls.Add(this.tlComision);
            this.Controls.Add(this.panelBottom);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ComisionDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comision";
            this.tlComision.ResumeLayout(false);
            this.tlComision.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlComision;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblAnioEspecialidad;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAnioEspecialidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbxPlan;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panelBottom;
    }
}