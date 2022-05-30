
namespace BiblioDesktop.Presentation
{
    partial class FrmLibros
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
            this.LblLibros = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnListaLibros = new System.Windows.Forms.Button();
            this.ChkVerEliminados = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // LblLibros
            // 
            this.LblLibros.AutoSize = true;
            this.LblLibros.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLibros.Location = new System.Drawing.Point(378, 25);
            this.LblLibros.Name = "LblLibros";
            this.LblLibros.Size = new System.Drawing.Size(130, 45);
            this.LblLibros.TabIndex = 0;
            this.LblLibros.Text = "LIBROS";
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(43, 98);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 25;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(801, 229);
            this.grid.TabIndex = 1;
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TxtBusqueda.Location = new System.Drawing.Point(294, 362);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(240, 23);
            this.TxtBusqueda.TabIndex = 5;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // LblBuscar
            // 
            this.LblBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblBuscar.Location = new System.Drawing.Point(112, 353);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(154, 32);
            this.LblBuscar.TabIndex = 4;
            this.LblBuscar.Text = "Buscar Libro:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregar.Location = new System.Drawing.Point(286, 430);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(133, 58);
            this.BtnAgregar.TabIndex = 8;
            this.BtnAgregar.Text = "&Agregar Libro";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminar.Location = new System.Drawing.Point(671, 430);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(133, 58);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "&Eliminar Libro";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditar.Location = new System.Drawing.Point(475, 430);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(133, 58);
            this.BtnEditar.TabIndex = 10;
            this.BtnEditar.Text = "&Editar Libro";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnListaLibros
            // 
            this.BtnListaLibros.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnListaLibros.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnListaLibros.Location = new System.Drawing.Point(92, 430);
            this.BtnListaLibros.Name = "BtnListaLibros";
            this.BtnListaLibros.Size = new System.Drawing.Size(133, 58);
            this.BtnListaLibros.TabIndex = 11;
            this.BtnListaLibros.Text = "&Lista Libros";
            this.BtnListaLibros.UseVisualStyleBackColor = true;
            this.BtnListaLibros.Click += new System.EventHandler(this.BtnListaLibros_Click);
            // 
            // ChkVerEliminados
            // 
            this.ChkVerEliminados.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ChkVerEliminados.AutoSize = true;
            this.ChkVerEliminados.BackColor = System.Drawing.Color.Transparent;
            this.ChkVerEliminados.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChkVerEliminados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChkVerEliminados.Location = new System.Drawing.Point(645, 362);
            this.ChkVerEliminados.Name = "ChkVerEliminados";
            this.ChkVerEliminados.Size = new System.Drawing.Size(135, 25);
            this.ChkVerEliminados.TabIndex = 12;
            this.ChkVerEliminados.Text = "Ver Eliminados";
            this.ChkVerEliminados.UseVisualStyleBackColor = false;
            this.ChkVerEliminados.CheckedChanged += new System.EventHandler(this.ChkVerEliminados_CheckedChanged);
            // 
            // FrmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(886, 536);
            this.Controls.Add(this.ChkVerEliminados);
            this.Controls.Add(this.BtnListaLibros);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.LblLibros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLibros;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnListaLibros;
        private System.Windows.Forms.CheckBox ChkVerEliminados;
    }
}