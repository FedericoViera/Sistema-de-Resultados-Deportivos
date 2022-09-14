using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Funciones.Notificativo.Resultados.Gestion_Eventos_Resultado
{
    partial class Gestion_Eventos_Resultados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dteCulminar = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmoMostrarEventos = new System.Windows.Forms.ComboBox();
            this.btnCulminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnReabrir = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpiarFiltros = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.dataEventos = new System.Windows.Forms.DataGridView();
            this.dataPartidos = new System.Windows.Forms.DataGridView();
            this.btnCrearPartido = new Guna.UI2.WinForms.Guna2Button();
            this.cmoEq1 = new System.Windows.Forms.ComboBox();
            this.cmoEq2 = new System.Windows.Forms.ComboBox();
            this.btnEliminarPartido = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditarPartido = new Guna.UI2.WinForms.Guna2Button();
            this.dtimePartido = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPartidos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(100)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.dteCulminar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmoMostrarEventos);
            this.panel1.Controls.Add(this.btnCulminar);
            this.panel1.Controls.Add(this.btnReabrir);
            this.panel1.Controls.Add(this.btnLimpiarFiltros);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtBuscarUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 366);
            this.panel1.TabIndex = 38;
            // 
            // dteCulminar
            // 
            this.dteCulminar.CustomFormat = "";
            this.dteCulminar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteCulminar.Location = new System.Drawing.Point(1, 303);
            this.dteCulminar.Name = "dteCulminar";
            this.dteCulminar.Size = new System.Drawing.Size(139, 20);
            this.dteCulminar.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "Mostrar eventos";
            // 
            // cmoMostrarEventos
            // 
            this.cmoMostrarEventos.FormattingEnabled = true;
            this.cmoMostrarEventos.Items.AddRange(new object[] {
            "En curso",
            "Culminados"});
            this.cmoMostrarEventos.Location = new System.Drawing.Point(0, 105);
            this.cmoMostrarEventos.Name = "cmoMostrarEventos";
            this.cmoMostrarEventos.Size = new System.Drawing.Size(140, 21);
            this.cmoMostrarEventos.TabIndex = 48;
            this.cmoMostrarEventos.Text = "En curso";
            this.cmoMostrarEventos.SelectedIndexChanged += new System.EventHandler(this.cmoMostrarEventos_SelectedIndexChanged);
            // 
            // btnCulminar
            // 
            this.btnCulminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnCulminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCulminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCulminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCulminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCulminar.FillColor = System.Drawing.Color.Transparent;
            this.btnCulminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCulminar.ForeColor = System.Drawing.Color.Black;
            this.btnCulminar.Location = new System.Drawing.Point(0, 272);
            this.btnCulminar.Name = "btnCulminar";
            this.btnCulminar.Size = new System.Drawing.Size(140, 25);
            this.btnCulminar.TabIndex = 45;
            this.btnCulminar.Text = "Culminar evento";
            this.btnCulminar.Click += new System.EventHandler(this.btnCulminar_Click);
            // 
            // btnReabrir
            // 
            this.btnReabrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnReabrir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReabrir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReabrir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReabrir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReabrir.FillColor = System.Drawing.Color.Transparent;
            this.btnReabrir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReabrir.ForeColor = System.Drawing.Color.Black;
            this.btnReabrir.Location = new System.Drawing.Point(0, 233);
            this.btnReabrir.Name = "btnReabrir";
            this.btnReabrir.Size = new System.Drawing.Size(140, 25);
            this.btnReabrir.TabIndex = 34;
            this.btnReabrir.Text = "Reabrir evento";
            this.btnReabrir.Click += new System.EventHandler(this.btnReabrir_Click);
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
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscar.FillColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(1, 137);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(139, 25);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar evento";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(1, 168);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(139, 20);
            this.txtBuscarUsuario.TabIndex = 11;
            // 
            // dataEventos
            // 
            this.dataEventos.AllowUserToAddRows = false;
            this.dataEventos.AllowUserToDeleteRows = false;
            this.dataEventos.AllowUserToResizeColumns = false;
            this.dataEventos.AllowUserToResizeRows = false;
            this.dataEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataEventos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataEventos.BackgroundColor = System.Drawing.Color.White;
            this.dataEventos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataEventos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEventos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataEventos.GridColor = System.Drawing.Color.White;
            this.dataEventos.Location = new System.Drawing.Point(140, 0);
            this.dataEventos.Name = "dataEventos";
            this.dataEventos.RowHeadersVisible = false;
            this.dataEventos.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataEventos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataEventos.RowTemplate.Height = 25;
            this.dataEventos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEventos.ShowCellToolTips = false;
            this.dataEventos.Size = new System.Drawing.Size(495, 366);
            this.dataEventos.TabIndex = 37;
            this.dataEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEventos_CellClick);
            // 
            // dataPartidos
            // 
            this.dataPartidos.AllowUserToAddRows = false;
            this.dataPartidos.AllowUserToDeleteRows = false;
            this.dataPartidos.AllowUserToResizeColumns = false;
            this.dataPartidos.AllowUserToResizeRows = false;
            this.dataPartidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPartidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataPartidos.BackgroundColor = System.Drawing.Color.White;
            this.dataPartidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPartidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPartidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataPartidos.GridColor = System.Drawing.Color.White;
            this.dataPartidos.Location = new System.Drawing.Point(638, 0);
            this.dataPartidos.Name = "dataPartidos";
            this.dataPartidos.RowHeadersVisible = false;
            this.dataPartidos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataPartidos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataPartidos.RowTemplate.Height = 25;
            this.dataPartidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataPartidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPartidos.ShowCellToolTips = false;
            this.dataPartidos.Size = new System.Drawing.Size(289, 283);
            this.dataPartidos.TabIndex = 39;
            this.dataPartidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPartidos_CellClick);
            // 
            // btnCrearPartido
            // 
            this.btnCrearPartido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnCrearPartido.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearPartido.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearPartido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrearPartido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrearPartido.FillColor = System.Drawing.Color.Transparent;
            this.btnCrearPartido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCrearPartido.ForeColor = System.Drawing.Color.Black;
            this.btnCrearPartido.Location = new System.Drawing.Point(641, 310);
            this.btnCrearPartido.Name = "btnCrearPartido";
            this.btnCrearPartido.Size = new System.Drawing.Size(140, 25);
            this.btnCrearPartido.TabIndex = 51;
            this.btnCrearPartido.Text = "Crear encuentro";
            this.btnCrearPartido.Click += new System.EventHandler(this.btnCrearPartido_Click);
            // 
            // cmoEq1
            // 
            this.cmoEq1.FormattingEnabled = true;
            this.cmoEq1.Location = new System.Drawing.Point(639, 287);
            this.cmoEq1.Name = "cmoEq1";
            this.cmoEq1.Size = new System.Drawing.Size(144, 21);
            this.cmoEq1.TabIndex = 51;
            // 
            // cmoEq2
            // 
            this.cmoEq2.FormattingEnabled = true;
            this.cmoEq2.Location = new System.Drawing.Point(785, 287);
            this.cmoEq2.Name = "cmoEq2";
            this.cmoEq2.Size = new System.Drawing.Size(140, 21);
            this.cmoEq2.TabIndex = 52;
            // 
            // btnEliminarPartido
            // 
            this.btnEliminarPartido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnEliminarPartido.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarPartido.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarPartido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarPartido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarPartido.FillColor = System.Drawing.Color.Transparent;
            this.btnEliminarPartido.Font = new System.Drawing.Font("Century Gothic", 9.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminarPartido.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarPartido.Location = new System.Drawing.Point(785, 338);
            this.btnEliminarPartido.Name = "btnEliminarPartido";
            this.btnEliminarPartido.Size = new System.Drawing.Size(142, 25);
            this.btnEliminarPartido.TabIndex = 53;
            this.btnEliminarPartido.Text = "Borrar encuentro";
            this.btnEliminarPartido.Click += new System.EventHandler(this.btnEliminarPartido_Click);
            // 
            // btnEditarPartido
            // 
            this.btnEditarPartido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnEditarPartido.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarPartido.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditarPartido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditarPartido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditarPartido.FillColor = System.Drawing.Color.Transparent;
            this.btnEditarPartido.Font = new System.Drawing.Font("Century Gothic", 9.2F, System.Drawing.FontStyle.Bold);
            this.btnEditarPartido.ForeColor = System.Drawing.Color.Black;
            this.btnEditarPartido.Location = new System.Drawing.Point(641, 338);
            this.btnEditarPartido.Name = "btnEditarPartido";
            this.btnEditarPartido.Size = new System.Drawing.Size(142, 25);
            this.btnEditarPartido.TabIndex = 54;
            this.btnEditarPartido.Text = "Editar encuentro";
            // 
            // dtimePartido
            // 
            this.dtimePartido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimePartido.Location = new System.Drawing.Point(785, 312);
            this.dtimePartido.Name = "dtimePartido";
            this.dtimePartido.Size = new System.Drawing.Size(139, 20);
            this.dtimePartido.TabIndex = 55;
            // 
            // Gestion_Eventos_Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.dtimePartido);
            this.Controls.Add(this.btnEditarPartido);
            this.Controls.Add(this.btnEliminarPartido);
            this.Controls.Add(this.cmoEq2);
            this.Controls.Add(this.cmoEq1);
            this.Controls.Add(this.btnCrearPartido);
            this.Controls.Add(this.dataPartidos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataEventos);
            this.Name = "Gestion_Eventos_Resultados";
            this.Size = new System.Drawing.Size(927, 366);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPartidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnReabrir;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarFiltros;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private TextBox txtBuscarUsuario;
        private DataGridView dataEventos;
        private Guna.UI2.WinForms.Guna2Button btnCulminar;
        private Label label1;
        private ComboBox cmoMostrarEventos;
        private DateTimePicker dteCulminar;
        private DataGridView dataPartidos;
        private Guna.UI2.WinForms.Guna2Button btnCrearPartido;
        private ComboBox cmoEq1;
        private ComboBox cmoEq2;
        private Guna.UI2.WinForms.Guna2Button btnEliminarPartido;
        private Guna.UI2.WinForms.Guna2Button btnEditarPartido;
        private DateTimePicker dtimePartido;
    }
}
