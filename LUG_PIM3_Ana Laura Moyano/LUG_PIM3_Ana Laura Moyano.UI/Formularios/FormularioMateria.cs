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
    public partial class FormularioMateria : Form
    {
        private MateriaBLL materiaBLL;
        private Materia materia;

        public event EventHandler MateriaAgregada;

        public FormularioMateria(Materia materia, MateriaBLL materiaBLL)
        {
            InitializeComponent();

            if(materia == null)
            {
                this.materia = new Materia();
            }
            else
            {
                this.materia = materia;
            }
            this.materiaBLL = materiaBLL;
            LlenarCamposConMateria();
        }

        public FormularioMateria()
        {
            InitializeComponent();
        }

        public void LeerMateria()
        {
            materia.Codigo = txt_codigo_materia.Text;
            materia.Descripcion = txt_descripcion_materia.Text;
        }
        
        public void LlenarCamposConMateria()
        {
            txt_codigo_materia.Text = materia.Codigo;
            txt_descripcion_materia.Text = materia.Descripcion;
        }

        private void FormularioMateria_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_materia_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_aceptar_materia_Click(object sender, EventArgs e)
        {
            try
            {
                LeerMateria();
                if(materia.Id == 0)
                {
                    materiaBLL.GuardarMateria(materia);
                    MateriaAgregada?.Invoke(this, new EventArgs());
                }
                else
                {
                    materiaBLL.ActualizarMateria(materia);
                }
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
