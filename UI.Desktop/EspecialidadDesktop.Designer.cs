
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
            this.tlEspecialidad = new System.Windows.Forms.TableLayoutPanel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlEspecialidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlEspecialidad
            // 
            this.tlEspecialidad.AutoSize = true;
            this.tlEspecialidad.ColumnCount = 2;
            this.tlEspecialidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.98453F));
            this.tlEspecialidad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.01547F));
            this.tlEspecialidad.Controls.Add(this.txtDescripcion, 1, 1);
            this.tlEspecialidad.Controls.Add(this.txtID, 1, 0);
            this.tlEspecialidad.Controls.Add(this.lblID, 0, 0);
            this.tlEspecialidad.Controls.Add(this.lblDescripcion, 0, 1);
            this.tlEspecialidad.Controls.Add(this.btnAceptar, 1, 2);
            this.tlEspecialidad.Controls.Add(this.btnCancelar, 0, 2);
            this.tlEspecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlEspecialidad.Location = new System.Drawing.Point(0, 0);
            this.tlEspecialidad.Name = "tlEspecialidad";
            this.tlEspecialidad.RowCount = 3;
            this.tlEspecialidad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.68493F));
            this.tlEspecialidad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.31507F));
            this.tlEspecialidad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlEspecialidad.Size = new System.Drawing.Size(517, 146);
            this.tlEspecialidad.TabIndex = 0;
            this.tlEspecialidad.Paint += new System.Windows.Forms.PaintEventHandler(this.tlEspecialidad_Paint);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Location = new System.Drawing.Point(127, 58);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(387, 22);
            this.txtDescripcion.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtID.Location = new System.Drawing.Point(127, 30);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(387, 22);
            this.txtID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblID.Location = new System.Drawing.Point(3, 32);
            this.lblID.Name = "lblID";
            this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblID.Size = new System.Drawing.Size(118, 23);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDescripcion.Location = new System.Drawing.Point(39, 55);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 53);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAceptar.Location = new System.Drawing.Point(439, 111);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 32);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(3, 111);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 32);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // EspecialidadDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 146);
            this.Controls.Add(this.tlEspecialidad);
            this.Name = "EspecialidadDesktop";
            this.Text = "Especialidad";
            this.Load += new System.EventHandler(this.EspecialidadDesktop_Load);
            this.tlEspecialidad.ResumeLayout(false);
            this.tlEspecialidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlEspecialidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}