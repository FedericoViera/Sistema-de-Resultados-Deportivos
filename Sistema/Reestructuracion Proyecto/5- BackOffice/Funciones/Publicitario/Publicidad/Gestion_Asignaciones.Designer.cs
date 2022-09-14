using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Funciones.Publicitario.Publicidad
{
    partial class Gestion_Asignaciones
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscarBanner = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarBanner = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.dataGridBanners = new System.Windows.Forms.DataGridView();
            this.btnAsociar = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBanners)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(100)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.btnBuscarBanner);
            this.panel2.Controls.Add(this.txtBuscarBanner);
            this.panel2.Controls.Add(this.btnBuscarUsuario);
            this.panel2.Controls.Add(this.txtBuscarUsuario);
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 366);
            this.panel2.TabIndex = 61;
            // 
            // btnBuscarBanner
            // 
            this.btnBuscarBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnBuscarBanner.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarBanner.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarBanner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarBanner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarBanner.FillColor = System.Drawing.Color.Transparent;
            this.btnBuscarBanner.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBuscarBanner.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarBanner.Location = new System.Drawing.Point(-2, 115);
            this.btnBuscarBanner.Name = "btnBuscarBanner";
            this.btnBuscarBanner.Size = new System.Drawing.Size(142, 25);
            this.btnBuscarBanner.TabIndex = 60;
            this.btnBuscarBanner.Text = "Buscar banner";
            this.btnBuscarBanner.Click += new System.EventHandler(this.btnBuscarBanner_Click);
            // 
            // txtBuscarBanner
            // 
            this.txtBuscarBanner.Location = new System.Drawing.Point(1, 146);
            this.txtBuscarBanner.Name = "txtBuscarBanner";
            this.txtBuscarBanner.Size = new System.Drawing.Size(139, 20);
            this.txtBuscarBanner.TabIndex = 59;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnBuscarUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarUsuario.FillColor = System.Drawing.Color.Transparent;
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBuscarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(-2, 205);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(142, 25);
            this.btnBuscarUsuario.TabIndex = 58;
            this.btnBuscarUsuario.Text = "Buscar usuario";
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(1, 235);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(138, 20);
            this.txtBuscarUsuario.TabIndex = 57;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnLimpiar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpiar.FillColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(-5, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(145, 25);
            this.btnLimpiar.TabIndex = 56;
            this.btnLimpiar.Text = "Limpiar filtros";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dataGridUsuarios
            // 
            this.dataGridUsuarios.AllowUserToAddRows = false;
            this.dataGridUsuarios.AllowUserToDeleteRows = false;
            this.dataGridUsuarios.AllowUserToResizeColumns = false;
            this.dataGridUsuarios.AllowUserToResizeRows = false;
            this.dataGridUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridUsuarios.Location = new System.Drawing.Point(449, 14);
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            this.dataGridUsuarios.RowHeadersVisible = false;
            this.dataGridUsuarios.RowHeadersWidth = 51;
            this.dataGridUsuarios.RowTemplate.Height = 25;
            this.dataGridUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsuarios.Size = new System.Drawing.Size(475, 331);
            this.dataGridUsuarios.TabIndex = 92;
            // 
            // dataGridBanners
            // 
            this.dataGridBanners.AllowUserToAddRows = false;
            this.dataGridBanners.AllowUserToDeleteRows = false;
            this.dataGridBanners.AllowUserToResizeColumns = false;
            this.dataGridBanners.AllowUserToResizeRows = false;
            this.dataGridBanners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBanners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBanners.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridBanners.Location = new System.Drawing.Point(199, 14);
            this.dataGridBanners.Name = "dataGridBanners";
            this.dataGridBanners.RowHeadersVisible = false;
            this.dataGridBanners.RowHeadersWidth = 51;
            this.dataGridBanners.RowTemplate.Height = 25;
            this.dataGridBanners.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridBanners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBanners.Size = new System.Drawing.Size(195, 298);
            this.dataGridBanners.TabIndex = 93;
            // 
            // btnAsociar
            // 
            this.btnAsociar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnAsociar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAsociar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAsociar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAsociar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAsociar.FillColor = System.Drawing.Color.Transparent;
            this.btnAsociar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAsociar.ForeColor = System.Drawing.Color.Black;
            this.btnAsociar.Location = new System.Drawing.Point(206, 318);
            this.btnAsociar.Name = "btnAsociar";
            this.btnAsociar.Size = new System.Drawing.Size(180, 29);
            this.btnAsociar.TabIndex = 57;
            this.btnAsociar.Text = "Asociar banner";
            this.btnAsociar.Click += new System.EventHandler(this.btnAsociar_Click);
            // 
            // Gestion_Asignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.btnAsociar);
            this.Controls.Add(this.dataGridBanners);
            this.Controls.Add(this.dataGridUsuarios);
            this.Controls.Add(this.panel2);
            this.Name = "Gestion_Asignaciones";
            this.Size = new System.Drawing.Size(927, 366);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBanners)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private DataGridView dataGridUsuarios;
        private DataGridView dataGridBanners;
        private Guna.UI2.WinForms.Guna2Button btnAsociar;
        private Guna.UI2.WinForms.Guna2Button btnBuscarUsuario;
        private TextBox txtBuscarUsuario;
        private Guna.UI2.WinForms.Guna2Button btnBuscarBanner;
        private TextBox txtBuscarBanner;
    }
}
