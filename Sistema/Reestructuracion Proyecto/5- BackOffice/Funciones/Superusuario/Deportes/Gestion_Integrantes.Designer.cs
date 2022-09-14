using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Funciones.Superusuario.Deportes
{
    partial class Gestion_Integrantes
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
            this.btnIngresar = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridDeportistas = new System.Windows.Forms.DataGridView();
            this.dataGridDeportistas_Sin_Equipo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiarFiltros = new Guna.UI2.WinForms.Guna2Button();
            this.cmoEquipos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSacar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeportistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeportistas_Sin_Equipo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnIngresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIngresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIngresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIngresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIngresar.FillColor = System.Drawing.Color.Transparent;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.ForeColor = System.Drawing.Color.Black;
            this.btnIngresar.Location = new System.Drawing.Point(464, 114);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(151, 29);
            this.btnIngresar.TabIndex = 67;
            this.btnIngresar.Text = "<-----";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // dataGridDeportistas
            // 
            this.dataGridDeportistas.AllowUserToAddRows = false;
            this.dataGridDeportistas.AllowUserToDeleteRows = false;
            this.dataGridDeportistas.AllowUserToResizeColumns = false;
            this.dataGridDeportistas.AllowUserToResizeRows = false;
            this.dataGridDeportistas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDeportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDeportistas.ColumnHeadersVisible = false;
            this.dataGridDeportistas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridDeportistas.Location = new System.Drawing.Point(211, 77);
            this.dataGridDeportistas.MultiSelect = false;
            this.dataGridDeportistas.Name = "dataGridDeportistas";
            this.dataGridDeportistas.RowHeadersVisible = false;
            this.dataGridDeportistas.RowHeadersWidth = 51;
            this.dataGridDeportistas.RowTemplate.Height = 25;
            this.dataGridDeportistas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridDeportistas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDeportistas.Size = new System.Drawing.Size(188, 230);
            this.dataGridDeportistas.TabIndex = 60;
            this.dataGridDeportistas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDeportistas_CellClick);
            // 
            // dataGridDeportistas_Sin_Equipo
            // 
            this.dataGridDeportistas_Sin_Equipo.AllowUserToAddRows = false;
            this.dataGridDeportistas_Sin_Equipo.AllowUserToDeleteRows = false;
            this.dataGridDeportistas_Sin_Equipo.AllowUserToResizeColumns = false;
            this.dataGridDeportistas_Sin_Equipo.AllowUserToResizeRows = false;
            this.dataGridDeportistas_Sin_Equipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDeportistas_Sin_Equipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDeportistas_Sin_Equipo.ColumnHeadersVisible = false;
            this.dataGridDeportistas_Sin_Equipo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridDeportistas_Sin_Equipo.Location = new System.Drawing.Point(672, 77);
            this.dataGridDeportistas_Sin_Equipo.Name = "dataGridDeportistas_Sin_Equipo";
            this.dataGridDeportistas_Sin_Equipo.RowHeadersVisible = false;
            this.dataGridDeportistas_Sin_Equipo.RowHeadersWidth = 51;
            this.dataGridDeportistas_Sin_Equipo.RowTemplate.Height = 25;
            this.dataGridDeportistas_Sin_Equipo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridDeportistas_Sin_Equipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDeportistas_Sin_Equipo.Size = new System.Drawing.Size(188, 230);
            this.dataGridDeportistas_Sin_Equipo.TabIndex = 59;
            this.dataGridDeportistas_Sin_Equipo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDeportistas_Sin_Equipo_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(100)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.btnLimpiarFiltros);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 366);
            this.panel1.TabIndex = 56;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnLimpiarFiltros.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarFiltros.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarFiltros.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiarFiltros.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpiarFiltros.FillColor = System.Drawing.Color.Transparent;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(0, 12);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(140, 25);
            this.btnLimpiarFiltros.TabIndex = 32;
            this.btnLimpiarFiltros.Text = "Limpiar filtros";
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // cmoEquipos
            // 
            this.cmoEquipos.FormattingEnabled = true;
            this.cmoEquipos.Location = new System.Drawing.Point(243, 53);
            this.cmoEquipos.Name = "cmoEquipos";
            this.cmoEquipos.Size = new System.Drawing.Size(121, 21);
            this.cmoEquipos.TabIndex = 69;
            this.cmoEquipos.SelectedIndexChanged += new System.EventHandler(this.cmoEquipos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(685, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "Jugadores sin equipo";
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnSacar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSacar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSacar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSacar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSacar.FillColor = System.Drawing.Color.Transparent;
            this.btnSacar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSacar.ForeColor = System.Drawing.Color.Black;
            this.btnSacar.Location = new System.Drawing.Point(464, 229);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(151, 29);
            this.btnSacar.TabIndex = 71;
            this.btnSacar.Text = "----->";
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // Gestion_Integrantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmoEquipos);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.dataGridDeportistas);
            this.Controls.Add(this.dataGridDeportistas_Sin_Equipo);
            this.Controls.Add(this.panel1);
            this.Name = "Gestion_Integrantes";
            this.Size = new System.Drawing.Size(927, 366);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeportistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeportistas_Sin_Equipo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnIngresar;
        private DataGridView dataGridDeportistas;
        private DataGridView dataGridDeportistas_Sin_Equipo;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarFiltros;
        private ComboBox cmoEquipos;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSacar;
    }
}
