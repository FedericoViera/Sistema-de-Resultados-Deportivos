using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Funciones.Superusuario.Paises
{
    partial class Gestion_Otros
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
            this.btnEliminarPais = new Guna.UI2.WinForms.Guna2Button();
            this.tablaPaises = new System.Windows.Forms.DataGridView();
            this.deportes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrearPais = new Guna.UI2.WinForms.Guna2Button();
            this.txtAgregarPais = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiarFiltros = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarEmpresa = new Guna.UI2.WinForms.Guna2Button();
            this.tablaEmpresas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrearEmpresa = new Guna.UI2.WinForms.Guna2Button();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.tablaServidores = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizarIP = new Guna.UI2.WinForms.Guna2Button();
            this.txtIpServidor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPaises)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaServidores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarPais
            // 
            this.btnEliminarPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnEliminarPais.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarPais.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarPais.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarPais.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarPais.FillColor = System.Drawing.Color.Transparent;
            this.btnEliminarPais.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminarPais.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarPais.Location = new System.Drawing.Point(217, 301);
            this.btnEliminarPais.Name = "btnEliminarPais";
            this.btnEliminarPais.Size = new System.Drawing.Size(151, 29);
            this.btnEliminarPais.TabIndex = 54;
            this.btnEliminarPais.Text = "Eliminar pais";
            this.btnEliminarPais.Click += new System.EventHandler(this.btnEliminarPais_Click);
            // 
            // tablaPaises
            // 
            this.tablaPaises.AllowUserToAddRows = false;
            this.tablaPaises.AllowUserToDeleteRows = false;
            this.tablaPaises.AllowUserToResizeColumns = false;
            this.tablaPaises.AllowUserToResizeRows = false;
            this.tablaPaises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPaises.ColumnHeadersVisible = false;
            this.tablaPaises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deportes});
            this.tablaPaises.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaPaises.Location = new System.Drawing.Point(217, 96);
            this.tablaPaises.MultiSelect = false;
            this.tablaPaises.Name = "tablaPaises";
            this.tablaPaises.RowHeadersVisible = false;
            this.tablaPaises.RowHeadersWidth = 51;
            this.tablaPaises.RowTemplate.Height = 25;
            this.tablaPaises.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaPaises.Size = new System.Drawing.Size(151, 199);
            this.tablaPaises.TabIndex = 53;
            // 
            // deportes
            // 
            this.deportes.HeaderText = "deportes";
            this.deportes.MinimumWidth = 6;
            this.deportes.Name = "deportes";
            // 
            // btnCrearPais
            // 
            this.btnCrearPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnCrearPais.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearPais.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearPais.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrearPais.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrearPais.FillColor = System.Drawing.Color.Transparent;
            this.btnCrearPais.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCrearPais.ForeColor = System.Drawing.Color.Black;
            this.btnCrearPais.Location = new System.Drawing.Point(217, 32);
            this.btnCrearPais.Name = "btnCrearPais";
            this.btnCrearPais.Size = new System.Drawing.Size(151, 29);
            this.btnCrearPais.TabIndex = 52;
            this.btnCrearPais.Text = "Agregar pais";
            this.btnCrearPais.Click += new System.EventHandler(this.btnCrearPais_Click);
            // 
            // txtAgregarPais
            // 
            this.txtAgregarPais.Location = new System.Drawing.Point(217, 67);
            this.txtAgregarPais.Name = "txtAgregarPais";
            this.txtAgregarPais.Size = new System.Drawing.Size(151, 20);
            this.txtAgregarPais.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(100)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.btnLimpiarFiltros);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 366);
            this.panel1.TabIndex = 51;
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
            // 
            // btnEliminarEmpresa
            // 
            this.btnEliminarEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnEliminarEmpresa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarEmpresa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarEmpresa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarEmpresa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarEmpresa.FillColor = System.Drawing.Color.Transparent;
            this.btnEliminarEmpresa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminarEmpresa.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarEmpresa.Location = new System.Drawing.Point(456, 300);
            this.btnEliminarEmpresa.Name = "btnEliminarEmpresa";
            this.btnEliminarEmpresa.Size = new System.Drawing.Size(151, 29);
            this.btnEliminarEmpresa.TabIndex = 58;
            this.btnEliminarEmpresa.Text = "Eliminar empresa";
            this.btnEliminarEmpresa.Click += new System.EventHandler(this.btnEliminarEmpresa_Click);
            // 
            // tablaEmpresas
            // 
            this.tablaEmpresas.AllowUserToAddRows = false;
            this.tablaEmpresas.AllowUserToDeleteRows = false;
            this.tablaEmpresas.AllowUserToResizeColumns = false;
            this.tablaEmpresas.AllowUserToResizeRows = false;
            this.tablaEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEmpresas.ColumnHeadersVisible = false;
            this.tablaEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.tablaEmpresas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaEmpresas.Location = new System.Drawing.Point(456, 93);
            this.tablaEmpresas.MultiSelect = false;
            this.tablaEmpresas.Name = "tablaEmpresas";
            this.tablaEmpresas.RowHeadersVisible = false;
            this.tablaEmpresas.RowHeadersWidth = 51;
            this.tablaEmpresas.RowTemplate.Height = 25;
            this.tablaEmpresas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaEmpresas.Size = new System.Drawing.Size(151, 199);
            this.tablaEmpresas.TabIndex = 57;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "deportes";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // btnCrearEmpresa
            // 
            this.btnCrearEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnCrearEmpresa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearEmpresa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearEmpresa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrearEmpresa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrearEmpresa.FillColor = System.Drawing.Color.Transparent;
            this.btnCrearEmpresa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCrearEmpresa.ForeColor = System.Drawing.Color.Black;
            this.btnCrearEmpresa.Location = new System.Drawing.Point(456, 32);
            this.btnCrearEmpresa.Name = "btnCrearEmpresa";
            this.btnCrearEmpresa.Size = new System.Drawing.Size(151, 29);
            this.btnCrearEmpresa.TabIndex = 56;
            this.btnCrearEmpresa.Text = "Agregar empresa";
            this.btnCrearEmpresa.Click += new System.EventHandler(this.btnCrearEmpresa_Click);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(456, 67);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(152, 20);
            this.txtEmpresa.TabIndex = 55;
            // 
            // tablaServidores
            // 
            this.tablaServidores.AllowUserToAddRows = false;
            this.tablaServidores.AllowUserToDeleteRows = false;
            this.tablaServidores.AllowUserToResizeColumns = false;
            this.tablaServidores.AllowUserToResizeRows = false;
            this.tablaServidores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaServidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaServidores.ColumnHeadersVisible = false;
            this.tablaServidores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.tablaServidores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaServidores.Location = new System.Drawing.Point(689, 96);
            this.tablaServidores.MultiSelect = false;
            this.tablaServidores.Name = "tablaServidores";
            this.tablaServidores.RowHeadersVisible = false;
            this.tablaServidores.RowHeadersWidth = 51;
            this.tablaServidores.RowTemplate.Height = 25;
            this.tablaServidores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaServidores.Size = new System.Drawing.Size(152, 199);
            this.tablaServidores.TabIndex = 61;
            this.tablaServidores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaServidores_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "deportes";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // btnActualizarIP
            // 
            this.btnActualizarIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnActualizarIP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizarIP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizarIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActualizarIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActualizarIP.FillColor = System.Drawing.Color.Transparent;
            this.btnActualizarIP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnActualizarIP.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarIP.Location = new System.Drawing.Point(689, 32);
            this.btnActualizarIP.Name = "btnActualizarIP";
            this.btnActualizarIP.Size = new System.Drawing.Size(151, 29);
            this.btnActualizarIP.TabIndex = 60;
            this.btnActualizarIP.Text = "Actualizar IP";
            this.btnActualizarIP.Click += new System.EventHandler(this.btnActualizarIP_Click);
            // 
            // txtIpServidor
            // 
            this.txtIpServidor.Location = new System.Drawing.Point(689, 67);
            this.txtIpServidor.Name = "txtIpServidor";
            this.txtIpServidor.Size = new System.Drawing.Size(153, 20);
            this.txtIpServidor.TabIndex = 59;
            // 
            // Gestion_Otros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.tablaServidores);
            this.Controls.Add(this.btnActualizarIP);
            this.Controls.Add(this.txtIpServidor);
            this.Controls.Add(this.btnEliminarEmpresa);
            this.Controls.Add(this.tablaEmpresas);
            this.Controls.Add(this.btnCrearEmpresa);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.btnEliminarPais);
            this.Controls.Add(this.tablaPaises);
            this.Controls.Add(this.btnCrearPais);
            this.Controls.Add(this.txtAgregarPais);
            this.Controls.Add(this.panel1);
            this.Name = "Gestion_Otros";
            this.Size = new System.Drawing.Size(927, 366);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPaises)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaServidores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnEliminarPais;
        private DataGridView tablaPaises;
        private DataGridViewTextBoxColumn deportes;
        private Guna.UI2.WinForms.Guna2Button btnCrearPais;
        private TextBox txtAgregarPais;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarFiltros;
        private Guna.UI2.WinForms.Guna2Button btnEliminarEmpresa;
        private DataGridView tablaEmpresas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Guna.UI2.WinForms.Guna2Button btnCrearEmpresa;
        private TextBox txtEmpresa;
        private DataGridView tablaServidores;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Guna.UI2.WinForms.Guna2Button btnActualizarIP;
        private TextBox txtIpServidor;
    }
}
