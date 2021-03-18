using LUG_PIM3_Ana_Laura_Moyano.BE;
using LUG_PIM3_Ana_Laura_Moyano.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUG_PIM3_Ana_Laura_Moyano.UI.Formularios
{
    public partial class FormularioEstudiante : Form
    {
        private EstudianteBLL estudianteBLL;
        private Estudiante estudiante;

        public event EventHandler EstudianteAgregado;

        public FormularioEstudiante(Estudiante estudiante,EstudianteBLL estudianteBLL)
        {
            InitializeComponent();

            if (estudiante == null)
            {
                this.estudiante = new Estudiante();
            }
            else
            {
                this.estudiante = estudiante;
            }

            this.estudianteBLL = estudianteBLL;
            LLenarCamposConEstudiante();
        }

        public FormularioEstudiante()
        {
            InitializeComponent();
        }

        public void LeerEstudiante()
        {
            estudiante.Nombre = txt_nombres_estudiante.Text;
            estudiante.Apellido = txt_apellido_estudiante.Text;
            estudiante.Legajo = txt_legajo_estudiante.Text;
            estudiante.Celular = txt_celular_estudiante.Text;
            estudiante.Telefono = txt_telefono_estudiante.Text;
            estudiante.Email = txt_email_estudiante.Text;
            estudiante.Direccion = txt_direccion_estudiante.Text;
            estudiante.FechaNacimiento = dt_fecha_de_nacimiento_estudiante.Value;

        }


        public void LLenarCamposConEstudiante()
        {
            txt_nombres_estudiante.Text = estudiante.Nombre;
            txt_apellido_estudiante.Text = estudiante.Apellido;
            txt_legajo_estudiante.Text = estudiante.Legajo;
            txt_celular_estudiante.Text = estudiante.Celular;
            txt_telefono_estudiante.Text = estudiante.Telefono;
            txt_email_estudiante.Text = estudiante.Email;
            txt_direccion_estudiante.Text = estudiante.Direccion;
            if(estudiante.FechaNacimiento == default(DateTime))
            {
                dt_fecha_de_nacimiento_estudiante.Value = DateTime.Now;
            }
            
            else
            {
                dt_fecha_de_nacimiento_estudiante.Value = estudiante.FechaNacimiento;
            }
        }


        private void btn_cancelar_estudiante_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_aceptar_estudiante_Click(object sender, EventArgs e)
        {
            try
            {
                LeerEstudiante();
                if(estudiante.Id == 0)
                {
                    estudianteBLL.AgregarEstudiante(estudiante);

                }
                else
                {
                    estudianteBLL.ActualizarEstudiante(estudiante);
                }
                EstudianteAgregado?.Invoke(this, new EventArgs());
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FormularioEstudiante_Load(object sender, EventArgs e)
        {

        }
    }
}
