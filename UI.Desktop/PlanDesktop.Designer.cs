
namespace UI.Desktop
{
    partial class PlanDesktop
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbxEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tlpDatosPlanes = new System.Windows.Forms.TableLayoutPanel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.tlpDatosPlanes.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(358, 5);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 33);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.Location = new System.Drawing.Point(264, 5);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 33);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(103, 52);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(354, 22);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Cursor = System.Windows.Forms.Cursors.No;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(103, 10);
            this.txtID.Margin = new System.Windows.Forms.Padding(5);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(354, 22);
            this.txtID.TabIndex = 1;
            this.txtID.TabStop = false;
            // 
            // cbxEspecialidad
            // 
            this.cbxEspecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEspecialidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxEspecialidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEspecialidad.DisplayMember = "Descripcion";
            this.cbxEspecialidad.FormattingEnabled = true;
            this.cbxEspecialidad.Location = new System.Drawing.Point(103, 93);
            this.cbxEspecialidad.Margin = new System.Windows.Forms.Padding(5);
            this.cbxEspecialidad.Name = "cbxEspecialidad";
            this.cbxEspecialidad.Size = new System.Drawing.Size(354, 24);
            this.cbxEspecialidad.TabIndex = 5;
            this.cbxEspecialidad.ValueMember = "ID";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(5, 54);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(5);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(5, 97);
            this.lblEspecialidad.Margin = new System.Windows.Forms.Padding(5);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(88, 17);
            this.lblEspecialidad.TabIndex = 4;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(5, 12);
            this.lblID.Margin = new System.Windows.Forms.Padding(5);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // tlpDatosPlanes
            // 
            this.tlpDatosPlanes.ColumnCount = 2;
            this.tlpDatosPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDatosPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDatosPlanes.Controls.Add(this.lblID, 0, 0);
            this.tlpDatosPlanes.Controls.Add(this.lblEspecialidad, 0, 2);
            this.tlpDatosPlanes.Controls.Add(this.lblDescripcion, 0, 1);
            this.tlpDatosPlanes.Controls.Add(this.cbxEspecialidad, 1, 2);
            this.tlpDatosPlanes.Controls.Add(this.txtID, 1, 0);
            this.tlpDatosPlanes.Controls.Add(this.txtDescripcion, 1, 1);
            this.tlpDatosPlanes.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpDatosPlanes.Location = new System.Drawing.Point(0, 0);
            this.tlpDatosPlanes.Name = "tlpDatosPlanes";
            this.tlpDatosPlanes.RowCount = 3;
            this.tlpDatosPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDatosPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDatosPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDatosPlanes.Size = new System.Drawing.Size(462, 127);
            this.tlpDatosPlanes.TabIndex = 1;
            // 
            // panelButtons
            // 
            this.panelButtons.AutoSize = true;
            this.panelButtons.Controls.Add(this.btnAceptar);
            this.panelButtons.Controls.Add(this.btnCancelar);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 125);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(462, 43);
            this.panelButtons.TabIndex = 13;
            // 
            // PlanDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 168);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.tlpDatosPlanes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlanDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Plan";
            this.tlpDatosPlanes.ResumeLayout(false);
            this.tlpDatosPlanes.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbxEspecialidad;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TableLayoutPanel tlpDatosPlanes;
        private System.Windows.Forms.Panel panelButtons;
    }
}