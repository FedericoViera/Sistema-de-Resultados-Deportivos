﻿using System.Windows.Forms;

namespace Proyecto
{
    partial class Seleccion_Aplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seleccion_Aplicacion));
            this.btnAppEstandar = new System.Windows.Forms.Button();
            this.btnAppBackoffice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAppEstandar
            // 
            this.btnAppEstandar.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAppEstandar.Location = new System.Drawing.Point(60, 59);
            this.btnAppEstandar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAppEstandar.Name = "btnAppEstandar";
            this.btnAppEstandar.Size = new System.Drawing.Size(267, 32);
            this.btnAppEstandar.TabIndex = 0;
            this.btnAppEstandar.Text = "Aplicacion Usuario Estandar";
            this.btnAppEstandar.UseVisualStyleBackColor = true;
            this.btnAppEstandar.Click += new System.EventHandler(this.btnAppEstandar_Click);
            // 
            // btnAppBackoffice
            // 
            this.btnAppBackoffice.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAppBackoffice.Location = new System.Drawing.Point(60, 108);
            this.btnAppBackoffice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAppBackoffice.Name = "btnAppBackoffice";
            this.btnAppBackoffice.Size = new System.Drawing.Size(267, 32);
            this.btnAppBackoffice.TabIndex = 1;
            this.btnAppBackoffice.Text = "Aplicacion BackOffice";
            this.btnAppBackoffice.UseVisualStyleBackColor = true;
            this.btnAppBackoffice.Click += new System.EventHandler(this.btnBackoffice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Esta interfaz es solo para desarrollar pruebas y evaluar el codigo";
            // 
            // Seleccion_Aplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAppBackoffice);
            this.Controls.Add(this.btnAppEstandar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Seleccion_Aplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar aplicaicon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAppEstandar;
        private Button btnAppBackoffice;
        private Label label1;
    }
}