namespace BiblioDesktop.Presentation
{
    partial class FrmAgregarEditarPrestamo
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
            this.LblFechaEntrega = new System.Windows.Forms.Label();
            this.LblFechaRetiro = new System.Windows.Forms.Label();
            this.LblLibro = new System.Windows.Forms.Label();
            this.LblSocio = new System.Windows.Forms.Label();
            this.LblAgregarEditarPrestamo = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CboLibros = new System.Windows.Forms.ComboBox();
            this.CboSocios = new System.Windows.Forms.ComboBox();
            this.DtpFechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.CheckBoxLibroDevuelto = new System.Windows.Forms.CheckBox();
            this.LblLibroDevuelto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblFechaEntrega
            // 
            this.LblFechaEntrega.AutoSize = true;
            this.LblFechaEntrega.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFechaEntrega.Location = new System.Drawing.Point(135, 255);
            this.LblFechaEntrega.Name = "LblFechaEntrega";
            this.LblFechaEntrega.Size = new System.Drawing.Size(116, 21);
            this.LblFechaEntrega.TabIndex = 0;
            this.LblFechaEntrega.Text = "Fecha Entrega:";
            // 
            // LblFechaRetiro
            // 
            this.LblFechaRetiro.AutoSize = true;
            this.LblFechaRetiro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFechaRetiro.Location = new System.Drawing.Point(135, 200);
            this.LblFechaRetiro.Name = "LblFechaRetiro";
            this.LblFechaRetiro.Size = new System.Drawing.Size(105, 21);
            this.LblFechaRetiro.TabIndex = 9;
            this.LblFechaRetiro.Text = "Fecha Retiro:";
            // 
            // LblLibro
            // 
            this.LblLibro.AutoSize = true;
            this.LblLibro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLibro.Location = new System.Drawing.Point(135, 147);
            this.LblLibro.Name = "LblLibro";
            this.LblLibro.Size = new System.Drawing.Size(52, 21);
            this.LblLibro.TabIndex = 10;
            this.LblLibro.Text = "Libro:";
            // 
            // LblSocio
            // 
            this.LblSocio.AutoSize = true;
            this.LblSocio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSocio.Location = new System.Drawing.Point(135, 94);
            this.LblSocio.Name = "LblSocio";
            this.LblSocio.Size = new System.Drawing.Size(55, 21);
            this.LblSocio.TabIndex = 11;
            this.LblSocio.Text = "Socio:";
            // 
            // LblAgregarEditarPrestamo
            // 
            this.LblAgregarEditarPrestamo.AutoSize = true;
            this.LblAgregarEditarPrestamo.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAgregarEditarPrestamo.Location = new System.Drawing.Point(135, 21);
            this.LblAgregarEditarPrestamo.Name = "LblAgregarEditarPrestamo";
            this.LblAgregarEditarPrestamo.Size = new System.Drawing.Size(342, 40);
            this.LblAgregarEditarPrestamo.TabIndex = 12;
            this.LblAgregarEditarPrestamo.Text = "Agregar/Editar Prestamo";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.Location = new System.Drawing.Point(170, 359);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(102, 49);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.Location = new System.Drawing.Point(331, 359);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(102, 49);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CboLibros
            // 
            this.CboLibros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboLibros.FormattingEnabled = true;
            this.CboLibros.Items.AddRange(new object[] {
            "Arte",
            "Ciencia",
            "Ciencias humanas y sociales",
            "Diccionarios",
            "Filosofía",
            "Historia",
            "Psicología",
            "Religión",
            "Terror",
            "Acción",
            "Infantil",
            "Juvenil",
            "Ciencia Ficción",
            "Cómic y Manga",
            "Fantasía",
            "Teatro",
            "Poesía",
            "Novela Romántica",
            "Novela Contemporánea",
            "Novela Histórica",
            "Novela Literaria"});
            this.CboLibros.Location = new System.Drawing.Point(291, 147);
            this.CboLibros.Name = "CboLibros";
            this.CboLibros.Size = new System.Drawing.Size(176, 23);
            this.CboLibros.TabIndex = 17;
            // 
            // CboSocios
            // 
            this.CboSocios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSocios.FormattingEnabled = true;
            this.CboSocios.Items.AddRange(new object[] {
            "Arte",
            "Ciencia",
            "Ciencias humanas y sociales",
            "Diccionarios",
            "Filosofía",
            "Historia",
            "Psicología",
            "Religión",
            "Terror",
            "Acción",
            "Infantil",
            "Juvenil",
            "Ciencia Ficción",
            "Cómic y Manga",
            "Fantasía",
            "Teatro",
            "Poesía",
            "Novela Romántica",
            "Novela Contemporánea",
            "Novela Histórica",
            "Novela Literaria"});
            this.CboSocios.Location = new System.Drawing.Point(291, 94);
            this.CboSocios.Name = "CboSocios";
            this.CboSocios.Size = new System.Drawing.Size(176, 23);
            this.CboSocios.TabIndex = 18;
            // 
            // DtpFechaRetiro
            // 
            this.DtpFechaRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaRetiro.Location = new System.Drawing.Point(291, 200);
            this.DtpFechaRetiro.Name = "DtpFechaRetiro";
            this.DtpFechaRetiro.Size = new System.Drawing.Size(176, 23);
            this.DtpFechaRetiro.TabIndex = 19;
            // 
            // DtpFechaEntrega
            // 
            this.DtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaEntrega.Location = new System.Drawing.Point(291, 255);
            this.DtpFechaEntrega.Name = "DtpFechaEntrega";
            this.DtpFechaEntrega.Size = new System.Drawing.Size(176, 23);
            this.DtpFechaEntrega.TabIndex = 20;
            this.DtpFechaEntrega.Value = new System.DateTime(2020, 12, 16, 16, 33, 37, 0);
            // 
            // CheckBoxLibroDevuelto
            // 
            this.CheckBoxLibroDevuelto.AutoSize = true;
            this.CheckBoxLibroDevuelto.Location = new System.Drawing.Point(291, 310);
            this.CheckBoxLibroDevuelto.Name = "CheckBoxLibroDevuelto";
            this.CheckBoxLibroDevuelto.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxLibroDevuelto.TabIndex = 22;
            this.CheckBoxLibroDevuelto.UseVisualStyleBackColor = true;
            // 
            // LblLibroDevuelto
            // 
            this.LblLibroDevuelto.AutoSize = true;
            this.LblLibroDevuelto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLibroDevuelto.Location = new System.Drawing.Point(135, 303);
            this.LblLibroDevuelto.Name = "LblLibroDevuelto";
            this.LblLibroDevuelto.Size = new System.Drawing.Size(122, 21);
            this.LblLibroDevuelto.TabIndex = 21;
            this.LblLibroDevuelto.Text = "Libro Devuelto:";
            // 
            // FrmAgregarEditarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 427);
            this.ControlBox = false;
            this.Controls.Add(this.CheckBoxLibroDevuelto);
            this.Controls.Add(this.LblLibroDevuelto);
            this.Controls.Add(this.DtpFechaEntrega);
            this.Controls.Add(this.DtpFechaRetiro);
            this.Controls.Add(this.CboSocios);
            this.Controls.Add(this.CboLibros);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.LblAgregarEditarPrestamo);
            this.Controls.Add(this.LblSocio);
            this.Controls.Add(this.LblLibro);
            this.Controls.Add(this.LblFechaRetiro);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblFechaEntrega);
            this.Name = "FrmAgregarEditarPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar/Editar Prestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblFechaEntrega;
        private System.Windows.Forms.Label LblFechaRetiro;
        private System.Windows.Forms.Label LblLibro;
        private System.Windows.Forms.Label LblSocio;
        private System.Windows.Forms.Label LblAgregarEditarPrestamo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox CboLibros;
        private System.Windows.Forms.ComboBox CboSocios;
        private System.Windows.Forms.DateTimePicker DtpFechaRetiro;
        private System.Windows.Forms.DateTimePicker DtpFechaEntrega;
        private System.Windows.Forms.CheckBox CheckBoxLibroDevuelto;
        private System.Windows.Forms.Label LblLibroDevuelto;
    }
}