namespace AdministracionBD.PL
{
    partial class frmEmpleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.cbxDepartamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picfoto = new System.Windows.Forms.PictureBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(289, 56);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(418, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(368, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(289, 123);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(497, 22);
            this.txtApellido.TabIndex = 3;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(289, 191);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(497, 22);
            this.txtCorreo.TabIndex = 5;
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.FormattingEnabled = true;
            this.cbxDepartamento.Location = new System.Drawing.Point(289, 249);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(497, 24);
            this.cbxDepartamento.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Departamento:";
            // 
            // picfoto
            // 
            this.picfoto.Location = new System.Drawing.Point(68, 23);
            this.picfoto.Name = "picfoto";
            this.picfoto.Size = new System.Drawing.Size(184, 250);
            this.picfoto.TabIndex = 12;
            this.picfoto.TabStop = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(114, 288);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(101, 43);
            this.btnExaminar.TabIndex = 13;
            this.btnExaminar.Text = "Examinar....";
            this.btnExaminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(266, 288);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 43);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(68, 398);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(718, 151);
            this.dgvEmpleados.TabIndex = 18;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(396, 288);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 43);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(540, 288);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(97, 43);
            this.btnBorrar.TabIndex = 20;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(689, 288);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 43);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 585);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.picfoto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxDepartamento);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.picfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ComboBox cbxDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picfoto;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}