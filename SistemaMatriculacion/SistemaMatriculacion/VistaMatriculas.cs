using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.SistemaMatriculacion.Modelos;
using com.SistemaMatriculacion.Controlador;
using com.SistemaMatriculacion.Entidades;

namespace com.SistemaMatriculacion.Vistas
{
    public partial class VistaMatriculas : Form
    {
        ControladorMatriculas controladorMatricula = new ControladorMatriculas();
        EntidadMatricula entidadMatricula = new EntidadMatricula();
        private String id;
        public VistaMatriculas()
        {
            InitializeComponent();
        }

        private void VistaMatriculas_Load(object sender, EventArgs e)
        {
            if (controladorMatricula.Secuencia() != -1)
            {
                txtSecuencia.Text = "0";
                controladorMatricula.leeMatriculas(tablaMatriculas);
            }
            else
            {
                txtSecuencia.Text = controladorMatricula.Secuencia().ToString();
            }
        }

        private void btnGenera_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAnio.Text) || !string.IsNullOrWhiteSpace(txtDia.Text) || !string.IsNullOrWhiteSpace(txtMes.Text))
            {
                entidadMatricula.matricula = txtDia.Text + txtMes.Text + txtAnio.Text + txtSecuencia.Text;
                controladorMatricula.insetarMatricula(entidadMatricula);
                controladorMatricula.leeMatriculas(tablaMatriculas);
            }
        }

        private void tablaMatriculas_MouseClick(object sender, MouseEventArgs e)
        {
            int rowindex = tablaMatriculas.CurrentCell.RowIndex;
            id = tablaMatriculas.Rows[rowindex].Cells["Id"].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id != null || !id.Equals(""))
            {
                controladorMatricula.eliminarMatricula(Convert.ToInt32(id));
                controladorMatricula.leeMatriculas(tablaMatriculas);
            }
        }
    }
}
