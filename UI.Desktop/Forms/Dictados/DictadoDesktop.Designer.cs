
namespace UI.Desktop
{
    partial class DictadoDesktop
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
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbxCursos = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.cbxTiposCargos = new System.Windows.Forms.ComboBox();
            this.cbxDocentes = new System.Windows.Forms.ComboBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
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
            this.tlComision.Controls.Add(this.lblCurso, 2, 1);
            this.tlComision.Controls.Add(this.txtID, 1, 0);
            this.tlComision.Controls.Add(this.cbxCursos, 3, 1);
            this.tlComision.Controls.Add(this.lblCargo, 0, 1);
            this.tlComision.Controls.Add(this.lblDocente, 2, 0);
            this.tlComision.Controls.Add(this.cbxTiposCargos, 1, 1);
            this.tlComision.Controls.Add(this.cbxDocentes, 3, 0);
            this.tlComision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlComision.Location = new System.Drawing.Point(0, 0);
            this.tlComision.Margin = new System.Windows.Forms.Padding(0);
            this.tlComision.Name = "tlComision";
            this.tlComision.RowCount = 2;
            this.tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlComision.Size = new System.Drawing.Size(800, 126);
            this.tlComision.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(4, 23);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblCurso
            // 
            this.lblCurso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(261, 86);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(45, 17);
            this.lblCurso.TabIndex = 3;
            this.lblCurso.Text = "Curso";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.Cursor = System.Windows.Forms.Cursors.No;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(58, 20);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(195, 22);
            this.txtID.TabIndex = 4;
            this.txtID.TabStop = false;
            // 
            // cbxCursos
            // 
            this.cbxCursos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCursos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCursos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCursos.DisplayMember = "Descripcion";
            this.cbxCursos.FormattingEnabled = true;
            this.cbxCursos.Location = new System.Drawing.Point(330, 82);
            this.cbxCursos.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCursos.Name = "cbxCursos";
            this.cbxCursos.Size = new System.Drawing.Size(466, 24);
            this.cbxCursos.TabIndex = 13;
            this.cbxCursos.ValueMember = "ID";
            // 
            // lblCargo
            // 
            this.lblCargo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(4, 86);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(46, 17);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "Cargo";
            // 
            // lblDocente
            // 
            this.lblDocente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(261, 23);
            this.lblDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(61, 17);
            this.lblDocente.TabIndex = 2;
            this.lblDocente.Text = "Docente";
            // 
            // cbxTiposCargos
            // 
            this.cbxTiposCargos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTiposCargos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTiposCargos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTiposCargos.DisplayMember = "ID";
            this.cbxTiposCargos.FormattingEnabled = true;
            this.cbxTiposCargos.Location = new System.Drawing.Point(58, 82);
            this.cbxTiposCargos.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTiposCargos.Name = "cbxTiposCargos";
            this.cbxTiposCargos.Size = new System.Drawing.Size(195, 24);
            this.cbxTiposCargos.TabIndex = 14;
            this.cbxTiposCargos.ValueMember = "ID";
            // 
            // cbxDocentes
            // 
            this.cbxDocentes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDocentes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxDocentes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDocentes.DisplayMember = "NombreCompleto";
            this.cbxDocentes.FormattingEnabled = true;
            this.cbxDocentes.Location = new System.Drawing.Point(330, 19);
            this.cbxDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDocentes.Name = "cbxDocentes";
            this.cbxDocentes.Size = new System.Drawing.Size(466, 24);
            this.cbxDocentes.TabIndex = 15;
            this.cbxDocentes.ValueMember = "ID";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnAceptar);
            this.panelBottom.Controls.Add(this.btnCancelar);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 126);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(800, 37);
            this.panelBottom.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.Location = new System.Drawing.Point(695, 5);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 27);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(590, 5);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 27);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // DictadoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 163);
            this.Controls.Add(this.tlComision);
            this.Controls.Add(this.panelBottom);
            this.Name = "DictadoDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dictado";
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
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbxCursos;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxTiposCargos;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.ComboBox cbxDocentes;
    }
}