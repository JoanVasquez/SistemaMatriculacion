using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.SistemaMatriculacion.Entidades;
using com.SistemaMatriculacion.Controlador;


namespace com.SistemaMatriculacion.Vistas
{
    public partial class VistaDireccion : Form
    {
        private ControladorDireccion controladorDireccion = new ControladorDireccion();
        private EntidadDireccion entidadDireccion = new EntidadDireccion();
        private int id;
        private string direccion, estado, pais;

        public delegate void datos(int id, string direccion, string estado, string pais);
        public event datos pasar;

        public VistaDireccion()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDireccion.Text))
            {

                entidadDireccion.Direccion = txtDireccion.Text;
                entidadDireccion.Estado = txtEstado.Text;
                entidadDireccion.Pais = txtPais.Text;

                if (controladorDireccion.insertarDireccionInterface(entidadDireccion))
                {
                    tablaDireccion.DataSource = typeof(List<EntidadDireccion>);
                    tablaDireccion.DataSource = controladorDireccion.leerTodosDireccionInterface();
                    MessageBox.Show("Direccion insertada");
                    txtDireccion.Text = "";
                    txtEstado.Text = "";
                    txtPais.Text = "";
                }
                else
                {
                    MessageBox.Show("Direccion no insertada");
                }
            }
            else
            {
                MessageBox.Show("No puedes tener campos");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDireccion.Text) && !string.IsNullOrWhiteSpace(txtEstado.Text) && !string.IsNullOrWhiteSpace(txtPais.Text) && id > 0)
            {

                entidadDireccion.Direccion = txtDireccion.Text;
                entidadDireccion.Estado = txtEstado.Text;
                entidadDireccion.Pais = txtPais.Text;

                if (controladorDireccion.actualizarDireccionInterface(entidadDireccion, id))
                {
                    tablaDireccion.DataSource = typeof(List<EntidadDireccion>);
                    tablaDireccion.DataSource = controladorDireccion.leerTodosDireccionInterface();
                    MessageBox.Show("Direccion actualizada");
                    txtDireccion.Text = "";
                    txtEstado.Text = "";
                    txtPais.Text = "";
                }
                else
                {
                    MessageBox.Show("Direccion no actualizada");
                }
            }
            else
            {
                MessageBox.Show("Seleccione el campo a actualizar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {

                if (controladorDireccion.eliminarDireccionInterface(id))
                {
                    tablaDireccion.DataSource = typeof(List<EntidadDireccion>);
                    tablaDireccion.DataSource = controladorDireccion.leerTodosDireccionInterface();
                    MessageBox.Show("Direccion eliminada");
                    txtDireccion.Text = "";
                    txtEstado.Text = "";
                    txtPais.Text = "";
                }
                else
                {
                    MessageBox.Show("Direccion no eliminada");
                }
            }
            else
            {
                MessageBox.Show("Seleccione el campo a eliminar");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if ((id != 0 && !direccion.Equals("")) && (direccion.Equals(txtDireccion.Text)))
            {
                pasar(id, direccion, estado, pais);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Compruebe que ha seleccionado una direccion de la tabla y no ha sido escrita manualmente");
            }
        }

        private void VistaDireccion_Load(object sender, EventArgs e)
        {
            tablaDireccion.AutoGenerateColumns = false;
            tablaDireccion.DataSource = typeof(List<EntidadDireccion>);
            tablaDireccion.DataSource = controladorDireccion.leerTodosDireccionInterface();
        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && !char.IsControl(ch) && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && !char.IsControl(ch) && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void tablaDireccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = tablaDireccion.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells[0].Value.ToString());
                direccion = row.Cells[1].Value.ToString();
                estado = row.Cells[2].Value.ToString();
                pais = row.Cells[3].Value.ToString();

                txtDireccion.Text = row.Cells[1].Value.ToString();
                txtEstado.Text = row.Cells[2].Value.ToString();
                txtPais.Text = row.Cells[3].Value.ToString();

            }
        }

    }
}
