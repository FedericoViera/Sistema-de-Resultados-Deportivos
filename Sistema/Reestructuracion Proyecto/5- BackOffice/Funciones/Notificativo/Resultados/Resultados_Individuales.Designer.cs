namespace Reestructuracion_Proyecto._5__BackOffice.Funciones.Notificativo.Resultados
{
    partial class Resultados_Individuales
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
            this.dataResultados = new System.Windows.Forms.DataGridView();
            this.listDeportistas = new System.Windows.Forms.ListBox();
            this.btnAccion2 = new Guna.UI2.WinForms.Guna2Button();
            this.cmoDep = new System.Windows.Forms.ComboBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.btnIngresarResultado = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarResultado = new Guna.UI2.WinForms.Guna2Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnEliminarDetalle = new Guna.UI2.WinForms.Guna2Button();
            this.lblDeportista = new System.Windows.Forms.Label();
            this.listDetalles = new System.Windows.Forms.ListBox();
            this.listTiempos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataResultados
            // 
            this.dataResultados.AllowUserToAddRows = false;
            this.dataResultados.AllowUserToDeleteRows = false;
            this.dataResultados.AllowUserToResizeColumns = false;
            this.dataResultados.AllowUserToResizeRows = false;
            this.dataResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataResultados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataResultados.BackgroundColor = System.Drawing.Color.White;
            this.dataResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataResultados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResultados.ColumnHeadersVisible = false;
            this.dataResultados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataResultados.GridColor = System.Drawing.Color.White;
            this.dataResultados.Location = new System.Drawing.Point(188, 0);
            this.dataResultados.Name = "dataResultados";
            this.dataResultados.RowHeadersVisible = false;
            this.dataResultados.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataResultados.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataResultados.RowTemplate.Height = 25;
            this.dataResultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataResultados.ShowCellToolTips = false;
            this.dataResultados.Size = new System.Drawing.Size(216, 249);
            this.dataResultados.TabIndex = 39;
            // 
            // listDeportistas
            // 
            this.listDeportistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDeportistas.FormattingEnabled = true;
            this.listDeportistas.Location = new System.Drawing.Point(4, -1);
            this.listDeportistas.Name = "listDeportistas";
            this.listDeportistas.Size = new System.Drawing.Size(141, 251);
            this.listDeportistas.TabIndex = 50;
            // 
            // btnAccion2
            // 
            this.btnAccion2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnAccion2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccion2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccion2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccion2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccion2.FillColor = System.Drawing.Color.Transparent;
            this.btnAccion2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAccion2.ForeColor = System.Drawing.Color.Black;
            this.btnAccion2.Location = new System.Drawing.Point(4, 285);
            this.btnAccion2.Name = "btnAccion2";
            this.btnAccion2.Size = new System.Drawing.Size(141, 25);
            this.btnAccion2.TabIndex = 51;
            this.btnAccion2.Text = "Agregar";
            this.btnAccion2.Click += new System.EventHandler(this.btnAccion2_Click);
            // 
            // cmoDep
            // 
            this.cmoDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmoDep.FormattingEnabled = true;
            this.cmoDep.Location = new System.Drawing.Point(4, 258);
            this.cmoDep.Name = "cmoDep";
            this.cmoDep.Size = new System.Drawing.Size(141, 21);
            this.cmoDep.TabIndex = 52;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(411, 258);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(152, 20);
            this.txtDetalle.TabIndex = 55;
            // 
            // btnIngresarResultado
            // 
            this.btnIngresarResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnIngresarResultado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIngresarResultado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIngresarResultado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIngresarResultado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIngresarResultado.FillColor = System.Drawing.Color.Transparent;
            this.btnIngresarResultado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnIngresarResultado.ForeColor = System.Drawing.Color.Black;
            this.btnIngresarResultado.Location = new System.Drawing.Point(255, 285);
            this.btnIngresarResultado.Name = "btnIngresarResultado";
            this.btnIngresarResultado.Size = new System.Drawing.Size(149, 25);
            this.btnIngresarResultado.TabIndex = 56;
            this.btnIngresarResultado.Text = "Ingresar resultado";
            this.btnIngresarResultado.Click += new System.EventHandler(this.btnIngresarResultado_Click);
            // 
            // btnEliminarResultado
            // 
            this.btnEliminarResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnEliminarResultado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarResultado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarResultado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarResultado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarResultado.FillColor = System.Drawing.Color.Transparent;
            this.btnEliminarResultado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminarResultado.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarResultado.Location = new System.Drawing.Point(152, 285);
            this.btnEliminarResultado.Name = "btnEliminarResultado";
            this.btnEliminarResultado.Size = new System.Drawing.Size(97, 25);
            this.btnEliminarResultado.TabIndex = 57;
            this.btnEliminarResultado.Text = "Eliminar";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(255, 258);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(149, 20);
            this.txtResultado.TabIndex = 59;
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnEliminarDetalle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarDetalle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarDetalle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarDetalle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarDetalle.FillColor = System.Drawing.Color.Transparent;
            this.btnEliminarDetalle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminarDetalle.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarDetalle.Location = new System.Drawing.Point(411, 285);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(152, 25);
            this.btnEliminarDetalle.TabIndex = 61;
            this.btnEliminarDetalle.Text = "Agregar detalle";
            // 
            // lblDeportista
            // 
            this.lblDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeportista.Location = new System.Drawing.Point(151, 256);
            this.lblDeportista.Name = "lblDeportista";
            this.lblDeportista.Size = new System.Drawing.Size(98, 20);
            this.lblDeportista.TabIndex = 62;
            this.lblDeportista.Text = "luis suarez";
            this.lblDeportista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listDetalles
            // 
            this.listDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDetalles.FormattingEnabled = true;
            this.listDetalles.Location = new System.Drawing.Point(412, -2);
            this.listDetalles.Name = "listDetalles";
            this.listDetalles.Size = new System.Drawing.Size(151, 251);
            this.listDetalles.TabIndex = 63;
            // 
            // listTiempos
            // 
            this.listTiempos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTiempos.FormattingEnabled = true;
            this.listTiempos.Location = new System.Drawing.Point(151, -2);
            this.listTiempos.Name = "listTiempos";
            this.listTiempos.Size = new System.Drawing.Size(35, 251);
            this.listTiempos.TabIndex = 64;
            this.listTiempos.SelectedIndexChanged += new System.EventHandler(this.listTiempos_SelectedIndexChanged);
            // 
            // Resultados_Individuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.listTiempos);
            this.Controls.Add(this.listDetalles);
            this.Controls.Add(this.lblDeportista);
            this.Controls.Add(this.btnEliminarDetalle);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnEliminarResultado);
            this.Controls.Add(this.btnIngresarResultado);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.cmoDep);
            this.Controls.Add(this.btnAccion2);
            this.Controls.Add(this.listDeportistas);
            this.Controls.Add(this.dataResultados);
            this.Name = "Resultados_Individuales";
            this.Size = new System.Drawing.Size(566, 313);
            ((System.ComponentModel.ISupportInitialize)(this.dataResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataResultados;
        private System.Windows.Forms.ListBox listDeportistas;
        private Guna.UI2.WinForms.Guna2Button btnAccion2;
        private System.Windows.Forms.ComboBox cmoDep;
        private System.Windows.Forms.TextBox txtDetalle;
        private Guna.UI2.WinForms.Guna2Button btnIngresarResultado;
        private Guna.UI2.WinForms.Guna2Button btnEliminarResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private Guna.UI2.WinForms.Guna2Button btnEliminarDetalle;
        private System.Windows.Forms.Label lblDeportista;
        private System.Windows.Forms.ListBox listDetalles;
        private System.Windows.Forms.ListBox listTiempos;
    }
}
