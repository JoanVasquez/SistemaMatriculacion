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
    public partial class VistaRegistrarse : Form
    {
        private EntidadAdmin entidadAdmin = new EntidadAdmin();
        private ControladorAdmin controladorAdmin = new ControladorAdmin();
        private int id;
        private VistaLogin vistaLogin;


        public VistaRegistrarse()
        {
            InitializeComponent();
        }

        private void VistaAdmin_Load(object sender, EventArgs e)
        {
            tablaUsuarios.AutoGenerateColumns = false;
            tablaUsuarios.DataSource = typeof(List<EntidadAdmin>);
            tablaUsuarios.DataSource = controladorAdmin.leerAdminInterface();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtPass.Text))
            {
                entidadAdmin.Email = txtEmail.Text;
                entidadAdmin.Pass = txtPass.Text;

                if (isValidEmail(txtEmail.Text.ToString()))
                {
                    if (controladorAdmin.insertarAdminInterface(entidadAdmin))
                    {
                        tablaUsuarios.DataSource = typeof(List<EntidadAdmin>);
                        tablaUsuarios.DataSource = controladorAdmin.leerAdminInterface();
                        MessageBox.Show("Carrera insertada");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar el usuario");
                    }
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtPass.Text) && id > 0)
            {

                entidadAdmin.Id = id;
                entidadAdmin.Email = txtEmail.Text;
                entidadAdmin.Pass = txtPass.Text;

                if (isValidEmail(txtEmail.Text.ToString()))
                {
                    if (controladorAdmin.actualizarAdminInterface(entidadAdmin))
                    {
                        tablaUsuarios.DataSource = typeof(List<EntidadAdmin>);
                        tablaUsuarios.DataSource = controladorAdmin.leerAdminInterface();
                        MessageBox.Show("Usuario actualizado");
                    }
                    else
                    {
                        MessageBox.Show("Usuario no actualizado");
                    }
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
                if (controladorAdmin.eliminarAdminInterface(id))
                {
                    tablaUsuarios.DataSource = typeof(List<EntidadAdmin>);
                    tablaUsuarios.DataSource = controladorAdmin.leerAdminInterface();
                    MessageBox.Show("Usuario eliminado");
                }
                else
                {
                    MessageBox.Show("Usuario no eliminado");
                }
            }
            else
            {
                MessageBox.Show("Seleccione el campo a eliminar");
            }
        }

        private void tablaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tablaUsuarios.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells[0].Value.ToString());
                txtEmail.Text = row.Cells[1].Value.ToString();
                txtPass.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            vistaLogin = new VistaLogin();
            this.Hide();
            vistaLogin.ShowDialog();
            this.Close();
        }

        private bool isValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email no valido");
            }
            return false;
        }
    }
}
