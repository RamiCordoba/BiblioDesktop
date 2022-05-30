
namespace BiblioDesktop.Presentation
{
    partial class FrmTematicas
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
            this.LblTematicas = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.ChkVerEliminadas = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTematicas
            // 
            this.LblTematicas.AutoSize = true;
            this.LblTematicas.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTematicas.Location = new System.Drawing.Point(244, 9);
            this.LblTematicas.Name = "LblTematicas";
            this.LblTematicas.Size = new System.Drawing.Size(198, 45);
            this.LblTematicas.TabIndex = 0;
            this.LblTematicas.Text = "TEMÁTICAS";
            // 
            // grid
            // 
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(108, 70);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 25;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(471, 371);
            this.grid.TabIndex = 1;
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(214, 484);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(240, 23);
            this.TxtBusqueda.TabIndex = 5;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblBuscar.Location = new System.Drawing.Point(12, 475);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(196, 32);
            this.LblBuscar.TabIndex = 4;
            this.LblBuscar.Text = "Buscar Temática:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregar.Location = new System.Drawing.Point(84, 544);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(139, 58);
            this.BtnAgregar.TabIndex = 8;
            this.BtnAgregar.Text = "&Agregar Temática";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminar.Location = new System.Drawing.Point(469, 544);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(138, 58);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "&Eliminar Temática";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditar.Location = new System.Drawing.Point(278, 544);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(133, 58);
            this.BtnEditar.TabIndex = 10;
            this.BtnEditar.Text = "&Editar Temática";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // ChkVerEliminadas
            // 
            this.ChkVerEliminadas.AutoSize = true;
            this.ChkVerEliminadas.BackColor = System.Drawing.Color.Transparent;
            this.ChkVerEliminadas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChkVerEliminadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChkVerEliminadas.Location = new System.Drawing.Point(513, 484);
            this.ChkVerEliminadas.Name = "ChkVerEliminadas";
            this.ChkVerEliminadas.Size = new System.Drawing.Size(133, 25);
            this.ChkVerEliminadas.TabIndex = 14;
            this.ChkVerEliminadas.Text = "Ver Eliminadas";
            this.ChkVerEliminadas.UseVisualStyleBackColor = false;
            this.ChkVerEliminadas.CheckedChanged += new System.EventHandler(this.ChkVerEliminadas_CheckedChanged);
            // 
            // FrmTematicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(690, 633);
            this.Controls.Add(this.ChkVerEliminadas);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.LblTematicas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmTematicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temáticas";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTematicas;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.CheckBox ChkVerEliminadas;
    }
}