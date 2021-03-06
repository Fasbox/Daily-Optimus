using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using TrackerUI.DataBase;
using System.Text.RegularExpressions;

namespace TrackerUI.Interfaces_Inicio_de_Sesión
{
    public partial class RegistroFrom : Form
    {
        /// <summary>
        /// Llama a la base de datos
        /// </summary>
        private ClientDatabaseService _ClientDatabaseService;
        public RegistroFrom()
        {
            InitializeComponent();
            _ClientDatabaseService = new ClientDatabaseService();
        }

        /// <summary>
        /// Toma los datos ingresados en los textbox, verifica que no hayan campos vacíos, y si todo está
        /// correctamente ingresado llama a la propiedad de la base de datos para ingresarlos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsername.Text;
            string contraseña = textBoxContraseña.Text;
            string email = textBoxEmail.Text;
            if (usuario == "" || contraseña == "" || textBoxRepetirContraseña.Text == "")
            {
                MessageBox.Show("Los campos de usuario y/o contraseña están vacíos", "LLena todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (contraseña == textBoxRepetirContraseña.Text)
            {

                textBoxUsername.Text = "";
                textBoxEmail.Text = "";
                textBoxContraseña.Text = "";
                textBoxRepetirContraseña.Text = "";
                if (_ClientDatabaseService.LoggedUserExist(usuario))
                {
                    MessageBox.Show("El nombre de usario ya existe, por favor ingrese un nombre diferente ", "Usuario ya existe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxUsername.Text = "";
                    textBoxContraseña.Focus();
                }
                else
                {
                    LoggedUser nuevoUsuario = new LoggedUser() { UserName = usuario, Email = email, Password = contraseña};
                    _ClientDatabaseService.insertLoggedUser(nuevoUsuario);
                    MessageBox.Show("Se ha creado correctamente tu cuenta", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas ingresadas no son las mismas, por favor vuelva a ingresarlas", "Contraseñas diferentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxContraseña.Text = "";
                textBoxRepetirContraseña.Text = "";
                textBoxContraseña.Focus();
            }
        }

        /// <summary>
        /// Método para mostrar lo ingresado en el textbox de contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrarContraseña.Checked)
            {
                textBoxContraseña.PasswordChar = '\0';
                textBoxRepetirContraseña.PasswordChar = '\0';
            }
            else
            {
                textBoxContraseña.PasswordChar = '•';
                textBoxRepetirContraseña.PasswordChar = '•';
            }
        }

        /// <summary>
        /// Salir de la aplicación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

       /// <summary>
       /// Método para devolverse a la interfaz de inicio de sesión
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void buttonVolverAlInicio_Click(object sender, EventArgs e)
        {
            new InicioSesionForm().Show();
            this.Hide();
        }

        /// <summary>
        /// Verificar que lo ingresado en el campo de email, si sea un email.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            string patternEmail = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            if(Regex.IsMatch(textBoxEmail.Text, patternEmail))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.textBoxEmail, "Por favor ingresa una dirección de Email valida");
                return;
            }
        }
    }
}
