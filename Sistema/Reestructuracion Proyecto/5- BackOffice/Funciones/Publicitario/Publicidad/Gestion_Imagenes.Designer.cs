using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Funciones.Publicitario.Publicidad
{
    partial class Gestion_Imagenes
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
            this.btnSubirImagen = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscarImagen = new Guna.UI2.WinForms.Guna2Button();
            this.pteImagen = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.panel_Informacion = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmoEmpresas = new System.Windows.Forms.ComboBox();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridImagenes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pteImagen)).BeginInit();
            this.panel_Informacion.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubirImagen
            // 
            this.btnSubirImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnSubirImagen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubirImagen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubirImagen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubirImagen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubirImagen.FillColor = System.Drawing.Color.Transparent;
            this.btnSubirImagen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSubirImagen.ForeColor = System.Drawing.Color.Black;
            this.btnSubirImagen.Location = new System.Drawing.Point(361, 32);
            this.btnSubirImagen.Name = "btnSubirImagen";
            this.btnSubirImagen.Size = new System.Drawing.Size(139, 29);
            this.btnSubirImagen.TabIndex = 54;
            this.btnSubirImagen.Text = "Subir imagen";
            this.btnSubirImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // btnBuscarImagen
            // 
            this.btnBuscarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnBuscarImagen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarImagen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarImagen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarImagen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarImagen.FillColor = System.Drawing.Color.Transparent;
            this.btnBuscarImagen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBuscarImagen.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarImagen.Location = new System.Drawing.Point(195, 26);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.Size = new System.Drawing.Size(302, 29);
            this.btnBuscarImagen.TabIndex = 53;
            this.btnBuscarImagen.Text = "Buscar imagen para subir al sistema";
            this.btnBuscarImagen.Click += new System.EventHandler(this.btnBuscarImage_Click);
            // 
            // pteImagen
            // 
            this.pteImagen.Location = new System.Drawing.Point(202, 175);
            this.pteImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pteImagen.Name = "pteImagen";
            this.pteImagen.Size = new System.Drawing.Size(300, 185);
            this.pteImagen.TabIndex = 55;
            this.pteImagen.TabStop = false;
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
            this.btnLimpiar.Location = new System.Drawing.Point(-2, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(145, 25);
            this.btnLimpiar.TabIndex = 56;
            this.btnLimpiar.Text = "Limpiar filtros";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panel_Informacion
            // 
            this.panel_Informacion.Controls.Add(this.txtNombre);
            this.panel_Informacion.Controls.Add(this.label2);
            this.panel_Informacion.Controls.Add(this.cmoEmpresas);
            this.panel_Informacion.Controls.Add(this.txtNombreArchivo);
            this.panel_Informacion.Controls.Add(this.btnSubirImagen);
            this.panel_Informacion.Controls.Add(this.label3);
            this.panel_Informacion.Controls.Add(this.label4);
            this.panel_Informacion.Enabled = false;
            this.panel_Informacion.Location = new System.Drawing.Point(171, 64);
            this.panel_Informacion.Name = "panel_Informacion";
            this.panel_Informacion.Size = new System.Drawing.Size(513, 101);
            this.panel_Informacion.TabIndex = 58;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(206, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 20);
            this.txtNombre.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre descriptivo:";
            // 
            // cmoEmpresas
            // 
            this.cmoEmpresas.FormattingEnabled = true;
            this.cmoEmpresas.Location = new System.Drawing.Point(206, 61);
            this.cmoEmpresas.Name = "cmoEmpresas";
            this.cmoEmpresas.Size = new System.Drawing.Size(132, 21);
            this.cmoEmpresas.TabIndex = 19;
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(206, 36);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(132, 20);
            this.txtNombreArchivo.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre para el archivo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Empresa:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(100)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 366);
            this.panel2.TabIndex = 59;
            // 
            // dataGridImagenes
            // 
            this.dataGridImagenes.AllowUserToAddRows = false;
            this.dataGridImagenes.AllowUserToDeleteRows = false;
            this.dataGridImagenes.AllowUserToResizeColumns = false;
            this.dataGridImagenes.AllowUserToResizeRows = false;
            this.dataGridImagenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridImagenes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridImagenes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridImagenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridImagenes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridImagenes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridImagenes.GridColor = System.Drawing.Color.White;
            this.dataGridImagenes.Location = new System.Drawing.Point(705, 19);
            this.dataGridImagenes.Name = "dataGridImagenes";
            this.dataGridImagenes.RowHeadersVisible = false;
            this.dataGridImagenes.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridImagenes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridImagenes.RowTemplate.Height = 25;
            this.dataGridImagenes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridImagenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridImagenes.ShowCellToolTips = false;
            this.dataGridImagenes.Size = new System.Drawing.Size(210, 335);
            this.dataGridImagenes.TabIndex = 60;
            this.dataGridImagenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridImagenes_CellContentClick);
            // 
            // Gestion_Imagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.dataGridImagenes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_Informacion);
            this.Controls.Add(this.pteImagen);
            this.Controls.Add(this.btnBuscarImagen);
            this.Name = "Gestion_Imagenes";
            this.Size = new System.Drawing.Size(927, 366);
            ((System.ComponentModel.ISupportInitialize)(this.pteImagen)).EndInit();
            this.panel_Informacion.ResumeLayout(false);
            this.panel_Informacion.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridImagenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSubirImagen;
        private Guna.UI2.WinForms.Guna2Button btnBuscarImagen;
        private PictureBox pteImagen;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private Panel panel_Informacion;
        private TextBox txtNombre;
        private Label label2;
        private ComboBox cmoEmpresas;
        private TextBox txtNombreArchivo;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private DataGridView dataGridImagenes;
    }
}
