using FrbaCrucero.Modelos;
using FrbaCrucero.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonIngresarCliente_Click(object sender, EventArgs e)
        {
            MenuPrincipalForm menuPrincipalForm = new MenuPrincipalForm();
            menuPrincipalForm.Show();
        }

        private void buttonIngresarAdm_Click(object sender, EventArgs e)
        {
            string valorUsuario = textBoxAdmUsario.Text;
            string valorPassword = textBoxAdmPassword.Text;

            try {

                if (String.IsNullOrEmpty(valorUsuario) || String.IsNullOrWhiteSpace(valorUsuario)
                || String.IsNullOrEmpty(valorPassword) || String.IsNullOrEmpty(valorPassword))
                {
                    throw new Exception("Usuario o password incorrecto\n");
                }

                Usuario usuario = RepoUsuario.instancia.EncontrarPorUserName(valorUsuario);
                
                validarLogin(usuario, valorPassword);
                usuario.LoginExitoso();

                Dictionary<string,object> param = new Dictionary<string,object>();
                param.Add("intentos_fallidos", usuario.intentosFallidos);
                param.Add("habilitado", usuario.habilitado);
                RepoUsuario.instancia.Modificar(usuario.id, param);

                Rol rol = RepoRol.instancia.EncontrarPorUsuario(usuario);
                MenuPrincipalForm menuPrincipalForm = new MenuPrincipalForm(rol);
                menuPrincipalForm.Show();

            } catch(Exception ex) {
                DialogResult dr = MessageBox.Show("El usuario al que trata de acceder no existe o no tiene los permisos necesarios.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void validarLogin(Usuario usuario, string valorPassword)
        {

            if (!usuario.EstaHabilitado())
            {
                throw new Exception("Usuario inhabilitado. Contacte a un administrador");
            }

            if (!usuario.ValidarPassword(valorPassword))
            {
                usuario.AumentarIntentoFallido();
                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("intentos_fallidos", usuario.intentosFallidos);
                param.Add("habilitado", usuario.habilitado);
                RepoUsuario.instancia.Modificar(usuario.id, param);
                throw new Exception("Password incorrecto\n");
            }
        }

    }
}
