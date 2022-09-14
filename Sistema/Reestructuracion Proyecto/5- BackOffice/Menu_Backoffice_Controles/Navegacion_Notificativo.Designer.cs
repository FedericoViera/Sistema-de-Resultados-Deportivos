using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Menu_Backoffice_Controles
{
    partial class Navegacion_Notificativo
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
            this.btnResultados = new Guna.UI2.WinForms.Guna2Button();
            this.btnBajas = new Guna.UI2.WinForms.Guna2Button();
            this.btnActivacion = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnResultados
            // 
            this.btnResultados.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResultados.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResultados.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResultados.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResultados.FillColor = System.Drawing.Color.Transparent;
            this.btnResultados.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnResultados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnResultados.ForeColor = System.Drawing.Color.Black;
            this.btnResultados.Location = new System.Drawing.Point(434, 0);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(356, 29);
            this.btnResultados.TabIndex = 17;
            this.btnResultados.Text = "Ingreso de resultados y culminación de eventos";
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // btnBajas
            // 
            this.btnBajas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBajas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBajas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBajas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBajas.FillColor = System.Drawing.Color.Transparent;
            this.btnBajas.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBajas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBajas.ForeColor = System.Drawing.Color.Black;
            this.btnBajas.Location = new System.Drawing.Point(236, 0);
            this.btnBajas.Name = "btnBajas";
            this.btnBajas.Size = new System.Drawing.Size(198, 29);
            this.btnBajas.TabIndex = 14;
            this.btnBajas.Text = "Baja de cuentas premium";
            this.btnBajas.Click += new System.EventHandler(this.btnBajas_Click);
            // 
            // btnActivacion
            // 
            this.btnActivacion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActivacion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActivacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActivacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActivacion.FillColor = System.Drawing.Color.Transparent;
            this.btnActivacion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActivacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnActivacion.ForeColor = System.Drawing.Color.Black;
            this.btnActivacion.Location = new System.Drawing.Point(0, 0);
            this.btnActivacion.Name = "btnActivacion";
            this.btnActivacion.Size = new System.Drawing.Size(239, 29);
            this.btnActivacion.TabIndex = 16;
            this.btnActivacion.Text = "Activación de cuentas premium";
            this.btnActivacion.Click += new System.EventHandler(this.btnActivacion_Click);
            // 
            // Navegacion_Notificativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.btnBajas);
            this.Controls.Add(this.btnActivacion);
            this.Name = "Navegacion_Notificativo";
            this.Size = new System.Drawing.Size(787, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnResultados;
        private Guna.UI2.WinForms.Guna2Button btnBajas;
        private Guna.UI2.WinForms.Guna2Button btnActivacion;
    }
}
