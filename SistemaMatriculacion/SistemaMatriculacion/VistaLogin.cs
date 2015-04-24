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
    public partial class VistaLogin : Form
    {
        private EntidadAdmin entidadAdmin = new EntidadAdmin();
        private ControladorAdmin controladorAdmin = new ControladorAdmin();
        private VistaMatriculacion vistaMatriculacion;
        private VistaLoginRegistracion vistaLoginRegistracion;

        public VistaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtPass.Text))
            {
                entidadAdmin.Email = txtEmail.Text;
                entidadAdmin.Pass = txtPass.Text;

                if (isValidEmail(txtEmail.Text.ToString()))
                {
                    if (controladorAdmin.buscarAdminPorUsuaruio(entidadAdmin))
                    {
                        vistaMatriculacion = new VistaMatriculacion();

                        this.Hide();
                        vistaMatriculacion.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Usuario no registrado");
                    }
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            vistaLoginRegistracion = new VistaLoginRegistracion();

            this.Hide();
            vistaLoginRegistracion.ShowDialog();
            this.Close();
            
        }

      
        private bool isValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }catch(Exception ex){
                MessageBox.Show("Email no valido");
            }
            return false;
        }
    }
}
