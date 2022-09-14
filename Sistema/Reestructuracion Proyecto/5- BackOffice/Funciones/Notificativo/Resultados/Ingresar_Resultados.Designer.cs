using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Funciones.Notificativo.Resultados.Ingresar_Resultado
{
    partial class Ingresar_Resultados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboComprobar = new System.Windows.Forms.GroupBox();
            this.lblEvento = new System.Windows.Forms.Label();
            this.panelResultados = new System.Windows.Forms.Panel();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnVolver = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarTiempo = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdicionarTiempo = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.gboComprobar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboComprobar
            // 
            this.gboComprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.gboComprobar.Controls.Add(this.lblEvento);
            this.gboComprobar.Location = new System.Drawing.Point(51, 1);
            this.gboComprobar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gboComprobar.Name = "gboComprobar";
            this.gboComprobar.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gboComprobar.Size = new System.Drawing.Size(458, 59);
            this.gboComprobar.TabIndex = 40;
            this.gboComprobar.TabStop = false;
            // 
            // lblEvento
            // 
            this.lblEvento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEvento.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.Location = new System.Drawing.Point(4, 10);
            this.lblEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(450, 46);
            this.lblEvento.TabIndex = 2;
            this.lblEvento.Text = "Nombre evento:";
            this.lblEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelResultados
            // 
            this.panelResultados.Location = new System.Drawing.Point(0, 69);
            this.panelResultados.Name = "panelResultados";
            this.panelResultados.Size = new System.Drawing.Size(566, 313);
            this.panelResultados.TabIndex = 41;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardar.FillColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(409, 11);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 25);
            this.btnGuardar.TabIndex = 45;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnVolver.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVolver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVolver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVolver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVolver.FillColor = System.Drawing.Color.Transparent;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Location = new System.Drawing.Point(3, 11);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(69, 25);
            this.btnVolver.TabIndex = 46;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarTiempo);
            this.groupBox1.Controls.Add(this.btnAdicionarTiempo);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnVolver);
            this.groupBox1.Location = new System.Drawing.Point(4, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 41);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // btnEliminarTiempo
            // 
            this.btnEliminarTiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnEliminarTiempo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarTiempo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarTiempo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarTiempo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarTiempo.FillColor = System.Drawing.Color.Transparent;
            this.btnEliminarTiempo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminarTiempo.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarTiempo.Location = new System.Drawing.Point(146, 11);
            this.btnEliminarTiempo.Name = "btnEliminarTiempo";
            this.btnEliminarTiempo.Size = new System.Drawing.Size(131, 25);
            this.btnEliminarTiempo.TabIndex = 49;
            this.btnEliminarTiempo.Text = "Eliminar tiempo";
            this.btnEliminarTiempo.Click += new System.EventHandler(this.btnEliminarTiempo_Click);
            // 
            // btnAdicionarTiempo
            // 
            this.btnAdicionarTiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnAdicionarTiempo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionarTiempo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionarTiempo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdicionarTiempo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdicionarTiempo.FillColor = System.Drawing.Color.Transparent;
            this.btnAdicionarTiempo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdicionarTiempo.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionarTiempo.Location = new System.Drawing.Point(275, 11);
            this.btnAdicionarTiempo.Name = "btnAdicionarTiempo";
            this.btnAdicionarTiempo.Size = new System.Drawing.Size(139, 25);
            this.btnAdicionarTiempo.TabIndex = 48;
            this.btnAdicionarTiempo.Text = "Agregar tiempo";
            this.btnAdicionarTiempo.Click += new System.EventHandler(this.btnAdicionarTiempo_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(71, 11);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(77, 25);
            this.btnLimpiar.TabIndex = 47;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Ingresar_Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(566, 424);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelResultados);
            this.Controls.Add(this.gboComprobar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Ingresar_Resultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar_Editar_Usuarios";
            this.gboComprobar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox gboComprobar;
        private Label lblEvento;
        private Panel panelResultados;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnVolver;
        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private Guna.UI2.WinForms.Guna2Button btnAdicionarTiempo;
        private Guna.UI2.WinForms.Guna2Button btnEliminarTiempo;
    }
}