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

namespace com.SistemaMatriculacion.Vistas
{
    public partial class VistaCarrera : Form
    {
        private EntidadCarrera entidadCarrera = new EntidadCarrera();
        private ControladorCarrera carreraControlador = new ControladorCarrera();
        private int id;
        private string carrera;
        
        public delegate void datos(int id, string carrera);
        public event datos pasar;
       
        
        public VistaCarrera()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                entidadCarrera.Nombre = txtNombre.Text;

                if (carreraControlador.insertarCarreraInterface(entidadCarrera))
                {
                    tablaCarreras.DataSource = typeof(List<EntidadCarrera>);
                    tablaCarreras.DataSource = carreraControlador.leerTodasCarrerasInterface();
                    MessageBox.Show("Carrera insertada");
                }
                else
                {
                    MessageBox.Show("No se pudo insertar la carrera");
                }
            }
            else
            {
                MessageBox.Show("No puedes tener campos");
            }
        }

        private void VistaCarrera_Load(object sender, EventArgs e)
        {
            tablaCarreras.AutoGenerateColumns = false;
            tablaCarreras.DataSource = typeof(List<EntidadCarrera>);
            tablaCarreras.DataSource = carreraControlador.leerTodasCarrerasInterface();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && id > 0)
            {
                entidadCarrera.Nombre = txtNombre.Text;
                if (carreraControlador.actualizarCarreraInterface(entidadCarrera, id))
                {
                    tablaCarreras.DataSource = typeof(List<EntidadCarrera>);
                    tablaCarreras.DataSource = carreraControlador.leerTodasCarrerasInterface();
                    MessageBox.Show("Carrera actualizada");
                }
                else
                {
                    MessageBox.Show("Carrera no actualizada");
                }
            }
            else
            {
                MessageBox.Show("Seleccione el campo a actualizar");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                if (carreraControlador.eliminarCarreraInterface(id))
                {
                    tablaCarreras.DataSource = typeof(List<EntidadCarrera>);
                    tablaCarreras.DataSource = carreraControlador.leerTodasCarrerasInterface();
                    MessageBox.Show("Carrera eliminada");
                }
                else
                {
                    MessageBox.Show("Carrera no eliminada");
                }
            }
            else
            {
                MessageBox.Show("Seleccione el campo a eliminar");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && !char.IsControl(ch) && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if ((id != 0 && !carrera.Equals("")) && (carrera.Equals(txtNombre.Text)))
            {
                pasar(id, carrera);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Compruebe que ha seleccionado una direccion de la tabla y no ha sido escrita manualmente");
            }
        }

        private void tablaCarreras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tablaCarreras.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells[0].Value.ToString());
                carrera = row.Cells[1].Value.ToString();
                txtNombre.Text = row.Cells[1].Value.ToString();
            }
        }
        
    }
}
