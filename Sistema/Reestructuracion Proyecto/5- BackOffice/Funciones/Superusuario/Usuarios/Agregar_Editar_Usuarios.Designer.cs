using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Funciones.Superusuario.Usuarios
{
    partial class Agregar_Editar_Usuarios
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
            this.btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            this.gboComprobar = new System.Windows.Forms.GroupBox();
            this.btnComprobar = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.gboInformacion = new System.Windows.Forms.GroupBox();
            this.chkContraseña = new System.Windows.Forms.CheckBox();
            this.btnAccionUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminarTexto = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.chkListBoxRol = new System.Windows.Forms.CheckedListBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gboComprobar.SuspendLayout();
            this.gboInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnCerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrar.FillColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(227, 318);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(213, 29);
            this.btnCerrar.TabIndex = 41;
            this.btnCerrar.Text = "Volver a la lista de usuarios";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gboComprobar
            // 
            this.gboComprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.gboComprobar.Controls.Add(this.btnComprobar);
            this.gboComprobar.Controls.Add(this.label3);
            this.gboComprobar.Controls.Add(this.txtUser);
            this.gboComprobar.Location = new System.Drawing.Point(0, 3);
            this.gboComprobar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gboComprobar.Name = "gboComprobar";
            this.gboComprobar.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gboComprobar.Size = new System.Drawing.Size(458, 59);
            this.gboComprobar.TabIndex = 40;
            this.gboComprobar.TabStop = false;
            this.gboComprobar.Text = "Comprobación usuario ";
            // 
            // btnComprobar
            // 
            this.btnComprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnComprobar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComprobar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComprobar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComprobar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComprobar.FillColor = System.Drawing.Color.Transparent;
            this.btnComprobar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnComprobar.ForeColor = System.Drawing.Color.Black;
            this.btnComprobar.Location = new System.Drawing.Point(277, 19);
            this.btnComprobar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(163, 25);
            this.btnComprobar.TabIndex = 32;
            this.btnComprobar.Text = "Comprobar usuario";
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre usuario:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(139, 22);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(116, 20);
            this.txtUser.TabIndex = 3;
            // 
            // gboInformacion
            // 
            this.gboInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.gboInformacion.Controls.Add(this.chkContraseña);
            this.gboInformacion.Controls.Add(this.btnAccionUsuario);
            this.gboInformacion.Controls.Add(this.btnEliminarTexto);
            this.gboInformacion.Controls.Add(this.label4);
            this.gboInformacion.Controls.Add(this.txtName);
            this.gboInformacion.Controls.Add(this.label6);
            this.gboInformacion.Controls.Add(this.txtLastName);
            this.gboInformacion.Controls.Add(this.chkListBoxRol);
            this.gboInformacion.Controls.Add(this.lblContraseña);
            this.gboInformacion.Controls.Add(this.txtEmail);
            this.gboInformacion.Controls.Add(this.txtPassword);
            this.gboInformacion.Controls.Add(this.label5);
            this.gboInformacion.Location = new System.Drawing.Point(1, 77);
            this.gboInformacion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gboInformacion.Name = "gboInformacion";
            this.gboInformacion.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gboInformacion.Size = new System.Drawing.Size(458, 233);
            this.gboInformacion.TabIndex = 39;
            this.gboInformacion.TabStop = false;
            this.gboInformacion.Text = "Información del usuario";
            // 
            // chkContraseña
            // 
            this.chkContraseña.AutoSize = true;
            this.chkContraseña.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.chkContraseña.Location = new System.Drawing.Point(276, 151);
            this.chkContraseña.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkContraseña.Name = "chkContraseña";
            this.chkContraseña.Size = new System.Drawing.Size(105, 20);
            this.chkContraseña.TabIndex = 35;
            this.chkContraseña.Text = "Reestablecer";
            this.chkContraseña.UseVisualStyleBackColor = true;
            this.chkContraseña.CheckedChanged += new System.EventHandler(this.chkContraseña_CheckedChanged);
            // 
            // btnAccionUsuario
            // 
            this.btnAccionUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnAccionUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccionUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccionUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccionUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccionUsuario.FillColor = System.Drawing.Color.Transparent;
            this.btnAccionUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAccionUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnAccionUsuario.Location = new System.Drawing.Point(137, 191);
            this.btnAccionUsuario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAccionUsuario.Name = "btnAccionUsuario";
            this.btnAccionUsuario.Size = new System.Drawing.Size(134, 29);
            this.btnAccionUsuario.TabIndex = 34;
            this.btnAccionUsuario.Text = "Crear usuario";
            this.btnAccionUsuario.Click += new System.EventHandler(this.btnAccionUsuario_Click);
            // 
            // btnEliminarTexto
            // 
            this.btnEliminarTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(45)))));
            this.btnEliminarTexto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarTexto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarTexto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarTexto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarTexto.FillColor = System.Drawing.Color.Transparent;
            this.btnEliminarTexto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminarTexto.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarTexto.Location = new System.Drawing.Point(290, 191);
            this.btnEliminarTexto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEliminarTexto.Name = "btnEliminarTexto";
            this.btnEliminarTexto.Size = new System.Drawing.Size(133, 29);
            this.btnEliminarTexto.TabIndex = 33;
            this.btnEliminarTexto.Text = "Limpiar datos";
            this.btnEliminarTexto.Click += new System.EventHandler(this.btnEliminarTexto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(33, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 35);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 20);
            this.txtName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(32, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Apellido:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(138, 72);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(116, 20);
            this.txtLastName.TabIndex = 9;
            // 
            // chkListBoxRol
            // 
            this.chkListBoxRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.chkListBoxRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkListBoxRol.CheckOnClick = true;
            this.chkListBoxRol.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.chkListBoxRol.FormattingEnabled = true;
            this.chkListBoxRol.Items.AddRange(new object[] {
            "Basico",
            "Premium",
            "Publicitario",
            "Notificativo",
            "Superusuario"});
            this.chkListBoxRol.Location = new System.Drawing.Point(297, 36);
            this.chkListBoxRol.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkListBoxRol.Name = "chkListBoxRol";
            this.chkListBoxRol.Size = new System.Drawing.Size(114, 105);
            this.chkListBoxRol.TabIndex = 15;
            this.chkListBoxRol.SelectedIndexChanged += new System.EventHandler(this.chkListBoxRol_SelectedIndexChanged);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblContraseña.Location = new System.Drawing.Point(31, 147);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(97, 18);
            this.lblContraseña.TabIndex = 10;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(138, 111);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(116, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(138, 148);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(116, 20);
            this.txtPassword.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(32, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email:";
            // 
            // Agregar_Editar_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(452, 351);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gboComprobar);
            this.Controls.Add(this.gboInformacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Agregar_Editar_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar_Editar_Usuarios";
            this.gboComprobar.ResumeLayout(false);
            this.gboComprobar.PerformLayout();
            this.gboInformacion.ResumeLayout(false);
            this.gboInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCerrar;
        private GroupBox gboComprobar;
        private Guna.UI2.WinForms.Guna2Button btnComprobar;
        private Label label3;
        private TextBox txtUser;
        private GroupBox gboInformacion;
        private Guna.UI2.WinForms.Guna2Button btnAccionUsuario;
        private Guna.UI2.WinForms.Guna2Button btnEliminarTexto;
        private Label label4;
        private TextBox txtName;
        private Label label6;
        private TextBox txtLastName;
        private CheckedListBox chkListBoxRol;
        private Label lblContraseña;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label5;
        private CheckBox chkContraseña;
    }
}