
namespace BiblioDesktop.Presentation
{
    partial class FrmAgregarEditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarEditarUsuario));
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.LblTipoUsuario = new System.Windows.Forms.Label();
            this.TxtNombreCompleto = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.CboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblNuevoEditarUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreUsuario.Location = new System.Drawing.Point(100, 103);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(140, 20);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre Completo:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblUsuario.Location = new System.Drawing.Point(92, 147);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(148, 20);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Nombre de Usuario:";
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblContraseña.Location = new System.Drawing.Point(150, 189);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(90, 20);
            this.LblContraseña.TabIndex = 2;
            this.LblContraseña.Text = "Contraseña:";
            // 
            // LblTipoUsuario
            // 
            this.LblTipoUsuario.AutoSize = true;
            this.LblTipoUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTipoUsuario.Location = new System.Drawing.Point(119, 233);
            this.LblTipoUsuario.Name = "LblTipoUsuario";
            this.LblTipoUsuario.Size = new System.Drawing.Size(121, 20);
            this.LblTipoUsuario.TabIndex = 3;
            this.LblTipoUsuario.Text = "Tipo de Usuario:";
            // 
            // TxtNombreCompleto
            // 
            this.TxtNombreCompleto.Location = new System.Drawing.Point(249, 104);
            this.TxtNombreCompleto.Name = "TxtNombreCompleto";
            this.TxtNombreCompleto.Size = new System.Drawing.Size(186, 23);
            this.TxtNombreCompleto.TabIndex = 0;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(249, 186);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.Size = new System.Drawing.Size(186, 23);
            this.TxtContraseña.TabIndex = 2;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(249, 148);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(186, 23);
            this.TxtUsuario.TabIndex = 1;
            // 
            // CboTipoUsuario
            // 
            this.CboTipoUsuario.FormattingEnabled = true;
            this.CboTipoUsuario.Location = new System.Drawing.Point(249, 233);
            this.CboTipoUsuario.Name = "CboTipoUsuario";
            this.CboTipoUsuario.Size = new System.Drawing.Size(186, 23);
            this.CboTipoUsuario.TabIndex = 3;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.Location = new System.Drawing.Point(138, 301);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(102, 56);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.Location = new System.Drawing.Point(297, 301);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(102, 56);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // LblNuevoEditarUsuario
            // 
            this.LblNuevoEditarUsuario.AutoSize = true;
            this.LblNuevoEditarUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNuevoEditarUsuario.Location = new System.Drawing.Point(119, 25);
            this.LblNuevoEditarUsuario.Name = "LblNuevoEditarUsuario";
            this.LblNuevoEditarUsuario.Size = new System.Drawing.Size(319, 40);
            this.LblNuevoEditarUsuario.TabIndex = 13;
            this.LblNuevoEditarUsuario.Text = "Agregar/Editar Usuario";
            // 
            // FrmNuevoEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 399);
            this.ControlBox = false;
            this.Controls.Add(this.LblNuevoEditarUsuario);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CboTipoUsuario);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtNombreCompleto);
            this.Controls.Add(this.LblTipoUsuario);
            this.Controls.Add(this.LblContraseña);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoEditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar/Modificar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.Label LblTipoUsuario;
        private System.Windows.Forms.TextBox TxtNombreCompleto;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.ComboBox CboTipoUsuario;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblNuevoEditarUsuario;
    }
}