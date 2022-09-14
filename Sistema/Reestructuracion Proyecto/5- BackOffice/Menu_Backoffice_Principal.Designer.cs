using System;
using System.Windows.Forms;

namespace Proyecto._5__BackOffice.Superusuario
{
    partial class Menu_Backoffice_Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Backoffice_Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imagenDesconectado = new System.Windows.Forms.PictureBox();
            this.imagenConectado = new System.Windows.Forms.PictureBox();
            this.separador = new System.Windows.Forms.PictureBox();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imagenUsuario = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelNavegacion = new System.Windows.Forms.Panel();
            this.temporizadorNotificativo = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenDesconectado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenConectado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(101)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.imagenUsuario);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 54);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.imagenDesconectado);
            this.panel2.Controls.Add(this.imagenConectado);
            this.panel2.Controls.Add(this.separador);
            this.panel2.Controls.Add(this.lblNombreApellido);
            this.panel2.Location = new System.Drawing.Point(621, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 19);
            this.panel2.TabIndex = 7;
            // 
            // imagenDesconectado
            // 
            this.imagenDesconectado.Dock = System.Windows.Forms.DockStyle.Right;
            this.imagenDesconectado.Image = ((System.Drawing.Image)(resources.GetObject("imagenDesconectado.Image")));
            this.imagenDesconectado.Location = new System.Drawing.Point(29, 0);
            this.imagenDesconectado.Name = "imagenDesconectado";
            this.imagenDesconectado.Size = new System.Drawing.Size(28, 19);
            this.imagenDesconectado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenDesconectado.TabIndex = 7;
            this.imagenDesconectado.TabStop = false;
            this.imagenDesconectado.Visible = false;
            // 
            // imagenConectado
            // 
            this.imagenConectado.Dock = System.Windows.Forms.DockStyle.Right;
            this.imagenConectado.Image = ((System.Drawing.Image)(resources.GetObject("imagenConectado.Image")));
            this.imagenConectado.Location = new System.Drawing.Point(57, 0);
            this.imagenConectado.Name = "imagenConectado";
            this.imagenConectado.Size = new System.Drawing.Size(28, 19);
            this.imagenConectado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenConectado.TabIndex = 6;
            this.imagenConectado.TabStop = false;
            this.imagenConectado.Visible = false;
            // 
            // separador
            // 
            this.separador.Dock = System.Windows.Forms.DockStyle.Right;
            this.separador.Location = new System.Drawing.Point(85, 0);
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(5, 19);
            this.separador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.separador.TabIndex = 5;
            this.separador.TabStop = false;
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNombreApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombreApellido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNombreApellido.Location = new System.Drawing.Point(90, 0);
            this.lblNombreApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(143, 19);
            this.lblNombreApellido.TabIndex = 4;
            this.lblNombreApellido.Text = "Nombre Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(69, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "BackOffice de Administracion";
            // 
            // imagenUsuario
            // 
            this.imagenUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(101)))), ((int)(((byte)(138)))));
            this.imagenUsuario.Image = ((System.Drawing.Image)(resources.GetObject("imagenUsuario.Image")));
            this.imagenUsuario.ImageRotate = 0F;
            this.imagenUsuario.Location = new System.Drawing.Point(858, 3);
            this.imagenUsuario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.imagenUsuario.Name = "imagenUsuario";
            this.imagenUsuario.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imagenUsuario.Size = new System.Drawing.Size(64, 47);
            this.imagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenUsuario.TabIndex = 5;
            this.imagenUsuario.TabStop = false;
            this.imagenUsuario.Click += new System.EventHandler(this.imagenUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(101)))), ((int)(((byte)(138)))));
            this.pictureBox1.Image = global::Reestructuracion_Proyecto.Properties.Resources.trophy_png_25086;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContenedor.Location = new System.Drawing.Point(0, 83);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(927, 366);
            this.panelContenedor.TabIndex = 4;
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(100)))), ((int)(((byte)(25)))));
            this.panel3.Controls.Add(this.lblAdministrador);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 29);
            this.panel3.TabIndex = 25;
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblAdministrador.ForeColor = System.Drawing.Color.Black;
            this.lblAdministrador.Location = new System.Drawing.Point(2, 5);
            this.lblAdministrador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(135, 19);
            this.lblAdministrador.TabIndex = 2;
            this.lblAdministrador.Text = "Panel de control";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(0, 54);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(140, 29);
            this.panel4.TabIndex = 26;
            // 
            // panelNavegacion
            // 
            this.panelNavegacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNavegacion.Location = new System.Drawing.Point(140, 54);
            this.panelNavegacion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelNavegacion.Name = "panelNavegacion";
            this.panelNavegacion.Size = new System.Drawing.Size(787, 29);
            this.panelNavegacion.TabIndex = 27;
            // 
            // temporizadorNotificativo
            // 
            this.temporizadorNotificativo.Interval = 6000;
            this.temporizadorNotificativo.Tick += new System.EventHandler(this.temporizadorNotificativo_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu_Backoffice_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(927, 449);
            this.Controls.Add(this.panelNavegacion);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Menu_Backoffice_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sistema de Eventos Deportivos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenDesconectado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenConectado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private Panel panel1;
        private Label lblNombreApellido;
        private PictureBox pictureBox1;
        private Panel panelContenedor;
        private Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imagenUsuario;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Panel panel3;
        private Label lblAdministrador;
        private Panel panel4;
        private Panel panelNavegacion;
        private PictureBox separador;
        private PictureBox imagenDesconectado;
        private PictureBox imagenConectado;
        private Timer temporizadorNotificativo;
        private Button button1;
    }
}