using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Funciones.Publicitario.Publicidad
{
    partial class Gestion_Banners
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
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridSinAsociar = new System.Windows.Forms.DataGridView();
            this.dataGridBanners = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarBanner = new Guna.UI2.WinForms.Guna2Button();
            this.btnCrearBanner = new Guna.UI2.WinForms.Guna2Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmoPosicion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridAsociadas = new System.Windows.Forms.DataGridView();
            this.btnIngresar = new Guna.UI2.WinForms.Guna2Button();
            this.btnSacar = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSinAsociar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBanners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAsociadas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(100)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 366);
            this.panel2.TabIndex = 62;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditar.FillColor = System.Drawing.Color.Transparent;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(-1, 74);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(145, 25);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.Text = "Editar banner";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(-1, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(145, 25);
            this.btnLimpiar.TabIndex = 56;
            this.btnLimpiar.Text = "Limpiar filtros";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dataGridSinAsociar
            // 
            this.dataGridSinAsociar.AllowUserToAddRows = false;
            this.dataGridSinAsociar.AllowUserToDeleteRows = false;
            this.dataGridSinAsociar.AllowUserToResizeColumns = false;
            this.dataGridSinAsociar.AllowUserToResizeRows = false;
            this.dataGridSinAsociar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSinAsociar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSinAsociar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridSinAsociar.Location = new System.Drawing.Point(727, 86);
            this.dataGridSinAsociar.Name = "dataGridSinAsociar";
            this.dataGridSinAsociar.RowHeadersVisible = false;
            this.dataGridSinAsociar.RowHeadersWidth = 51;
            this.dataGridSinAsociar.RowTemplate.Height = 25;
            this.dataGridSinAsociar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridSinAsociar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSinAsociar.Size = new System.Drawing.Size(170, 230);
            this.dataGridSinAsociar.TabIndex = 78;
            this.dataGridSinAsociar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNoAsociadas_CelltClick);
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
            this.dataGridBanners.Location = new System.Drawing.Point(171, 85);
            this.dataGridBanners.MultiSelect = false;
            this.dataGridBanners.Name = "dataGridBanners";
            this.dataGridBanners.RowHeadersVisible = false;
            this.dataGridBanners.RowHeadersWidth = 51;
            this.dataGridBanners.RowTemplate.Height = 25;
            this.dataGridBanners.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridBanners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBanners.Size = new System.Drawing.Size(234, 230);
            this.dataGridBanners.TabIndex = 79;
            this.dataGridBanners.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBanners_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(770, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 82;
            this.label2.Text = "Sin asociar";
            // 
            // btnEliminarBanner
            // 
            this.btnEliminarBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnEliminarBanner.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarBanner.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarBanner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarBanner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarBanner.FillColor = System.Drawing.Color.Transparent;
            this.btnEliminarBanner.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminarBanner.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarBanner.Location = new System.Drawing.Point(212, 321);
            this.btnEliminarBanner.Name = "btnEliminarBanner";
            this.btnEliminarBanner.Size = new System.Drawing.Size(151, 29);
            this.btnEliminarBanner.TabIndex = 86;
            this.btnEliminarBanner.Text = "Eliminar banner";
            this.btnEliminarBanner.Click += new System.EventHandler(this.btnEliminarBanner_Click);
            // 
            // btnCrearBanner
            // 
            this.btnCrearBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnCrearBanner.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearBanner.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearBanner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrearBanner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrearBanner.FillColor = System.Drawing.Color.Transparent;
            this.btnCrearBanner.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCrearBanner.ForeColor = System.Drawing.Color.Black;
            this.btnCrearBanner.Location = new System.Drawing.Point(211, 27);
            this.btnCrearBanner.Name = "btnCrearBanner";
            this.btnCrearBanner.Size = new System.Drawing.Size(151, 29);
            this.btnCrearBanner.TabIndex = 85;
            this.btnCrearBanner.Text = "Agregar banner";
            this.btnCrearBanner.Click += new System.EventHandler(this.btnCrearBanner_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(176, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(124, 20);
            this.txtNombre.TabIndex = 84;
            // 
            // cmoPosicion
            // 
            this.cmoPosicion.FormattingEnabled = true;
            this.cmoPosicion.Location = new System.Drawing.Point(301, 60);
            this.cmoPosicion.Name = "cmoPosicion";
            this.cmoPosicion.Size = new System.Drawing.Size(91, 21);
            this.cmoPosicion.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(457, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 89;
            this.label1.Text = "Asociadas al banner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(535, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 90;
            this.label3.Text = "Imagenes ";
            // 
            // dataGridAsociadas
            // 
            this.dataGridAsociadas.AllowUserToAddRows = false;
            this.dataGridAsociadas.AllowUserToDeleteRows = false;
            this.dataGridAsociadas.AllowUserToResizeColumns = false;
            this.dataGridAsociadas.AllowUserToResizeRows = false;
            this.dataGridAsociadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAsociadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAsociadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridAsociadas.Location = new System.Drawing.Point(452, 85);
            this.dataGridAsociadas.Name = "dataGridAsociadas";
            this.dataGridAsociadas.RowHeadersVisible = false;
            this.dataGridAsociadas.RowHeadersWidth = 51;
            this.dataGridAsociadas.RowTemplate.Height = 25;
            this.dataGridAsociadas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridAsociadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAsociadas.Size = new System.Drawing.Size(170, 230);
            this.dataGridAsociadas.TabIndex = 91;
            this.dataGridAsociadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAsociadas_CelltClick);
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
            this.btnIngresar.Location = new System.Drawing.Point(634, 125);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(82, 29);
            this.btnIngresar.TabIndex = 80;
            this.btnIngresar.Text = "<-----";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
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
            this.btnSacar.Location = new System.Drawing.Point(634, 244);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(82, 29);
            this.btnSacar.TabIndex = 83;
            this.btnSacar.Text = "----->";
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // Gestion_Banners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.dataGridAsociadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmoPosicion);
            this.Controls.Add(this.btnEliminarBanner);
            this.Controls.Add(this.btnCrearBanner);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.dataGridBanners);
            this.Controls.Add(this.dataGridSinAsociar);
            this.Controls.Add(this.panel2);
            this.Name = "Gestion_Banners";
            this.Size = new System.Drawing.Size(927, 366);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSinAsociar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBanners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAsociadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private DataGridView dataGridSinAsociar;
        private DataGridView dataGridBanners;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btnEliminarBanner;
        private Guna.UI2.WinForms.Guna2Button btnCrearBanner;
        private TextBox txtNombre;
        private ComboBox cmoPosicion;
        private Label label1;
        private Label label3;
        private DataGridView dataGridAsociadas;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnIngresar;
        private Guna.UI2.WinForms.Guna2Button btnSacar;
    }
}
