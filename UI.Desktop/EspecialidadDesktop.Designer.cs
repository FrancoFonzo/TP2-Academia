
namespace UI.Desktop
{
    partial class EspecialidadDesktop
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
            this.tlpEspecialidad = new System.Windows.Forms.TableLayoutPanel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.tlpEspecialidad.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpEspecialidad
            // 
            this.tlpEspecialidad.ColumnCount = 2;
            this.tlpEspecialidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEspecialidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEspecialidad.Controls.Add(this.txtID, 1, 0);
            this.tlpEspecialidad.Controls.Add(this.lblID, 0, 0);
            this.tlpEspecialidad.Controls.Add(this.lblDescripcion, 0, 1);
            this.tlpEspecialidad.Controls.Add(this.txtDescripcion, 1, 1);
            this.tlpEspecialidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpEspecialidad.Location = new System.Drawing.Point(0, 0);
            this.tlpEspecialidad.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tlpEspecialidad.Name = "tlpEspecialidad";
            this.tlpEspecialidad.RowCount = 2;
            this.tlpEspecialidad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEspecialidad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEspecialidad.Size = new System.Drawing.Size(432, 90);
            this.tlpEspecialidad.TabIndex = 0;
            this.tlpEspecialidad.Paint += new System.Windows.Forms.PaintEventHandler(this.tlEspecialidad_Paint);
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Cursor = System.Windows.Forms.Cursors.No;
            this.txtID.Location = new System.Drawing.Point(91, 11);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(338, 22);
            this.txtID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 14);
            this.lblID.Name = "lblID";
            this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 59);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(91, 56);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(338, 22);
            this.txtDescripcion.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(346, 5);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 32);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.Location = new System.Drawing.Point(262, 5);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(79, 32);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.AutoSize = true;
            this.panelButtons.Controls.Add(this.btnAceptar);
            this.panelButtons.Controls.Add(this.btnCancelar);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 90);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(432, 42);
            this.panelButtons.TabIndex = 6;
            // 
            // EspecialidadDesktop
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(432, 133);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.tlpEspecialidad);
            this.Name = "EspecialidadDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Especialidad";
            this.Load += new System.EventHandler(this.EspecialidadDesktop_Load);
            this.tlpEspecialidad.ResumeLayout(false);
            this.tlpEspecialidad.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEspecialidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panelButtons;
    }
}