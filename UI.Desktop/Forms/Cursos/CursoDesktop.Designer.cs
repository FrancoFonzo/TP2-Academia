
namespace UI.Desktop
{
    partial class CursoDesktop
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
            this.tlMaterias = new System.Windows.Forms.TableLayoutPanel();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cbxMateria = new System.Windows.Forms.ComboBox();
            this.lblComision = new System.Windows.Forms.Label();
            this.cbxComision = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtAñoCalendario = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblAñoCalendario = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCupo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.cbxDocente = new System.Windows.Forms.ComboBox();
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
            this.tlMaterias.Controls.Add(this.lblAñoCalendario, 2, 0);
            this.tlMaterias.Controls.Add(this.lblCupo, 2, 1);
            this.tlMaterias.Controls.Add(this.lblMateria, 0, 2);
            this.tlMaterias.Controls.Add(this.txtID, 1, 0);
            this.tlMaterias.Controls.Add(this.txtDescripcion, 1, 1);
            this.tlMaterias.Controls.Add(this.txtAñoCalendario, 3, 0);
            this.tlMaterias.Controls.Add(this.txtCupo, 3, 1);
            this.tlMaterias.Controls.Add(this.cbxMateria, 1, 2);
            this.tlMaterias.Controls.Add(this.lblComision, 2, 2);
            this.tlMaterias.Controls.Add(this.cbxComision, 3, 2);
            this.tlMaterias.Controls.Add(this.btnCancelar, 2, 5);
            this.tlMaterias.Controls.Add(this.btnAceptar, 3, 5);
            this.tlMaterias.Controls.Add(this.lblDocente, 0, 3);
            this.tlMaterias.Controls.Add(this.cbxDocente, 1, 3);
            this.tlMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMaterias.Location = new System.Drawing.Point(0, 0);
            this.tlMaterias.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tlMaterias.Name = "tlMaterias";
            this.tlMaterias.RowCount = 6;
            this.tlMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlMaterias.Size = new System.Drawing.Size(781, 194);
            this.tlMaterias.TabIndex = 1;
            // 
            // lblMateria
            // 
            this.lblMateria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(4, 72);
            this.lblMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(55, 17);
            this.lblMateria.TabIndex = 8;
            this.lblMateria.Text = "Materia";
            // 
            // cbxMateria
            // 
            this.cbxMateria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMateria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxMateria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMateria.DisplayMember = "Descripcion";
            this.cbxMateria.FormattingEnabled = true;
            this.cbxMateria.Location = new System.Drawing.Point(95, 69);
            this.cbxMateria.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbxMateria.Name = "cbxMateria";
            this.cbxMateria.Size = new System.Drawing.Size(279, 24);
            this.cbxMateria.TabIndex = 9;
            this.cbxMateria.ValueMember = "ID";
            // 
            // lblComision
            // 
            this.lblComision.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(383, 72);
            this.lblComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(65, 17);
            this.lblComision.TabIndex = 12;
            this.lblComision.Text = "Comision";
            // 
            // cbxComision
            // 
            this.cbxComision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxComision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxComision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxComision.DisplayMember = "Descripcion";
            this.cbxComision.FormattingEnabled = true;
            this.cbxComision.Location = new System.Drawing.Point(497, 69);
            this.cbxComision.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbxComision.Name = "cbxComision";
            this.cbxComision.Size = new System.Drawing.Size(279, 24);
            this.cbxComision.TabIndex = 13;
            this.cbxComision.ValueMember = "ID";
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.Location = new System.Drawing.Point(497, 157);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 33);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(384, 157);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 33);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtAñoCalendario
            // 
            this.txtAñoCalendario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAñoCalendario.Location = new System.Drawing.Point(497, 5);
            this.txtAñoCalendario.Margin = new System.Windows.Forms.Padding(5);
            this.txtAñoCalendario.Name = "txtAñoCalendario";
            this.txtAñoCalendario.Size = new System.Drawing.Size(279, 22);
            this.txtAñoCalendario.TabIndex = 5;
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
            this.txtID.Size = new System.Drawing.Size(279, 22);
            this.txtID.TabIndex = 1;
            this.txtID.TabStop = false;
            // 
            // lblAñoCalendario
            // 
            this.lblAñoCalendario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAñoCalendario.AutoSize = true;
            this.lblAñoCalendario.Location = new System.Drawing.Point(383, 7);
            this.lblAñoCalendario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAñoCalendario.Name = "lblAñoCalendario";
            this.lblAñoCalendario.Size = new System.Drawing.Size(105, 17);
            this.lblAñoCalendario.TabIndex = 4;
            this.lblAñoCalendario.Text = "Año Calendario";
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
            // txtCupo
            // 
            this.txtCupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCupo.Location = new System.Drawing.Point(497, 37);
            this.txtCupo.Margin = new System.Windows.Forms.Padding(5);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(279, 22);
            this.txtCupo.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(95, 37);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(279, 22);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblCupo
            // 
            this.lblCupo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCupo.AutoSize = true;
            this.lblCupo.Location = new System.Drawing.Point(383, 39);
            this.lblCupo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(41, 17);
            this.lblCupo.TabIndex = 6;
            this.lblCupo.Text = "Cupo";
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
            // lblDocente
            // 
            this.lblDocente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(4, 106);
            this.lblDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(61, 17);
            this.lblDocente.TabIndex = 14;
            this.lblDocente.Text = "Docente";
            // 
            // cbxDocente
            // 
            this.cbxDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDocente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxDocente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDocente.FormattingEnabled = true;
            this.cbxDocente.Location = new System.Drawing.Point(95, 103);
            this.cbxDocente.Margin = new System.Windows.Forms.Padding(5);
            this.cbxDocente.Name = "cbxDocente";
            this.cbxDocente.Size = new System.Drawing.Size(279, 24);
            this.cbxDocente.TabIndex = 15;
            this.cbxDocente.ValueMember = "ID";
            // 
            // CursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(781, 194);
            this.Controls.Add(this.tlMaterias);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CursoDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Curso";
            this.tlMaterias.ResumeLayout(false);
            this.tlMaterias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlMaterias;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cbxMateria;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.ComboBox cbxComision;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblAñoCalendario;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtAñoCalendario;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.ComboBox cbxDocente;
    }
}