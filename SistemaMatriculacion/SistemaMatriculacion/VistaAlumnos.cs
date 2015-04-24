using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.SistemaMatriculacion.Controlador;
using com.SistemaMatriculacion.Entidades;
using com.SistemaMatriculacion.Modelos;

namespace com.SistemaMatriculacion.Vistas
{
    public partial class VistaMatriculacion : Form
    {

        private string id;
        private ControladorAlumnos controladorAlumnos;
        private EntidadDireccion entidadDireccion;
        private EntidadAlumnos entidadAlumnos;

        public VistaMatriculacion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void menuNuevo_Click(object sender, EventArgs e)
        {
           
            if (menuNuevo.Text.Equals("Nuevo"))
            {
                menuNuevo.Text = "Cancel";
                //txtAnio.Enabled = true;
                txtApellidos.Enabled = true;
                txtDateTime.Enabled = true;
                //txtd.Enabled = true;
                txtDireccion.Enabled = true;
                txtEstado.Enabled = true;
                //txtMes.Enabled = true;
                txtNombre.Enabled = true;
                txtPais.Enabled = true;
                txtPassword.Enabled = true;
                radioFemale.Enabled = true;
                radioMasculino.Enabled = true;
                //txtCarrera.Enabled = true;


            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entidadDireccion = new EntidadDireccion();
            entidadDireccion.direccion = txtDireccion.Text;
            entidadDireccion.estado = txtEstado.Text;
            entidadDireccion.pais = txtPais.Text;

            entidadAlumnos = new EntidadAlumnos();
            entidadAlumnos.apellidos = txtApellidos.Text;
            entidadAlumnos.carrera = txtCarrera.Text;
            entidadAlumnos.direccion = entidadDireccion;

            MessageBox.Show(cbCarreras.ToString());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            /*
            if (id != null || !id.Equals(""))
            {
                controladorMatriculacion = new ControladorMatriculacion();
                if (controladorMatriculacion.eliminar(Convert.ToInt32(id)))
                {
                    controladorMatriculacion.leer(tablaMatriculacion);
                }
            }
             * 
             * */
        }
    }
}
