
namespace BiblioDesktop.Presentation
{
    partial class FrmUsuarios
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
            this.LblUsuarios = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.LbUsuario = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.ChkVerEliminados = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUsuarios
            // 
            this.LblUsuarios.AutoSize = true;
            this.LblUsuarios.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblUsuarios.Location = new System.Drawing.Point(363, 26);
            this.LblUsuarios.Name = "LblUsuarios";
            this.LblUsuarios.Size = new System.Drawing.Size(179, 45);
            this.LblUsuarios.TabIndex = 0;
            this.LblUsuarios.Text = "USUARIOS";
            // 
            // grid
            // 
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
            this.TxtBusqueda.Location = new System.Drawing.Point(302, 367);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(240, 23);
            this.TxtBusqueda.TabIndex = 5;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // LbUsuario
            // 
            this.LbUsuario.AutoSize = true;
            this.LbUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbUsuario.Location = new System.Drawing.Point(98, 360);
            this.LbUsuario.Name = "LbUsuario";
            this.LbUsuario.Size = new System.Drawing.Size(182, 32);
            this.LbUsuario.TabIndex = 4;
            this.LbUsuario.Text = "Buscar Usuario:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregar.Location = new System.Drawing.Point(196, 427);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(133, 58);
            this.BtnAgregar.TabIndex = 8;
            this.BtnAgregar.Text = "&Agregar Usuario";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminar.Location = new System.Drawing.Point(578, 427);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(133, 58);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "&Eliminar Usuario";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditar.Location = new System.Drawing.Point(387, 427);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(133, 58);
            this.BtnEditar.TabIndex = 10;
            this.BtnEditar.Text = "&Editar Usuario";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // ChkVerEliminados
            // 
            this.ChkVerEliminados.AutoSize = true;
            this.ChkVerEliminados.BackColor = System.Drawing.Color.Transparent;
            this.ChkVerEliminados.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChkVerEliminados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChkVerEliminados.Location = new System.Drawing.Point(650, 367);
            this.ChkVerEliminados.Name = "ChkVerEliminados";
            this.ChkVerEliminados.Size = new System.Drawing.Size(135, 25);
            this.ChkVerEliminados.TabIndex = 13;
            this.ChkVerEliminados.Text = "Ver Eliminados";
            this.ChkVerEliminados.UseVisualStyleBackColor = false;
            this.ChkVerEliminados.CheckedChanged += new System.EventHandler(this.ChkVerEliminados_CheckedChanged);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(886, 536);
            this.Controls.Add(this.ChkVerEliminados);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.LbUsuario);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.LblUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsuarios;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label LbUsuario;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.CheckBox ChkVerEliminados;
    }
}