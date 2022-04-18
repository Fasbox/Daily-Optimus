﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerUI.Model;

namespace TrackerUI
{
    public partial class EjecutablesForm : Form
    {
        public EjecutablesForm()
        {
            InitializeComponent();
        }

        List<Aplicaciones> datos = new List<Aplicaciones>();

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Aplicaciones ejecutable = new Aplicaciones();

            OpenFileDialog abrir = new OpenFileDialog();
            abrir.FileName = "";
            abrir.Filter = "exe |*.exe";
            if (abrir.ShowDialog() == DialogResult.OK)
            {

                string strPath = abrir.FileName;
                string filename = null;

                filename = Path.GetFileName(strPath);

                ejecutable.nombre = filename;
                ejecutable.ruta = strPath;
                datos.Add(ejecutable);
                //abrir.C = ejecutable.ruta;
            }


        }

        Panel icono = new Panel();
        Label nombre = new Label();
        Label ruta = new Label();
        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            int posX, posY;
            int ancho, alto;

            panelContener.Controls.Clear();

            ancho = (panelContener.Width / 5);
            alto = (panelContener.Height / 3);
            posX = 0;
            posY = 0;

            int cantidad = 0;
            int incrementa = 5;

            for (int i = 0; i < datos.Count; i++)
            {

                icono = new Panel();
                nombre = new Label();
                ruta = new Label();
                cantidad++;

                icono.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\Fabian\\Desktop\\TrackerUI\\Resources\\Figurepng.png");
                icono.BackgroundImageLayout = ImageLayout.Zoom;
                icono.TabIndex = i;
                icono.Size = new Size(ancho, alto);

                nombre.Text = datos[i].nombre;
                nombre.TextAlign = ContentAlignment.BottomCenter;
                nombre.BackColor = Color.Transparent;
                nombre.ForeColor = Color.White;
                nombre.TabIndex = i;

                ruta.Text = datos[i].ruta;
                ruta.ForeColor = Color.Transparent;

                icono.Controls.Add(nombre);
                nombre.Location = new Point(0, (icono.Height - nombre.Height));


                panelContener.Controls.Add(icono);
                icono.Location = new Point(posX, posY);

                if (panelContener.Controls.Count > 0)
                {
                    posX = posX + ancho;
                }

                if (cantidad == incrementa)
                {
                    incrementa = incrementa + 5;
                    posX = 0;
                    posY = posY + alto;
                }

                panelContener.DoubleClick += new EventHandler(ejecutar);
                nombre.DoubleClick += new EventHandler(ejecutar);
                icono.DoubleClick += new EventHandler(ejecutar);
            }

        }

        private void ejecutar(object sender, EventArgs e)
        {
            
            string FilePath = ruta.Text;
            Process.Start(FilePath);
        }
    }

}
