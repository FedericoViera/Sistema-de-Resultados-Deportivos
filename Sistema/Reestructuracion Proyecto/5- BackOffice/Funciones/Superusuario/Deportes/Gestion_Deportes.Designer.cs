using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Funciones.Superusuario.Deportes
{
    partial class Gestion_Deportes
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
            this.btnAgregarDeporte = new Guna.UI2.WinForms.Guna2Button();
            this.txtDeporte = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiarFiltros = new Guna.UI2.WinForms.Guna2Button();
            this.tablaDeportes = new System.Windows.Forms.DataGridView();
            this.deportes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaCatDeportes = new System.Windows.Forms.DataGridView();
            this.Categorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrearDepor = new Guna.UI2.WinForms.Guna2Button();
            this.txtAgregarCatDep = new System.Windows.Forms.TextBox();
            this.btnEliminarDeporte = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarCatDep = new Guna.UI2.WinForms.Guna2Button();
            this.txtDeporteAsociar = new System.Windows.Forms.TextBox();
            this.txtCategoriaAsociar = new System.Windows.Forms.TextBox();
            this.btnAsociar = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCatDeportes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarDeporte
            // 
            this.btnAgregarDeporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnAgregarDeporte.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarDeporte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarDeporte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarDeporte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarDeporte.FillColor = System.Drawing.Color.Transparent;
            this.btnAgregarDeporte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregarDeporte.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarDeporte.Location = new System.Drawing.Point(210, 18);
            this.btnAgregarDeporte.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAgregarDeporte.Name = "btnAgregarDeporte";
            this.btnAgregarDeporte.Size = new System.Drawing.Size(151, 29);
            this.btnAgregarDeporte.TabIndex = 44;
            this.btnAgregarDeporte.Text = "Agregar deporte";
            this.btnAgregarDeporte.Click += new System.EventHandler(this.btnAgregarDeporte_Click);
            // 
            // txtDeporte
            // 
            this.txtDeporte.Location = new System.Drawing.Point(210, 53);
            this.txtDeporte.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDeporte.Name = "txtDeporte";
            this.txtDeporte.Size = new System.Drawing.Size(151, 20);
            this.txtDeporte.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(100)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.btnLimpiarFiltros);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 366);
            this.panel1.TabIndex = 38;
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
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(140, 25);
            this.btnLimpiarFiltros.TabIndex = 32;
            this.btnLimpiarFiltros.Text = "Limpiar filtros";
            // 
            // tablaDeportes
            // 
            this.tablaDeportes.AllowUserToAddRows = false;
            this.tablaDeportes.AllowUserToDeleteRows = false;
            this.tablaDeportes.AllowUserToResizeColumns = false;
            this.tablaDeportes.AllowUserToResizeRows = false;
            this.tablaDeportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaDeportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDeportes.ColumnHeadersVisible = false;
            this.tablaDeportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deportes});
            this.tablaDeportes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaDeportes.Location = new System.Drawing.Point(210, 84);
            this.tablaDeportes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tablaDeportes.MultiSelect = false;
            this.tablaDeportes.Name = "tablaDeportes";
            this.tablaDeportes.RowHeadersVisible = false;
            this.tablaDeportes.RowHeadersWidth = 51;
            this.tablaDeportes.RowTemplate.Height = 25;
            this.tablaDeportes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaDeportes.Size = new System.Drawing.Size(151, 230);
            this.tablaDeportes.TabIndex = 46;
            this.tablaDeportes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDeportes_CellContentClick);
            // 
            // deportes
            // 
            this.deportes.HeaderText = "deportes";
            this.deportes.MinimumWidth = 6;
            this.deportes.Name = "deportes";
            // 
            // tablaCatDeportes
            // 
            this.tablaCatDeportes.AllowUserToAddRows = false;
            this.tablaCatDeportes.AllowUserToDeleteRows = false;
            this.tablaCatDeportes.AllowUserToResizeColumns = false;
            this.tablaCatDeportes.AllowUserToResizeRows = false;
            this.tablaCatDeportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaCatDeportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCatDeportes.ColumnHeadersVisible = false;
            this.tablaCatDeportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categorias});
            this.tablaCatDeportes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaCatDeportes.Location = new System.Drawing.Point(708, 82);
            this.tablaCatDeportes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tablaCatDeportes.Name = "tablaCatDeportes";
            this.tablaCatDeportes.RowHeadersVisible = false;
            this.tablaCatDeportes.RowHeadersWidth = 51;
            this.tablaCatDeportes.RowTemplate.Height = 25;
            this.tablaCatDeportes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaCatDeportes.Size = new System.Drawing.Size(151, 230);
            this.tablaCatDeportes.TabIndex = 45;
            this.tablaCatDeportes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCatDeportes_CellContentClick);
            // 
            // Categorias
            // 
            this.Categorias.HeaderText = "Categorias";
            this.Categorias.MinimumWidth = 6;
            this.Categorias.Name = "Categorias";
            // 
            // btnCrearDepor
            // 
            this.btnCrearDepor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnCrearDepor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearDepor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearDepor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrearDepor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrearDepor.FillColor = System.Drawing.Color.Transparent;
            this.btnCrearDepor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCrearDepor.ForeColor = System.Drawing.Color.Black;
            this.btnCrearDepor.Location = new System.Drawing.Point(708, 18);
            this.btnCrearDepor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCrearDepor.Name = "btnCrearDepor";
            this.btnCrearDepor.Size = new System.Drawing.Size(151, 29);
            this.btnCrearDepor.TabIndex = 48;
            this.btnCrearDepor.Text = "Agregar categoria";
            this.btnCrearDepor.Click += new System.EventHandler(this.btnCrearDepor_Click);
            // 
            // txtAgregarCatDep
            // 
            this.txtAgregarCatDep.Location = new System.Drawing.Point(708, 53);
            this.txtAgregarCatDep.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAgregarCatDep.Name = "txtAgregarCatDep";
            this.txtAgregarCatDep.Size = new System.Drawing.Size(151, 20);
            this.txtAgregarCatDep.TabIndex = 47;
            // 
            // btnEliminarDeporte
            // 
            this.btnEliminarDeporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnEliminarDeporte.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarDeporte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarDeporte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarDeporte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarDeporte.FillColor = System.Drawing.Color.Transparent;
            this.btnEliminarDeporte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminarDeporte.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarDeporte.Location = new System.Drawing.Point(210, 320);
            this.btnEliminarDeporte.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEliminarDeporte.Name = "btnEliminarDeporte";
            this.btnEliminarDeporte.Size = new System.Drawing.Size(151, 29);
            this.btnEliminarDeporte.TabIndex = 49;
            this.btnEliminarDeporte.Text = "Eliminar deporte";
            this.btnEliminarDeporte.Click += new System.EventHandler(this.btnEliminarDeporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(502, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Deporte";
            // 
            // btnEliminarCatDep
            // 
            this.btnEliminarCatDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnEliminarCatDep.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarCatDep.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarCatDep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarCatDep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarCatDep.FillColor = System.Drawing.Color.Transparent;
            this.btnEliminarCatDep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminarCatDep.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarCatDep.Location = new System.Drawing.Point(708, 320);
            this.btnEliminarCatDep.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEliminarCatDep.Name = "btnEliminarCatDep";
            this.btnEliminarCatDep.Size = new System.Drawing.Size(151, 29);
            this.btnEliminarCatDep.TabIndex = 50;
            this.btnEliminarCatDep.Text = "Eliminar categoria";
            this.btnEliminarCatDep.Click += new System.EventHandler(this.btnEliminarCatDep_Click);
            // 
            // txtDeporteAsociar
            // 
            this.txtDeporteAsociar.Location = new System.Drawing.Point(463, 121);
            this.txtDeporteAsociar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDeporteAsociar.Name = "txtDeporteAsociar";
            this.txtDeporteAsociar.ReadOnly = true;
            this.txtDeporteAsociar.Size = new System.Drawing.Size(151, 20);
            this.txtDeporteAsociar.TabIndex = 51;
            // 
            // txtCategoriaAsociar
            // 
            this.txtCategoriaAsociar.Location = new System.Drawing.Point(463, 226);
            this.txtCategoriaAsociar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCategoriaAsociar.Name = "txtCategoriaAsociar";
            this.txtCategoriaAsociar.ReadOnly = true;
            this.txtCategoriaAsociar.Size = new System.Drawing.Size(151, 20);
            this.txtCategoriaAsociar.TabIndex = 52;
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
            this.btnAsociar.Location = new System.Drawing.Point(463, 169);
            this.btnAsociar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAsociar.Name = "btnAsociar";
            this.btnAsociar.Size = new System.Drawing.Size(151, 29);
            this.btnAsociar.TabIndex = 53;
            this.btnAsociar.Text = "Asociar disciplina";
            this.btnAsociar.Click += new System.EventHandler(this.btnAsociar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(495, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Categoria";
            // 
            // Gestion_Deportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAsociar);
            this.Controls.Add(this.txtCategoriaAsociar);
            this.Controls.Add(this.txtDeporteAsociar);
            this.Controls.Add(this.btnEliminarCatDep);
            this.Controls.Add(this.btnEliminarDeporte);
            this.Controls.Add(this.btnCrearDepor);
            this.Controls.Add(this.txtAgregarCatDep);
            this.Controls.Add(this.tablaDeportes);
            this.Controls.Add(this.tablaCatDeportes);
            this.Controls.Add(this.btnAgregarDeporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDeporte);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Gestion_Deportes";
            this.Size = new System.Drawing.Size(927, 366);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCatDeportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAgregarDeporte;
        private TextBox txtDeporte;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarFiltros;
        private DataGridView tablaDeportes;
        private DataGridViewTextBoxColumn deportes;
        private DataGridView tablaCatDeportes;
        private DataGridViewTextBoxColumn Categorias;
        private Guna.UI2.WinForms.Guna2Button btnCrearDepor;
        private TextBox txtAgregarCatDep;
        private Guna.UI2.WinForms.Guna2Button btnEliminarDeporte;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnEliminarCatDep;
        private TextBox txtDeporteAsociar;
        private TextBox txtCategoriaAsociar;
        private Guna.UI2.WinForms.Guna2Button btnAsociar;
        private Label label4;
    }
}
