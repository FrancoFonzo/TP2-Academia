
namespace UI.Desktop
{
    partial class UsuarioDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioDesktop));
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cbxPersona = new System.Windows.Forms.ComboBox();
            this.lblPersona = new System.Windows.Forms.Label();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.lblConfirmarClave = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.tlUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.tlUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClave
            // 
            this.txtClave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClave.Location = new System.Drawing.Point(68, 81);
            this.txtClave.Margin = new System.Windows.Forms.Padding(5);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(350, 22);
            this.txtClave.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Location = new System.Drawing.Point(68, 44);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(350, 22);
            this.txtUsuario.TabIndex = 8;
            // 
            // cbxPersona
            // 
            this.cbxPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPersona.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxPersona.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPersona.DisplayMember = "NombreCompleto";
            this.cbxPersona.FormattingEnabled = true;
            this.cbxPersona.Location = new System.Drawing.Point(555, 43);
            this.cbxPersona.Margin = new System.Windows.Forms.Padding(5);
            this.cbxPersona.Name = "cbxPersona";
            this.cbxPersona.Size = new System.Drawing.Size(351, 24);
            this.cbxPersona.TabIndex = 6;
            this.cbxPersona.ValueMember = "ID";
            // 
            // lblPersona
            // 
            this.lblPersona.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPersona.AutoSize = true;
            this.lblPersona.Location = new System.Drawing.Point(427, 47);
            this.lblPersona.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(61, 17);
            this.lblPersona.TabIndex = 5;
            this.lblPersona.Text = "Persona";
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmarClave.Location = new System.Drawing.Point(555, 81);
            this.txtConfirmarClave.Margin = new System.Windows.Forms.Padding(5);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.Size = new System.Drawing.Size(351, 22);
            this.txtConfirmarClave.TabIndex = 10;
            // 
            // lblConfirmarClave
            // 
            this.lblConfirmarClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblConfirmarClave.AutoSize = true;
            this.lblConfirmarClave.Location = new System.Drawing.Point(427, 84);
            this.lblConfirmarClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmarClave.Name = "lblConfirmarClave";
            this.lblConfirmarClave.Size = new System.Drawing.Size(106, 17);
            this.lblConfirmarClave.TabIndex = 9;
            this.lblConfirmarClave.Text = "Confirmar clave";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(3, 47);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 17);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblClave
            // 
            this.lblClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(4, 84);
            this.lblClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(43, 17);
            this.lblClave.TabIndex = 7;
            this.lblClave.Text = "Clave";
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(554, 150);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 33);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.Location = new System.Drawing.Point(427, 150);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 33);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(427, 8);
            this.chkHabilitado.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(93, 21);
            this.chkHabilitado.TabIndex = 2;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Cursor = System.Windows.Forms.Cursors.No;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(68, 7);
            this.txtID.Margin = new System.Windows.Forms.Padding(5);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(350, 22);
            this.txtID.TabIndex = 1;
            this.txtID.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(4, 10);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // tlUsuarios
            // 
            this.tlUsuarios.AutoSize = true;
            this.tlUsuarios.ColumnCount = 4;
            this.tlUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlUsuarios.Controls.Add(this.lblID, 0, 0);
            this.tlUsuarios.Controls.Add(this.txtID, 1, 0);
            this.tlUsuarios.Controls.Add(this.chkHabilitado, 2, 0);
            this.tlUsuarios.Controls.Add(this.btnCancelar, 3, 4);
            this.tlUsuarios.Controls.Add(this.lblClave, 0, 2);
            this.tlUsuarios.Controls.Add(this.lblUsuario, 0, 1);
            this.tlUsuarios.Controls.Add(this.lblConfirmarClave, 2, 2);
            this.tlUsuarios.Controls.Add(this.txtConfirmarClave, 3, 2);
            this.tlUsuarios.Controls.Add(this.lblPersona, 2, 1);
            this.tlUsuarios.Controls.Add(this.cbxPersona, 3, 1);
            this.tlUsuarios.Controls.Add(this.txtUsuario, 1, 1);
            this.tlUsuarios.Controls.Add(this.txtClave, 1, 2);
            this.tlUsuarios.Controls.Add(this.btnAceptar, 2, 4);
            this.tlUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tlUsuarios.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tlUsuarios.Name = "tlUsuarios";
            this.tlUsuarios.RowCount = 5;
            this.tlUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlUsuarios.Size = new System.Drawing.Size(911, 186);
            this.tlUsuarios.TabIndex = 0;
            // 
            // UsuarioDesktop
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(911, 186);
            this.Controls.Add(this.tlUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "UsuarioDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuario";
            this.tlUsuarios.ResumeLayout(false);
            this.tlUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ComboBox cbxPersona;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.Label lblConfirmarClave;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TableLayoutPanel tlUsuarios;
    }
}