﻿
namespace LoginWinForms
{
    partial class Registro
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fieldUsuario = new System.Windows.Forms.TextBox();
            this.fieldCorreo = new System.Windows.Forms.TextBox();
            this.fieldPasswd = new System.Windows.Forms.TextBox();
            this.fieldPasswd2 = new System.Windows.Forms.TextBox();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirmar contraseña";
            // 
            // fieldUsuario
            // 
            this.fieldUsuario.Location = new System.Drawing.Point(408, 138);
            this.fieldUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fieldUsuario.Name = "fieldUsuario";
            this.fieldUsuario.Size = new System.Drawing.Size(222, 26);
            this.fieldUsuario.TabIndex = 4;
            this.fieldUsuario.TextChanged += new System.EventHandler(this.fieldUsuario_TextChanged);
            // 
            // fieldCorreo
            // 
            this.fieldCorreo.Location = new System.Drawing.Point(408, 188);
            this.fieldCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fieldCorreo.Name = "fieldCorreo";
            this.fieldCorreo.Size = new System.Drawing.Size(222, 26);
            this.fieldCorreo.TabIndex = 5;
            // 
            // fieldPasswd
            // 
            this.fieldPasswd.Location = new System.Drawing.Point(408, 236);
            this.fieldPasswd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fieldPasswd.Name = "fieldPasswd";
            this.fieldPasswd.Size = new System.Drawing.Size(222, 26);
            this.fieldPasswd.TabIndex = 6;
            // 
            // fieldPasswd2
            // 
            this.fieldPasswd2.Location = new System.Drawing.Point(408, 282);
            this.fieldPasswd2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fieldPasswd2.Name = "fieldPasswd2";
            this.fieldPasswd2.Size = new System.Drawing.Size(222, 26);
            this.fieldPasswd2.TabIndex = 7;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(461, 349);
            this.buttonRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(119, 32);
            this.buttonRegistrar.TabIndex = 8;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.fieldPasswd2);
            this.Controls.Add(this.fieldPasswd);
            this.Controls.Add(this.fieldCorreo);
            this.Controls.Add(this.fieldUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Registro";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fieldUsuario;
        private System.Windows.Forms.TextBox fieldCorreo;
        private System.Windows.Forms.TextBox fieldPasswd;
        private System.Windows.Forms.TextBox fieldPasswd2;
        private System.Windows.Forms.Button buttonRegistrar;
    }
}

