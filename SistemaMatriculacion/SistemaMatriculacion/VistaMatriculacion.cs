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
using System.Text.RegularExpressions;
using com.SistemaMatriculacion.Vistas;

namespace com.SistemaMatriculacion.Vistas
{
    public partial class VistaMatriculacion : Form
    {

        private int alumno_Id, direccion_Id, carrera_Id, selectedRow, sec;

        private ControladorAlumno controladorAlumno = new ControladorAlumno();
        private ControladorCarrera controladorCarrera = new ControladorCarrera();
        private ControladorDireccion controladorDireccion = new ControladorDireccion();

        private EntidadAlumno entidadAlumno = new EntidadAlumno();
        private EntidadCarrera entidadCarrera = new EntidadCarrera();
        private EntidadDireccion entidadDireccion = new EntidadDireccion();
        private VistaReporte vistaReporte;

        public VistaMatriculacion()
        {
            InitializeComponent();

        }

        private void getDireccion(int id, string direccion, string estado, string pais)
        {
            this.direccion_Id = id;
            this.txtDireccion.Text = direccion;
            this.txtEstado.Text = estado;
            this.txtPais.Text = pais;
        }

        private void getCarrera(int id, string carrera)
        {
            this.carrera_Id = id;
            this.txtCarrera.Text = carrera;
        }



        private void btnCarreras_Click(object sender, EventArgs e)
        {
            VistaCarrera vistaCarrera = new VistaCarrera();
            vistaCarrera.pasar += new VistaCarrera.datos(getCarrera);
            vistaCarrera.ShowDialog();
        }

        private void btnDireccion_Click(object sender, EventArgs e)
        {
            VistaDireccion vistaDireccion = new VistaDireccion();
            vistaDireccion.pasar += new VistaDireccion.datos(getDireccion);
            vistaDireccion.ShowDialog();
        }

        private void menuGuardar_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(txtNombre.Text)
                && !string.IsNullOrWhiteSpace(txtAnio.Text)
                && !string.IsNullOrWhiteSpace(txtApellidos.Text)
                && !string.IsNullOrWhiteSpace(txtDateTime.ToString())
                && !string.IsNullOrWhiteSpace(txtCarrera.Text)
                && !string.IsNullOrWhiteSpace(txtDia.Text)
                && !string.IsNullOrWhiteSpace(txtDireccion.Text)
                && !string.IsNullOrWhiteSpace(txtMes.Text)
                && !string.IsNullOrWhiteSpace(txtNombre.Text)
                && !string.IsNullOrWhiteSpace(txtPassword.Text)
                && !string.IsNullOrWhiteSpace(txtEstado.Text)
                && !string.IsNullOrWhiteSpace(txtPais.Text))
            {

                sec = controladorAlumno.lastIdAlumnosInterface();

                entidadAlumno.Nombre = txtNombre.Text;
                entidadAlumno.Apellidos = txtApellidos.Text;
                entidadAlumno.FechaNacimiento = Convert.ToDateTime(txtDateTime.Text);
                entidadAlumno.Matricula = Convert.ToInt32(txtDia.Text.ToString() + txtMes.Text.ToString() + txtAnio.Text.ToString() + sec.ToString());
                entidadAlumno.Contrasena = txtPassword.Text;
                entidadAlumno.Ciclo = txtDia.Text + "-" + txtMes.Text + "-" + txtAnio.Text;

                entidadCarrera.Id = carrera_Id;
                entidadAlumno.Carrera = entidadCarrera;

                entidadDireccion.Id = direccion_Id;
                entidadAlumno.Direccion = entidadDireccion;

                var confirmResult = MessageBox.Show("Esta seguro de la informacion? ", "Confirmar aceptar", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {

                    if (controladorAlumno.insertarAlumnosInterface(entidadAlumno))
                    {
                        tablaAlumnos.Rows.Clear();
                        fillTablaMatriculacion();

                        txtAnio.Text = "";
                        txtApellidos.Text = "";
                        txtCarrera.Text = "";
                        txtDia.Text = "";
                        txtDireccion.Text = "";
                        txtEstado.Text = "";
                        txtMes.Text = "";
                        txtNombre.Text = "";
                        txtPais.Text = "";
                        txtPassword.Text = "";
                        carrera_Id = 0;
                        direccion_Id = 0;
                        alumno_Id = 0;

                        MessageBox.Show("Insertado");
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("No puedes tener campos vacio");
            }
                

        }


        private void VistaMatriculacion_Load(object sender, EventArgs e)
        {

            tablaAlumnos.AutoGenerateColumns = false;
            fillTablaMatriculacion();

        }

        private void fillTablaMatriculacion()
        {

            foreach (EntidadAlumno entidadAlumno in controladorAlumno.leerAlumnosInterface())
            {
                tablaAlumnos.Rows.Add(entidadAlumno.Id.ToString(), entidadAlumno.Nombre.ToString(),
                entidadAlumno.Apellidos.ToString(), entidadAlumno.FechaNacimiento.ToString(), entidadAlumno.Matricula.ToString(), entidadAlumno.Contrasena.ToString(),
                entidadAlumno.Ciclo.ToString(), entidadAlumno.Carrera.Nombre.ToString(), entidadAlumno.Direccion.Estado.ToString(), entidadAlumno.Direccion.Pais.ToString(),
                entidadAlumno.Direccion.Direccion.ToString());
            }
        }


        private void menuEliminar_Click(object sender, EventArgs e)
        {
            if (tablaAlumnos.Rows.Count > 0 && alumno_Id > 0)
            {

                 var confirmResult = MessageBox.Show("Estas seguro de eliminarlo? ", "Confirmar aceptar", MessageBoxButtons.YesNo);

                 if (confirmResult == DialogResult.Yes)
                 {


                     if (controladorAlumno.eliminarAlumnosInterface(alumno_Id))
                     {
                         MessageBox.Show("Eliminada");

                         tablaAlumnos.Rows.Clear();
                         fillTablaMatriculacion();

                         txtAnio.Text = "";
                         txtApellidos.Text = "";
                         txtCarrera.Text = "";
                         txtDia.Text = "";
                         txtDireccion.Text = "";
                         txtEstado.Text = "";
                         txtMes.Text = "";
                         txtNombre.Text = "";
                         txtPais.Text = "";
                         txtPassword.Text = "";
                         carrera_Id = 0;
                         direccion_Id = 0;
                         alumno_Id = 0;

                     }
                 }
                 else
                 {
                     return;
                 }

            }else
                {
                    MessageBox.Show("Selecciona una fila");
                }
            

        }

        private void menuEditar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtNombre.Text)
                && !string.IsNullOrWhiteSpace(txtAnio.Text)
                && !string.IsNullOrWhiteSpace(txtApellidos.Text)
                && !string.IsNullOrWhiteSpace(txtDateTime.ToString())
                && !string.IsNullOrWhiteSpace(txtCarrera.Text)
                && !string.IsNullOrWhiteSpace(txtDia.Text)
                && !string.IsNullOrWhiteSpace(txtDireccion.Text)
                && !string.IsNullOrWhiteSpace(txtMes.Text)
                && !string.IsNullOrWhiteSpace(txtNombre.Text)
                && !string.IsNullOrWhiteSpace(txtPassword.Text)
                && !string.IsNullOrWhiteSpace(txtEstado.Text)
                && !string.IsNullOrWhiteSpace(txtPais.Text)
                && alumno_Id != 0
                && carrera_Id != 0)
            {

                if (tablaAlumnos.Rows.Count > 0 && alumno_Id > 0)
                {
                    sec = controladorAlumno.lastIdAlumnosInterface();

                    entidadAlumno.Id = alumno_Id;
                    entidadAlumno.Nombre = txtNombre.Text;
                    entidadAlumno.Apellidos = txtApellidos.Text;
                    entidadAlumno.FechaNacimiento = Convert.ToDateTime(txtDateTime.Text);
                    entidadAlumno.Matricula = Convert.ToInt32(txtDia.Text.ToString() + txtMes.Text.ToString() + txtAnio.Text.ToString() + sec.ToString());
                    entidadAlumno.Contrasena = txtPassword.Text;
                    entidadAlumno.Ciclo = txtDia.Text + "-" + txtMes.Text + "-" + txtAnio.Text;

                    entidadCarrera.Id = carrera_Id;
                    entidadAlumno.Carrera = entidadCarrera;

                    entidadDireccion.Id = direccion_Id;
                    entidadAlumno.Direccion = entidadDireccion;

                     var confirmResult = MessageBox.Show("Esta seguro de la informacion? ", "Confirmar aceptar", MessageBoxButtons.YesNo);

                     if (confirmResult == DialogResult.Yes)
                     {

                         if (controladorAlumno.actualizarAlumnosInterface(entidadAlumno))
                         {

                             tablaAlumnos.Rows.Clear();
                             fillTablaMatriculacion();

                             txtAnio.Text = "";
                             txtApellidos.Text = "";
                             txtCarrera.Text = "";
                             txtDia.Text = "";
                             txtDireccion.Text = "";
                             txtEstado.Text = "";
                             txtMes.Text = "";
                             txtNombre.Text = "";
                             txtPais.Text = "";
                             txtPassword.Text = "";
                             carrera_Id = 0;
                             direccion_Id = 0;
                             alumno_Id = 0;

                         }
                     }
                     else
                     {
                         return;
                     }
                }
                

             
            }
            else
            {
                MessageBox.Show("No puedes tener campos vacio");
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

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && !char.IsControl(ch) && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
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

        private void txtCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && !char.IsControl(ch) && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void txtDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && !char.IsControl(ch) )
            {
                e.Handled = true;
            }
        }

        private void txtMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && !char.IsControl(ch))
            {
                e.Handled = true;
            }
        }

        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && !char.IsControl(ch))
            {
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tablaAlumnos.Rows.Clear();
            fillTablaMatriculacion();

            txtAnio.Text = "";
            txtApellidos.Text = "";
            txtCarrera.Text = "";
            txtDia.Text = "";
            txtDireccion.Text = "";
            txtEstado.Text = "";
            txtMes.Text = "";
            txtNombre.Text = "";
            txtPais.Text = "";
            txtPassword.Text = "";
            carrera_Id = 0;
            direccion_Id = 0;
            alumno_Id = 0;

        }

        private void tablaAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {

                DataGridViewRow row = tablaAlumnos.Rows[e.RowIndex];
                alumno_Id = Convert.ToInt32(row.Cells[0].Value.ToString());
                txtNombre.Text = row.Cells[1].Value.ToString();
                txtApellidos.Text = row.Cells[2].Value.ToString();
                txtDateTime.Text = row.Cells[3].Value.ToString();
                //txtEstado.Text = row.Cells[8].Value.ToString();
                //txtPais.Text = row.Cells[9].Value.ToString();
                txtPassword.Text = row.Cells[5].Value.ToString();
                //txtCarrera.Text = row.Cells[7].Value.ToString();
                //txtDireccion.Text = row.Cells[10].Value.ToString();
                string ciclo = row.Cells[6].Value.ToString();
                int dia, mes, anios;
                string[] numbers = Regex.Split(ciclo, @"\D+");
                dia = Convert.ToInt32(numbers[0].ToString());
                mes = Convert.ToInt32(numbers[1].ToString());
                anios = Convert.ToInt32(numbers[2].ToString());
                txtDia.Text = dia.ToString();
                txtMes.Text = mes.ToString();
                txtAnio.Text = anios.ToString();

                entidadDireccion.Direccion = txtDireccion.Text;
                direccion_Id = controladorDireccion.encontrarDireccionPorIdInterface(entidadDireccion);

                selectedRow = tablaAlumnos.CurrentCell.RowIndex;

                entidadCarrera.Nombre = txtCarrera.Text;
                carrera_Id = controladorCarrera.encontrarCarreraPorIdInterface(entidadCarrera);
               
            }
        }


        private void btnReporte_Click(object sender, EventArgs e)
        {
            vistaReporte = new VistaReporte();
            vistaReporte.Show();
        }

    }
}
