namespace LUG_PIM3_Ana_Laura_Moyano.UI.Formularios
{
    partial class FormularioMateria
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
            this.btn_aceptar_materia = new System.Windows.Forms.Button();
            this.btn_cancelar_materia = new System.Windows.Forms.Button();
            this.txt_codigo_materia = new System.Windows.Forms.TextBox();
            this.txt_descripcion_materia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // btn_aceptar_materia
            // 
            this.btn_aceptar_materia.Location = new System.Drawing.Point(96, 372);
            this.btn_aceptar_materia.Name = "btn_aceptar_materia";
            this.btn_aceptar_materia.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar_materia.TabIndex = 3;
            this.btn_aceptar_materia.Text = "Aceptar";
            this.btn_aceptar_materia.UseVisualStyleBackColor = true;
            this.btn_aceptar_materia.Click += new System.EventHandler(this.btn_aceptar_materia_Click);
            // 
            // btn_cancelar_materia
            // 
            this.btn_cancelar_materia.Location = new System.Drawing.Point(537, 371);
            this.btn_cancelar_materia.Name = "btn_cancelar_materia";
            this.btn_cancelar_materia.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar_materia.TabIndex = 4;
            this.btn_cancelar_materia.Text = "Cancelar";
            this.btn_cancelar_materia.UseVisualStyleBackColor = true;
            this.btn_cancelar_materia.Click += new System.EventHandler(this.btn_cancelar_materia_Click);
            // 
            // txt_codigo_materia
            // 
            this.txt_codigo_materia.Location = new System.Drawing.Point(377, 106);
            this.txt_codigo_materia.MaxLength = 20;
            this.txt_codigo_materia.Name = "txt_codigo_materia";
            this.txt_codigo_materia.Size = new System.Drawing.Size(379, 22);
            this.txt_codigo_materia.TabIndex = 5;
            // 
            // txt_descripcion_materia
            // 
            this.txt_descripcion_materia.Location = new System.Drawing.Point(377, 165);
            this.txt_descripcion_materia.MaxLength = 120;
            this.txt_descripcion_materia.Name = "txt_descripcion_materia";
            this.txt_descripcion_materia.Size = new System.Drawing.Size(379, 22);
            this.txt_descripcion_materia.TabIndex = 6;
            // 
            // FormularioMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_descripcion_materia);
            this.Controls.Add(this.txt_codigo_materia);
            this.Controls.Add(this.btn_cancelar_materia);
            this.Controls.Add(this.btn_aceptar_materia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioMateria";
            this.Text = "FormularioMateria";
            this.Load += new System.EventHandler(this.FormularioMateria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_aceptar_materia;
        private System.Windows.Forms.Button btn_cancelar_materia;
        private System.Windows.Forms.TextBox txt_codigo_materia;
        private System.Windows.Forms.TextBox txt_descripcion_materia;
    }
}