namespace BiblioDesktop.Presentation
{
    partial class FrmAgregarEditarSocio
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
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.LblDni = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblNuevoEditar = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.DtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.LblDomicilio = new System.Windows.Forms.Label();
            this.TxtDomicilio = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.NudDni = new System.Windows.Forms.NumericUpDown();
            this.NudTelefono = new System.Windows.Forms.NumericUpDown();
            this.LblFoto = new System.Windows.Forms.Label();
            this.PbxFoto = new System.Windows.Forms.PictureBox();
            this.BtnExaminar = new System.Windows.Forms.Button();
            this.BtnIniciarDetenerCamara = new System.Windows.Forms.Button();
            this.BtnCapturarFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(309, 132);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(177, 23);
            this.TxtApellido.TabIndex = 1;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(309, 83);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(177, 23);
            this.TxtNombre.TabIndex = 0;
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFechaNacimiento.Location = new System.Drawing.Point(135, 238);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(167, 21);
            this.LblFechaNacimiento.TabIndex = 0;
            this.LblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDni.Location = new System.Drawing.Point(135, 183);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(42, 21);
            this.LblDni.TabIndex = 9;
            this.LblDni.Text = "DNI:";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblApellido.Location = new System.Drawing.Point(135, 130);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(76, 21);
            this.LblApellido.TabIndex = 10;
            this.LblApellido.Text = "Apellido:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNombre.Location = new System.Drawing.Point(135, 83);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(75, 21);
            this.LblNombre.TabIndex = 11;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblNuevoEditar
            // 
            this.LblNuevoEditar.AutoSize = true;
            this.LblNuevoEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNuevoEditar.Location = new System.Drawing.Point(172, 18);
            this.LblNuevoEditar.Name = "LblNuevoEditar";
            this.LblNuevoEditar.Size = new System.Drawing.Size(290, 40);
            this.LblNuevoEditar.TabIndex = 12;
            this.LblNuevoEditar.Text = "Agregar/Editar Socio";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.Location = new System.Drawing.Point(155, 552);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(102, 49);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.Location = new System.Drawing.Point(316, 552);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(102, 49);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // DtpNacimiento
            // 
            this.DtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpNacimiento.Location = new System.Drawing.Point(309, 238);
            this.DtpNacimiento.Name = "DtpNacimiento";
            this.DtpNacimiento.Size = new System.Drawing.Size(176, 23);
            this.DtpNacimiento.TabIndex = 3;
            // 
            // LblDomicilio
            // 
            this.LblDomicilio.AutoSize = true;
            this.LblDomicilio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDomicilio.Location = new System.Drawing.Point(135, 290);
            this.LblDomicilio.Name = "LblDomicilio";
            this.LblDomicilio.Size = new System.Drawing.Size(83, 21);
            this.LblDomicilio.TabIndex = 17;
            this.LblDomicilio.Text = "Domicilio:";
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.Location = new System.Drawing.Point(309, 290);
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(176, 23);
            this.TxtDomicilio.TabIndex = 4;
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTelefono.Location = new System.Drawing.Point(136, 341);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(78, 21);
            this.LblTelefono.TabIndex = 19;
            this.LblTelefono.Text = "Telefono:";
            // 
            // NudDni
            // 
            this.NudDni.Location = new System.Drawing.Point(309, 180);
            this.NudDni.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NudDni.Name = "NudDni";
            this.NudDni.Size = new System.Drawing.Size(177, 23);
            this.NudDni.TabIndex = 2;
            // 
            // NudTelefono
            // 
            this.NudTelefono.Location = new System.Drawing.Point(309, 339);
            this.NudTelefono.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.NudTelefono.Name = "NudTelefono";
            this.NudTelefono.Size = new System.Drawing.Size(177, 23);
            this.NudTelefono.TabIndex = 5;
            // 
            // LblFoto
            // 
            this.LblFoto.AutoSize = true;
            this.LblFoto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFoto.Location = new System.Drawing.Point(135, 399);
            this.LblFoto.Name = "LblFoto";
            this.LblFoto.Size = new System.Drawing.Size(48, 21);
            this.LblFoto.TabIndex = 20;
            this.LblFoto.Text = "Foto:";
            // 
            // PbxFoto
            // 
            this.PbxFoto.Location = new System.Drawing.Point(309, 399);
            this.PbxFoto.Name = "PbxFoto";
            this.PbxFoto.Size = new System.Drawing.Size(109, 105);
            this.PbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxFoto.TabIndex = 21;
            this.PbxFoto.TabStop = false;
            // 
            // BtnExaminar
            // 
            this.BtnExaminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExaminar.Location = new System.Drawing.Point(443, 399);
            this.BtnExaminar.Name = "BtnExaminar";
            this.BtnExaminar.Size = new System.Drawing.Size(163, 31);
            this.BtnExaminar.TabIndex = 22;
            this.BtnExaminar.Text = "Examinar";
            this.BtnExaminar.UseVisualStyleBackColor = true;
            this.BtnExaminar.Click += new System.EventHandler(this.BtnExaminar_Click);
            // 
            // BtnIniciarDetenerCamara
            // 
            this.BtnIniciarDetenerCamara.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnIniciarDetenerCamara.Location = new System.Drawing.Point(443, 436);
            this.BtnIniciarDetenerCamara.Name = "BtnIniciarDetenerCamara";
            this.BtnIniciarDetenerCamara.Size = new System.Drawing.Size(163, 31);
            this.BtnIniciarDetenerCamara.TabIndex = 23;
            this.BtnIniciarDetenerCamara.Text = "Iniciar Cámara";
            this.BtnIniciarDetenerCamara.UseVisualStyleBackColor = true;
            this.BtnIniciarDetenerCamara.Click += new System.EventHandler(this.BtnIniciarDetenerCamara_Click);
            // 
            // BtnCapturarFoto
            // 
            this.BtnCapturarFoto.Enabled = false;
            this.BtnCapturarFoto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCapturarFoto.ForeColor = System.Drawing.Color.Red;
            this.BtnCapturarFoto.Location = new System.Drawing.Point(443, 473);
            this.BtnCapturarFoto.Name = "BtnCapturarFoto";
            this.BtnCapturarFoto.Size = new System.Drawing.Size(163, 31);
            this.BtnCapturarFoto.TabIndex = 24;
            this.BtnCapturarFoto.Text = "Capturar Foto";
            this.BtnCapturarFoto.UseVisualStyleBackColor = true;
            this.BtnCapturarFoto.Click += new System.EventHandler(this.BtnCapturarFoto_Click);
            // 
            // FrmAgregarEditarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 649);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCapturarFoto);
            this.Controls.Add(this.BtnIniciarDetenerCamara);
            this.Controls.Add(this.BtnExaminar);
            this.Controls.Add(this.PbxFoto);
            this.Controls.Add(this.LblFoto);
            this.Controls.Add(this.NudTelefono);
            this.Controls.Add(this.NudDni);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.LblDomicilio);
            this.Controls.Add(this.TxtDomicilio);
            this.Controls.Add(this.DtpNacimiento);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.LblNuevoEditar);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblDni);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblFechaNacimiento);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtApellido);
            this.Name = "FrmAgregarEditarSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar/Editar Socio";
            ((System.ComponentModel.ISupportInitialize)(this.NudDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblNuevoEditar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DateTimePicker DtpNacimiento;
        private System.Windows.Forms.Label LblDomicilio;
        private System.Windows.Forms.TextBox TxtDomicilio;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.NumericUpDown NudDni;
        private System.Windows.Forms.NumericUpDown NudTelefono;
        private System.Windows.Forms.Label LblFoto;
        private System.Windows.Forms.PictureBox PbxFoto;
        private System.Windows.Forms.Button BtnExaminar;
        private System.Windows.Forms.Button BtnIniciarDetenerCamara;
        private System.Windows.Forms.Button BtnCapturarFoto;
    }
}