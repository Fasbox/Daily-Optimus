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

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (listBoxTareas.SelectedItems.Count > -1)
                listBoxTareas.Items[listBoxTareas.SelectedIndex] = richTextBoxTarea.Text;
            else
                MessageBox.Show("Selecciona la tarea que deseas borrar");

            richTextBoxTarea.Clear();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            listBoxTareas.Items.Add(richTextBoxTarea.Text);
            richTextBoxTarea.Text = "";

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            listBoxTareas.Items.RemoveAt(listBoxTareas.SelectedIndex);
        }
    }
}
