using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using TrackerUI.DataBase;

namespace TrackerUI.Interfaces_Inicio_de_Sesión
{
    public partial class InicioSesionForm : Form
    {
        /// <summary>
        /// Llama a la base de datos
        /// </summary>
        private ClientDatabaseService _ClientDatabaseService;
        public InicioSesionForm()
        {
            InitializeComponent();
            _ClientDatabaseService = new ClientDatabaseService();
        }

        /// <summary>
        /// Revisa que los campos llenados si sean los que se pidiieron y llama los métodos de la base de datos para buscar
        /// el usuario ingresado y que si tenga la contraseña bien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            string contraseña = textBoxContraseña.Text;
            string nickName = textBoxUsername.Text;
            if (nickName != "" && contraseña != "")
            {
                if (_ClientDatabaseService.LoggedUserExist(nickName))
                {
                    LoggedUser usuario = _ClientDatabaseService.ObtenerloggedUser(contraseña, nickName);
                    if (usuario != null)
                    {
                        new PanelPrincipalForm().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("contraseña incorrecta, intétalo de nuevo", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxContraseña.Text = "";
                        textBoxContraseña.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Username  incorrecto, intétalo de nuevo", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxUsername.Text = "";
                    textBoxUsername.Focus();
                }

            }
            else
            {
                MessageBox.Show("Username o contraseña no pueden estar vacias, intétalo de nuevo", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxContraseña.Focus();
            }

        }

        /// <summary>
        /// Manda al usuario a la interfaz de registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonIrAlRegistro_Click(object sender, EventArgs e)
        {
            new RegistroFrom().Show();
            this.Hide();
        }

        /// <summary>
        /// Cierra la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        /// <summary>
        /// Casilla marcada para mostrar las contraseñas ingresadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrarContraseña.Checked)
            {
                textBoxContraseña.PasswordChar = '\0';
            }
            else
            {
                textBoxContraseña.PasswordChar = '•';
            }
        }
    }
}
