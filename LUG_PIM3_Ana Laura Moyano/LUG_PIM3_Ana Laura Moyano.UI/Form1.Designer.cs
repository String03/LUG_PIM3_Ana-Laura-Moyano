namespace LUG_PIM3_Ana_Laura_Moyano.UI
{
    partial class Form1
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
            this.grillaEstudiante = new System.Windows.Forms.DataGridView();
            this.grillaMateria = new System.Windows.Forms.DataGridView();
            this.grillaMateriaPorEstudiante = new System.Windows.Forms.DataGridView();
            this.btn_alta_estudiante = new System.Windows.Forms.Button();
            this.btn_modificacion_estudiante = new System.Windows.Forms.Button();
            this.btn_baja_estudiante = new System.Windows.Forms.Button();
            this.btn_alta_materia = new System.Windows.Forms.Button();
            this.btn_modificacion_materia = new System.Windows.Forms.Button();
            this.btn_baja_materia = new System.Windows.Forms.Button();
            this.btn_materias_por_estudiante = new System.Windows.Forms.Button();
            this.btnXmlEstudiante = new System.Windows.Forms.Button();
            this.btn_nota = new System.Windows.Forms.Button();
            this.cbo_nota = new System.Windows.Forms.ComboBox();
            this.btn_eliminar_materia_por_estudiante = new System.Windows.Forms.Button();
            this.btnLeerXmlAlumno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMateriaPorEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaEstudiante
            // 
            this.grillaEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaEstudiante.Location = new System.Drawing.Point(114, 48);
            this.grillaEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.grillaEstudiante.MultiSelect = false;
            this.grillaEstudiante.Name = "grillaEstudiante";
            this.grillaEstudiante.ReadOnly = true;
            this.grillaEstudiante.RowTemplate.Height = 24;
            this.grillaEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaEstudiante.Size = new System.Drawing.Size(291, 160);
            this.grillaEstudiante.TabIndex = 0;
            this.grillaEstudiante.SelectionChanged += new System.EventHandler(this.grillaEstudiante_SelectionChanged);
            // 
            // grillaMateria
            // 
            this.grillaMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaMateria.Location = new System.Drawing.Point(637, 48);
            this.grillaMateria.Margin = new System.Windows.Forms.Padding(2);
            this.grillaMateria.MultiSelect = false;
            this.grillaMateria.Name = "grillaMateria";
            this.grillaMateria.ReadOnly = true;
            this.grillaMateria.RowTemplate.Height = 24;
            this.grillaMateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaMateria.Size = new System.Drawing.Size(291, 160);
            this.grillaMateria.TabIndex = 1;
            // 
            // grillaMateriaPorEstudiante
            // 
            this.grillaMateriaPorEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaMateriaPorEstudiante.Location = new System.Drawing.Point(376, 303);
            this.grillaMateriaPorEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.grillaMateriaPorEstudiante.MultiSelect = false;
            this.grillaMateriaPorEstudiante.Name = "grillaMateriaPorEstudiante";
            this.grillaMateriaPorEstudiante.ReadOnly = true;
            this.grillaMateriaPorEstudiante.RowTemplate.Height = 24;
            this.grillaMateriaPorEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaMateriaPorEstudiante.Size = new System.Drawing.Size(291, 160);
            this.grillaMateriaPorEstudiante.TabIndex = 2;
            // 
            // btn_alta_estudiante
            // 
            this.btn_alta_estudiante.Location = new System.Drawing.Point(114, 237);
            this.btn_alta_estudiante.Margin = new System.Windows.Forms.Padding(2);
            this.btn_alta_estudiante.Name = "btn_alta_estudiante";
            this.btn_alta_estudiante.Size = new System.Drawing.Size(74, 34);
            this.btn_alta_estudiante.TabIndex = 3;
            this.btn_alta_estudiante.Text = "Alta Estudiante";
            this.btn_alta_estudiante.UseVisualStyleBackColor = true;
            this.btn_alta_estudiante.Click += new System.EventHandler(this.btn_alta_estudiante_Click);
            // 
            // btn_modificacion_estudiante
            // 
            this.btn_modificacion_estudiante.Location = new System.Drawing.Point(220, 237);
            this.btn_modificacion_estudiante.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modificacion_estudiante.Name = "btn_modificacion_estudiante";
            this.btn_modificacion_estudiante.Size = new System.Drawing.Size(74, 34);
            this.btn_modificacion_estudiante.TabIndex = 4;
            this.btn_modificacion_estudiante.Text = "Modificación Estudiante";
            this.btn_modificacion_estudiante.UseVisualStyleBackColor = true;
            this.btn_modificacion_estudiante.Click += new System.EventHandler(this.btn_modificacion_estudiante_Click);
            // 
            // btn_baja_estudiante
            // 
            this.btn_baja_estudiante.Location = new System.Drawing.Point(331, 237);
            this.btn_baja_estudiante.Margin = new System.Windows.Forms.Padding(2);
            this.btn_baja_estudiante.Name = "btn_baja_estudiante";
            this.btn_baja_estudiante.Size = new System.Drawing.Size(74, 34);
            this.btn_baja_estudiante.TabIndex = 5;
            this.btn_baja_estudiante.Text = "Baja Estudiante";
            this.btn_baja_estudiante.UseVisualStyleBackColor = true;
            this.btn_baja_estudiante.Click += new System.EventHandler(this.btn_baja_estudiante_Click);
            // 
            // btn_alta_materia
            // 
            this.btn_alta_materia.Location = new System.Drawing.Point(637, 237);
            this.btn_alta_materia.Margin = new System.Windows.Forms.Padding(2);
            this.btn_alta_materia.Name = "btn_alta_materia";
            this.btn_alta_materia.Size = new System.Drawing.Size(74, 34);
            this.btn_alta_materia.TabIndex = 6;
            this.btn_alta_materia.Text = "Alta Materia";
            this.btn_alta_materia.UseVisualStyleBackColor = true;
            this.btn_alta_materia.Click += new System.EventHandler(this.btn_alta_materia_Click);
            // 
            // btn_modificacion_materia
            // 
            this.btn_modificacion_materia.Location = new System.Drawing.Point(748, 237);
            this.btn_modificacion_materia.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modificacion_materia.Name = "btn_modificacion_materia";
            this.btn_modificacion_materia.Size = new System.Drawing.Size(74, 34);
            this.btn_modificacion_materia.TabIndex = 7;
            this.btn_modificacion_materia.Text = "Modificación Materia";
            this.btn_modificacion_materia.UseVisualStyleBackColor = true;
            this.btn_modificacion_materia.Click += new System.EventHandler(this.btn_modificacion_materia_Click);
            // 
            // btn_baja_materia
            // 
            this.btn_baja_materia.Location = new System.Drawing.Point(854, 237);
            this.btn_baja_materia.Margin = new System.Windows.Forms.Padding(2);
            this.btn_baja_materia.Name = "btn_baja_materia";
            this.btn_baja_materia.Size = new System.Drawing.Size(74, 34);
            this.btn_baja_materia.TabIndex = 8;
            this.btn_baja_materia.Text = "Baja Materia";
            this.btn_baja_materia.UseVisualStyleBackColor = true;
            this.btn_baja_materia.Click += new System.EventHandler(this.btn_baja_materia_Click);
            // 
            // btn_materias_por_estudiante
            // 
            this.btn_materias_por_estudiante.Location = new System.Drawing.Point(482, 99);
            this.btn_materias_por_estudiante.Margin = new System.Windows.Forms.Padding(2);
            this.btn_materias_por_estudiante.Name = "btn_materias_por_estudiante";
            this.btn_materias_por_estudiante.Size = new System.Drawing.Size(76, 48);
            this.btn_materias_por_estudiante.TabIndex = 9;
            this.btn_materias_por_estudiante.Text = "Materias Por Estudiante";
            this.btn_materias_por_estudiante.UseVisualStyleBackColor = true;
            this.btn_materias_por_estudiante.Click += new System.EventHandler(this.btn_materias_por_estudiante_Click);
            // 
            // btnXmlEstudiante
            // 
            this.btnXmlEstudiante.Location = new System.Drawing.Point(113, 303);
            this.btnXmlEstudiante.Name = "btnXmlEstudiante";
            this.btnXmlEstudiante.Size = new System.Drawing.Size(118, 23);
            this.btnXmlEstudiante.TabIndex = 10;
            this.btnXmlEstudiante.Text = "Guardar XML Estudiante";
            this.btnXmlEstudiante.UseVisualStyleBackColor = true;
            this.btnXmlEstudiante.Click += new System.EventHandler(this.btnXmlEstudiante_Click);
            // 
            // btn_nota
            // 
            this.btn_nota.Location = new System.Drawing.Point(376, 548);
            this.btn_nota.Name = "btn_nota";
            this.btn_nota.Size = new System.Drawing.Size(75, 23);
            this.btn_nota.TabIndex = 11;
            this.btn_nota.Text = "Nota";
            this.btn_nota.UseVisualStyleBackColor = true;
            this.btn_nota.Click += new System.EventHandler(this.btn_nota_Click);
            // 
            // cbo_nota
            // 
            this.cbo_nota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nota.FormattingEnabled = true;
            this.cbo_nota.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbo_nota.Location = new System.Drawing.Point(547, 548);
            this.cbo_nota.Name = "cbo_nota";
            this.cbo_nota.Size = new System.Drawing.Size(121, 21);
            this.cbo_nota.TabIndex = 12;
            // 
            // btn_eliminar_materia_por_estudiante
            // 
            this.btn_eliminar_materia_por_estudiante.Location = new System.Drawing.Point(482, 203);
            this.btn_eliminar_materia_por_estudiante.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminar_materia_por_estudiante.Name = "btn_eliminar_materia_por_estudiante";
            this.btn_eliminar_materia_por_estudiante.Size = new System.Drawing.Size(76, 48);
            this.btn_eliminar_materia_por_estudiante.TabIndex = 13;
            this.btn_eliminar_materia_por_estudiante.Text = "Eliminar Materia Por Estudiante";
            this.btn_eliminar_materia_por_estudiante.UseVisualStyleBackColor = true;
            this.btn_eliminar_materia_por_estudiante.Click += new System.EventHandler(this.btn_eliminar_materia_por_estudiante_Click);
            // 
            // btnLeerXmlAlumno
            // 
            this.btnLeerXmlAlumno.Location = new System.Drawing.Point(247, 303);
            this.btnLeerXmlAlumno.Name = "btnLeerXmlAlumno";
            this.btnLeerXmlAlumno.Size = new System.Drawing.Size(97, 23);
            this.btnLeerXmlAlumno.TabIndex = 14;
            this.btnLeerXmlAlumno.Text = "Leer XML";
            this.btnLeerXmlAlumno.UseVisualStyleBackColor = true;
            this.btnLeerXmlAlumno.Click += new System.EventHandler(this.btnLeerXmlAlumno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 675);
            this.Controls.Add(this.btnLeerXmlAlumno);
            this.Controls.Add(this.btn_eliminar_materia_por_estudiante);
            this.Controls.Add(this.cbo_nota);
            this.Controls.Add(this.btn_nota);
            this.Controls.Add(this.btnXmlEstudiante);
            this.Controls.Add(this.btn_materias_por_estudiante);
            this.Controls.Add(this.btn_baja_materia);
            this.Controls.Add(this.btn_modificacion_materia);
            this.Controls.Add(this.btn_alta_materia);
            this.Controls.Add(this.btn_baja_estudiante);
            this.Controls.Add(this.btn_modificacion_estudiante);
            this.Controls.Add(this.btn_alta_estudiante);
            this.Controls.Add(this.grillaMateriaPorEstudiante);
            this.Controls.Add(this.grillaMateria);
            this.Controls.Add(this.grillaEstudiante);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grillaEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMateriaPorEstudiante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaEstudiante;
        private System.Windows.Forms.DataGridView grillaMateria;
        private System.Windows.Forms.DataGridView grillaMateriaPorEstudiante;
        private System.Windows.Forms.Button btn_alta_estudiante;
        private System.Windows.Forms.Button btn_modificacion_estudiante;
        private System.Windows.Forms.Button btn_baja_estudiante;
        private System.Windows.Forms.Button btn_alta_materia;
        private System.Windows.Forms.Button btn_modificacion_materia;
        private System.Windows.Forms.Button btn_baja_materia;
        private System.Windows.Forms.Button btn_materias_por_estudiante;
        private System.Windows.Forms.Button btnXmlEstudiante;
        private System.Windows.Forms.Button btn_nota;
        private System.Windows.Forms.ComboBox cbo_nota;
        private System.Windows.Forms.Button btn_eliminar_materia_por_estudiante;
        private System.Windows.Forms.Button btnLeerXmlAlumno;
    }
}

