
namespace BiblioDesktop.Presentation
{
    partial class FrmInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.PbaBarraProgreso = new System.Windows.Forms.ProgressBar();
            this.LblPorcentaje = new System.Windows.Forms.Label();
            this.TmrCronometro = new System.Windows.Forms.Timer(this.components);
            this.Imagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // PbaBarraProgreso
            // 
            this.PbaBarraProgreso.Location = new System.Drawing.Point(13, 142);
            this.PbaBarraProgreso.Name = "PbaBarraProgreso";
            this.PbaBarraProgreso.Size = new System.Drawing.Size(579, 31);
            this.PbaBarraProgreso.TabIndex = 2;
            // 
            // LblPorcentaje
            // 
            this.LblPorcentaje.AutoSize = true;
            this.LblPorcentaje.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPorcentaje.Location = new System.Drawing.Point(598, 142);
            this.LblPorcentaje.Name = "LblPorcentaje";
            this.LblPorcentaje.Size = new System.Drawing.Size(0, 21);
            this.LblPorcentaje.TabIndex = 3;
            // 
            // TmrCronometro
            // 
            this.TmrCronometro.Enabled = true;
            this.TmrCronometro.Interval = 50;
            this.TmrCronometro.Tick += new System.EventHandler(this.TmrCronometro_Tick);
            // 
            // Imagen
            // 
            this.Imagen.Image = ((System.Drawing.Image)(resources.GetObject("Imagen.Image")));
            this.Imagen.Location = new System.Drawing.Point(31, 21);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(585, 98);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen.TabIndex = 4;
            this.Imagen.TabStop = false;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 186);
            this.ControlBox = false;
            this.Controls.Add(this.Imagen);
            this.Controls.Add(this.LblPorcentaje);
            this.Controls.Add(this.PbaBarraProgreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSplash";
            this.Activated += new System.EventHandler(this.FrmInicio_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar PbaBarraProgreso;
        private System.Windows.Forms.Label LblPorcentaje;
        private System.Windows.Forms.Timer TmrCronometro;
        private System.Windows.Forms.PictureBox Imagen;
    }
}