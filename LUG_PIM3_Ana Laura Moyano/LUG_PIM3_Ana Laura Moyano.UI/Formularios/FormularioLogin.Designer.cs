namespace LUG_PIM3_Ana_Laura_Moyano.UI.Formularios
{
    partial class FormularioLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_usuario_login = new System.Windows.Forms.TextBox();
            this.txt_contrasenia_login = new System.Windows.Forms.TextBox();
            this.btn_login_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txt_usuario_login
            // 
            this.txt_usuario_login.Location = new System.Drawing.Point(376, 103);
            this.txt_usuario_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_usuario_login.MaxLength = 20;
            this.txt_usuario_login.Name = "txt_usuario_login";
            this.txt_usuario_login.Size = new System.Drawing.Size(244, 22);
            this.txt_usuario_login.TabIndex = 2;
            // 
            // txt_contrasenia_login
            // 
            this.txt_contrasenia_login.Location = new System.Drawing.Point(376, 150);
            this.txt_contrasenia_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_contrasenia_login.MaxLength = 255;
            this.txt_contrasenia_login.Name = "txt_contrasenia_login";
            this.txt_contrasenia_login.Size = new System.Drawing.Size(244, 22);
            this.txt_contrasenia_login.TabIndex = 3;
            this.txt_contrasenia_login.UseSystemPasswordChar = true;
            // 
            // btn_login_login
            // 
            this.btn_login_login.Location = new System.Drawing.Point(339, 329);
            this.btn_login_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login_login.Name = "btn_login_login";
            this.btn_login_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login_login.TabIndex = 4;
            this.btn_login_login.Text = "LOGIN";
            this.btn_login_login.UseVisualStyleBackColor = true;
            this.btn_login_login.Click += new System.EventHandler(this.btn_login_login_Click);
            // 
            // FormularioLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_login_login);
            this.Controls.Add(this.txt_contrasenia_login);
            this.Controls.Add(this.txt_usuario_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormularioLogin";
            this.Text = "FormularioLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_usuario_login;
        private System.Windows.Forms.TextBox txt_contrasenia_login;
        private System.Windows.Forms.Button btn_login_login;
    }
}