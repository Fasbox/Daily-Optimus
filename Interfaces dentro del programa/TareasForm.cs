using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class TareasForm : Form
    {
        public TareasForm()
        {
            InitializeComponent();
        }

        private void TareasForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Tenemos una lista de objetos en listbox, esta lista tiene indices, esos indices los llamamos en este método para modificarlos,
        /// sino hay nada seleccionado tira el mensaje de error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (listBoxTareas.SelectedItems.Count > -1)
                listBoxTareas.Items[listBoxTareas.SelectedIndex] = richTextBoxTarea.Text;
            else
                MessageBox.Show("Selecciona la tarea que deseas borrar");

            richTextBoxTarea.Clear();
        }

        /// <summary>
        /// Agrega lo que esté dentro del textbox en la lista de listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            listBoxTareas.Items.Add(richTextBoxTarea.Text);
            richTextBoxTarea.Text = "";

        }

        /// <summary>
        /// Elimina en el ínidice indicado la tarea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            listBoxTareas.Items.RemoveAt(listBoxTareas.SelectedIndex);
        }
    }
}
