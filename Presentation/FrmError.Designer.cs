
namespace BiblioDesktop.Presentation
{
    partial class FrmError
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNumeroError = new System.Windows.Forms.TextBox();
            this.TxtMensajeError = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPilaDeLlamada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Error N ° :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mensaje :";
            // 
            // TxtNumeroError
            // 
            this.TxtNumeroError.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNumeroError.Location = new System.Drawing.Point(124, 12);
            this.TxtNumeroError.Name = "TxtNumeroError";
            this.TxtNumeroError.Size = new System.Drawing.Size(148, 27);
            this.TxtNumeroError.TabIndex = 2;
            // 
            // TxtMensajeError
            // 
            this.TxtMensajeError.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtMensajeError.Location = new System.Drawing.Point(124, 60);
            this.TxtMensajeError.Multiline = true;
            this.TxtMensajeError.Name = "TxtMensajeError";
            this.TxtMensajeError.Size = new System.Drawing.Size(594, 80);
            this.TxtMensajeError.TabIndex = 3;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAceptar.Location = new System.Drawing.Point(612, 351);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(106, 41);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Código :";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCodigo.Location = new System.Drawing.Point(124, 155);
            this.TxtCodigo.Multiline = true;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(594, 80);
            this.TxtCodigo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(62, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pila :";
            // 
            // TxtPilaDeLlamada
            // 
            this.TxtPilaDeLlamada.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPilaDeLlamada.Location = new System.Drawing.Point(124, 258);
            this.TxtPilaDeLlamada.Multiline = true;
            this.TxtPilaDeLlamada.Name = "TxtPilaDeLlamada";
            this.TxtPilaDeLlamada.ReadOnly = true;
            this.TxtPilaDeLlamada.Size = new System.Drawing.Size(594, 80);
            this.TxtPilaDeLlamada.TabIndex = 8;
            // 
            // FrmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(769, 404);
            this.ControlBox = false;
            this.Controls.Add(this.TxtPilaDeLlamada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtMensajeError);
            this.Controls.Add(this.TxtNumeroError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmError";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Error de Sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNumeroError;
        private System.Windows.Forms.TextBox TxtMensajeError;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPilaDeLlamada;
    }
}