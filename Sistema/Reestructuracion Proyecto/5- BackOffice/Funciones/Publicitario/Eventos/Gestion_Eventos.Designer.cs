using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Funciones.Publicitario.Eventos
{
    partial class Gestion_Eventos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.cmoModalidad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtimeInicio = new System.Windows.Forms.DateTimePicker();
            this.cmoCampeonato = new System.Windows.Forms.ComboBox();
            this.cmoDeportes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmoPais = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearEvento = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridEventos = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(100)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 366);
            this.panel2.TabIndex = 60;
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
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(151, 29);
            this.btnLimpiar.TabIndex = 56;
            this.btnLimpiar.Text = "Limpiar filtros";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmoModalidad
            // 
            this.cmoModalidad.FormattingEnabled = true;
            this.cmoModalidad.Location = new System.Drawing.Point(267, 82);
            this.cmoModalidad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmoModalidad.Name = "cmoModalidad";
            this.cmoModalidad.Size = new System.Drawing.Size(119, 21);
            this.cmoModalidad.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(174, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 74;
            this.label5.Text = "Modalidad";
            // 
            // dtimeInicio
            // 
            this.dtimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeInicio.Location = new System.Drawing.Point(267, 229);
            this.dtimeInicio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtimeInicio.Name = "dtimeInicio";
            this.dtimeInicio.Size = new System.Drawing.Size(119, 20);
            this.dtimeInicio.TabIndex = 73;
            // 
            // cmoCampeonato
            // 
            this.cmoCampeonato.FormattingEnabled = true;
            this.cmoCampeonato.Location = new System.Drawing.Point(267, 152);
            this.cmoCampeonato.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmoCampeonato.Name = "cmoCampeonato";
            this.cmoCampeonato.Size = new System.Drawing.Size(119, 21);
            this.cmoCampeonato.TabIndex = 72;
            // 
            // cmoDeportes
            // 
            this.cmoDeportes.FormattingEnabled = true;
            this.cmoDeportes.Location = new System.Drawing.Point(267, 116);
            this.cmoDeportes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmoDeportes.Name = "cmoDeportes";
            this.cmoDeportes.Size = new System.Drawing.Size(119, 21);
            this.cmoDeportes.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(182, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 70;
            this.label7.Text = "Disciplina";
            // 
            // cmoPais
            // 
            this.cmoPais.FormattingEnabled = true;
            this.cmoPais.Location = new System.Drawing.Point(267, 188);
            this.cmoPais.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmoPais.Name = "cmoPais";
            this.cmoPais.Size = new System.Drawing.Size(119, 21);
            this.cmoPais.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(162, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 68;
            this.label6.Text = "Localizacion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(267, 51);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(119, 20);
            this.txtNombre.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(165, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 65;
            this.label4.Text = "Fecha inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(158, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 64;
            this.label3.Text = "Campeonato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(192, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 63;
            this.label2.Text = "Nombre ";
            // 
            // btnCrearEvento
            // 
            this.btnCrearEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnCrearEvento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearEvento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearEvento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrearEvento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrearEvento.FillColor = System.Drawing.Color.Transparent;
            this.btnCrearEvento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCrearEvento.ForeColor = System.Drawing.Color.Black;
            this.btnCrearEvento.Location = new System.Drawing.Point(199, 299);
            this.btnCrearEvento.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCrearEvento.Name = "btnCrearEvento";
            this.btnCrearEvento.Size = new System.Drawing.Size(151, 29);
            this.btnCrearEvento.TabIndex = 57;
            this.btnCrearEvento.Text = "Crear evento";
            this.btnCrearEvento.Click += new System.EventHandler(this.btnCrearEvento_Click);
            // 
            // dataGridEventos
            // 
            this.dataGridEventos.AllowUserToAddRows = false;
            this.dataGridEventos.AllowUserToDeleteRows = false;
            this.dataGridEventos.AllowUserToResizeColumns = false;
            this.dataGridEventos.AllowUserToResizeRows = false;
            this.dataGridEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEventos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridEventos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridEventos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEventos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEventos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridEventos.GridColor = System.Drawing.Color.White;
            this.dataGridEventos.Location = new System.Drawing.Point(411, 14);
            this.dataGridEventos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridEventos.Name = "dataGridEventos";
            this.dataGridEventos.RowHeadersVisible = false;
            this.dataGridEventos.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridEventos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEventos.RowTemplate.Height = 25;
            this.dataGridEventos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEventos.ShowCellToolTips = false;
            this.dataGridEventos.Size = new System.Drawing.Size(514, 349);
            this.dataGridEventos.TabIndex = 76;
            this.dataGridEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEventos_Click);
            // 
            // Gestion_Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.dataGridEventos);
            this.Controls.Add(this.btnCrearEvento);
            this.Controls.Add(this.cmoModalidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtimeInicio);
            this.Controls.Add(this.cmoCampeonato);
            this.Controls.Add(this.cmoDeportes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmoPais);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Gestion_Eventos";
            this.Size = new System.Drawing.Size(927, 366);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private ComboBox cmoModalidad;
        private Label label5;
        private DateTimePicker dtimeInicio;
        private ComboBox cmoCampeonato;
        private ComboBox cmoDeportes;
        private Label label7;
        private ComboBox cmoPais;
        private Label label6;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btnCrearEvento;
        private DataGridView dataGridEventos;
    }
}
