
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cbxCursos = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPersona = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlpInscripcion = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurso = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.tlpInscripcion.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(91, 11);
            this.txtID.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(167, 22);
            this.txtID.TabIndex = 0;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Location = new System.Drawing.Point(91, 55);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(167, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // cbxCursos
            // 
            this.cbxCursos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCursos.DisplayMember = "ToString";
            this.cbxCursos.FormattingEnabled = true;
            this.cbxCursos.Location = new System.Drawing.Point(321, 10);
            this.cbxCursos.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.cbxCursos.Name = "cbxCursos";
            this.cbxCursos.Size = new System.Drawing.Size(406, 24);
            this.cbxCursos.TabIndex = 2;
            this.cbxCursos.ValueMember = "ID";
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(4, 13);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(78, 17);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID Persona";
            // 
            // lblPersona
            // 
            this.lblPersona.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPersona.AutoSize = true;
            this.lblPersona.Location = new System.Drawing.Point(4, 57);
            this.lblPersona.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(61, 17);
            this.lblPersona.TabIndex = 4;
            this.lblPersona.Text = "Persona";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.Location = new System.Drawing.Point(638, 7);
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
            this.btnCancelar.Location = new System.Drawing.Point(534, 7);
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
            this.tlpInscripcion.ColumnCount = 4;
            this.tlpInscripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInscripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpInscripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInscripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpInscripcion.Controls.Add(this.lblID, 0, 0);
            this.tlpInscripcion.Controls.Add(this.txtID, 1, 0);
            this.tlpInscripcion.Controls.Add(this.lblPersona, 0, 1);
            this.tlpInscripcion.Controls.Add(this.txtUsuario, 1, 1);
            this.tlpInscripcion.Controls.Add(this.lblCurso, 2, 0);
            this.tlpInscripcion.Controls.Add(this.cbxCursos, 3, 0);
            this.tlpInscripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInscripcion.Location = new System.Drawing.Point(0, 0);
            this.tlpInscripcion.Margin = new System.Windows.Forms.Padding(0);
            this.tlpInscripcion.Name = "tlpInscripcion";
            this.tlpInscripcion.RowCount = 2;
            this.tlpInscripcion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInscripcion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInscripcion.Size = new System.Drawing.Size(732, 88);
            this.tlpInscripcion.TabIndex = 7;
            // 
            // lblCurso
            // 
            this.lblCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(267, 13);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(45, 17);
            this.lblCurso.TabIndex = 5;
            this.lblCurso.Text = "Curso";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnAceptar);
            this.panelButtons.Controls.Add(this.btnCancelar);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 88);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(732, 45);
            this.panelButtons.TabIndex = 8;
            // 
            // InscripcionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(732, 133);
            this.Controls.Add(this.tlpInscripcion);
            this.Controls.Add(this.panelButtons);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InscripcionDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inscripcion";
            this.tlpInscripcion.ResumeLayout(false);
            this.tlpInscripcion.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ComboBox cbxCursos;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TableLayoutPanel tlpInscripcion;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Panel panelButtons;
    }
}