using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Funciones.Notificativo.Baja_Cuenta
{
    partial class Rebocar_Cuenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRebocar = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscarUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(100)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.btnRebocar);
            this.panel2.Controls.Add(this.btnBuscarUsuario);
            this.panel2.Controls.Add(this.txtBuscarUsuario);
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 366);
            this.panel2.TabIndex = 61;
            // 
            // btnRebocar
            // 
            this.btnRebocar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnRebocar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRebocar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRebocar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRebocar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRebocar.FillColor = System.Drawing.Color.Transparent;
            this.btnRebocar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRebocar.ForeColor = System.Drawing.Color.Black;
            this.btnRebocar.Location = new System.Drawing.Point(0, 239);
            this.btnRebocar.Name = "btnRebocar";
            this.btnRebocar.Size = new System.Drawing.Size(139, 25);
            this.btnRebocar.TabIndex = 59;
            this.btnRebocar.Text = "Rebocar usuario";
            this.btnRebocar.Click += new System.EventHandler(this.btnRebocar_Click);
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
            this.btnBuscarUsuario.Location = new System.Drawing.Point(1, 61);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(139, 25);
            this.btnBuscarUsuario.TabIndex = 58;
            this.btnBuscarUsuario.Text = "Buscar usuario";
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(1, 92);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(139, 20);
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
            this.btnLimpiar.Location = new System.Drawing.Point(0, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(140, 25);
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
            this.dataGridUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dataGridUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridUsuarios.GridColor = System.Drawing.Color.White;
            this.dataGridUsuarios.Location = new System.Drawing.Point(140, 0);
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            this.dataGridUsuarios.RowHeadersVisible = false;
            this.dataGridUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridUsuarios.RowTemplate.Height = 25;
            this.dataGridUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsuarios.ShowCellToolTips = false;
            this.dataGridUsuarios.Size = new System.Drawing.Size(787, 366);
            this.dataGridUsuarios.TabIndex = 63;
            // 
            // Rebocar_Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.dataGridUsuarios);
            this.Controls.Add(this.panel2);
            this.Name = "Rebocar_Cuenta";
            this.Size = new System.Drawing.Size(927, 366);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private Guna.UI2.WinForms.Guna2Button btnBuscarUsuario;
        private TextBox txtBuscarUsuario;
        private Guna.UI2.WinForms.Guna2Button btnRebocar;
        private DataGridView dataGridUsuarios;
    }
}
