using LUG_PIM3_Ana_Laura_Moyano.BE;
using LUG_PIM3_Ana_Laura_Moyano.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUG_PIM3_Ana_Laura_Moyano.UI
{
    public partial class Form1 : Form
    {

        private EstudianteBLL estudianteBLL = new EstudianteBLL();
        private MateriaBLL materiaBLL = new MateriaBLL();

        public Form1()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["PIM3DB"].ConnectionString;


            RefrescarGrillaEstudiantes();
            RefrescarGrillaMaterias();
        }

        private void btn_alta_estudiante_Click(object sender, EventArgs e)
        {
            var form = new Formularios.FormularioEstudiante(new Estudiante(), estudianteBLL);
            form.EstudianteAgregado += (o, s) => RefrescarGrillaEstudiantes();
            form.Show(this);
        }

        private void RefrescarGrillaEstudiantes()
        {
            this.grillaEstudiante.DataSource = null;
            this.grillaEstudiante.DataSource = estudianteBLL.ListarEstudiantes();
        }

        private void RefrescarGrillaMaterias()
        {
            this.grillaMateria.DataSource = null;
            this.grillaMateria.DataSource = materiaBLL.ListarMaterias();
        }

        private void RefrescarGrillaMateriasPorEstudiante()
        {
            this.grillaMateriaPorEstudiante.DataSource = null;
            try
            {
                this.grillaMateriaPorEstudiante.DataSource = (grillaEstudiante.SelectedRows[0].DataBoundItem as Estudiante).Materias;

            }
            catch
            {
                this.grillaMateriaPorEstudiante.DataSource = null;
            }
        }

        private void btn_baja_estudiante_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiante estudiante;
                try
                {
                    estudiante = grillaEstudiante.SelectedRows[0].DataBoundItem as Estudiante;
                }
                catch (Exception)
                {

                    throw new Exception("Debe eliminar un estudiante");
                }
                estudianteBLL.EliminarEstudiante(estudiante);
                RefrescarGrillaEstudiantes();
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message);
            }

        }

        private void btn_modificacion_estudiante_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiante estudiante;
                try
                {
                    estudiante = grillaEstudiante.SelectedRows[0].DataBoundItem as Estudiante;
                }
                catch (Exception)
                {

                    throw new Exception("Debe modificar un estudiante");
                }
                var form = new Formularios.FormularioEstudiante(estudiante, estudianteBLL);
                form.EstudianteAgregado += (o, s) => RefrescarGrillaEstudiantes();
                form.Show(this);


            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message);
            }
        }

        private void btnXmlEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "XML - File | *.xml";
                sfd.FileOk += (o, s) =>
                {
                    try
                    {
                        string filename = ((SaveFileDialog)o).FileName;
                        XmlBLL xmlBLL = new XmlBLL(filename);
                        XmlViewModel datos = new XmlViewModel{ Estudiantes = estudianteBLL.ListarEstudiantes().ToList() };
                        xmlBLL.GuardarXml(datos);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error escribiendo datos en el xml.");
                    }
                };
                sfd.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio error guardando XML del estudiante");
            }
        }

        private void btn_alta_materia_Click(object sender, EventArgs e)
        {
            var form = new Formularios.FormularioMateria(new Materia(), materiaBLL);
            form.MateriaAgregada += (o, s) => RefrescarGrillaMaterias();
            form.Show(this);
        }

        private void btn_baja_materia_Click(object sender, EventArgs e)
        {
            try
            {
                Materia materia;
                try
                {
                    materia = grillaMateria.SelectedRows[0].DataBoundItem as Materia;
                }
                catch (Exception)
                {

                    throw new Exception("Debe eliminar una materia");
                }
                materiaBLL.EliminarMateria(materia);
                RefrescarGrillaMaterias();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message);
            }
        }

        private void btn_modificacion_materia_Click(object sender, EventArgs e)
        {
            try
            {
                Materia materia;
                try
                {
                    materia = grillaMateria.SelectedRows[0].DataBoundItem as Materia;
                }
                catch (Exception)
                {

                    throw new Exception("Debe modificar una materia");
                }
                var form = new Formularios.FormularioMateria(materia, materiaBLL);
                form.MateriaAgregada += (o, s) => RefrescarGrillaMaterias();
                form.Show(this);


            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message);
            }
        }

        private void grillaEstudiante_SelectionChanged(object sender, EventArgs e)
        {
            RefrescarGrillaMateriasPorEstudiante();
        }

        private void btn_materias_por_estudiante_Click(object sender, EventArgs e)
        {
            try
            {
                Materia materia = null;
                Estudiante estudiante = null;

                try
                {
                    materia = grillaMateria.SelectedRows[0].DataBoundItem as Materia;
                }
                catch (Exception)
                {
                    throw new InvalidOperationException("Debe de seleccionar una materia.");
                }

                try
                {
                    estudiante = grillaEstudiante.SelectedRows[0].DataBoundItem as Estudiante;
                }
                catch (Exception)
                {
                    throw new InvalidOperationException("Debe de seleccionar un estudiante");
                }

                estudianteBLL.AsociarEstudianteMateria(estudiante, materia);
                RefrescarGrillaEstudiantes();
                RefrescarGrillaMateriasPorEstudiante();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error asociando materia con el estudiante");
            }
        }

        private void btn_nota_Click(object sender, EventArgs e)
        {
            try
            {

                MateriaPorEstudiante materiaPorEstudiante = null;

                int calificacion;

                try
                {
                    calificacion = Convert.ToInt32(cbo_nota.SelectedItem);
                }
                catch
                {
                    throw new InvalidOperationException("Debe seleccionar una calificacion");
                }

                try
                {
                    materiaPorEstudiante = grillaMateriaPorEstudiante.SelectedRows[0].DataBoundItem as MateriaPorEstudiante;
                }
                catch
                {
                    throw new InvalidOperationException("Debe de seleccionar una materia de un estudiante");
                }

                estudianteBLL.CalificarMateria(materiaPorEstudiante, calificacion);
                RefrescarGrillaMateriasPorEstudiante();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calificando materia del estudiante");
            }
        }

        private void btn_eliminar_materia_por_estudiante_Click(object sender, EventArgs e)
        {
            try
            {

                MateriaPorEstudiante materiaPorEstudiante = null;

                try
                {
                    materiaPorEstudiante = grillaMateriaPorEstudiante.SelectedRows[0].DataBoundItem as MateriaPorEstudiante;
                }
                catch
                {
                    throw new InvalidOperationException("Debe de seleccionar una materia de un estudiante");
                }

                estudianteBLL.EliminarMateriaAsociada(materiaPorEstudiante);
                RefrescarGrillaEstudiantes();
                RefrescarGrillaMateriasPorEstudiante();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error eliminando materia asociada con estudiante");
            }
        }

        private void btnLeerXmlAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog ();
                ofd.Filter = "XML - File | *.xml";
                ofd.FileOk += (o, s) =>
                {
                    try
                    {
                        string filename = ((OpenFileDialog)o).FileName;
                        XmlBLL xmlBLL = new XmlBLL(filename);
                        XmlViewModel viewModel = xmlBLL.LeerXml<XmlViewModel>();

                        MessageBox.Show($"Cantidad de Estudiantes: {viewModel.Estudiantes.Count()}\n\nListado por nombres:\n {string.Join("\n", viewModel.Estudiantes.Select(est => est.Nombre + " " + est.Apellido))}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error leeyendo datos en el xml.");
                    }
                };
                ofd.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio error leeyendo XML del estudiante");
            }
        }
    }
}
