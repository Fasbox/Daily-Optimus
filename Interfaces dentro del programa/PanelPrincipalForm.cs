using System.Runtime.InteropServices;

namespace TrackerUI
{
    public partial class PanelPrincipalForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );

        public PanelPrincipalForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panelNav.Height = buttonPanelEjecutables.Height;
            panelNav.Top = buttonPanelEjecutables.Top;
            panelNav.Left = buttonPanelEjecutables.Left;
            buttonPanelEjecutables.BackColor = Color.FromArgb(46, 131, 242);
        }

        public void cargar_Form(object Form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_MouseHover(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.FromArgb(184, 15, 10);
        }

        private void buttonClose_Leave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.FromArgb(75, 148, 242);
        }

        int mouseX = 0;
        int mouseY = 0;
        int mouseinX = 0;
        int mouseinY = 0;
        bool mouseDown;
        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;

            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void headerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPanelEjecutables_Click(object sender, EventArgs e)
        {
            panelNav.Height = buttonPanelEjecutables.Height;
            panelNav.Top = buttonPanelEjecutables.Top;
            panelNav.Left = buttonPanelEjecutables.Left;
            buttonPanelEjecutables.BackColor = Color.FromArgb(46, 131, 242);

            cargar_Form(new EjecutablesForm());
        }

        private void buttonPanelTareas_Click(object sender, EventArgs e)
        {
            panelNav.Height = buttonPanelTareas.Height;
            panelNav.Top = buttonPanelTareas.Top;
            panelNav.Left = buttonPanelTareas.Left;
            buttonPanelTareas.BackColor = Color.FromArgb(46, 131, 242);

            cargar_Form(new TareasForm());
        }

        private void buttonPanelNoticias_Click(object sender, EventArgs e)
        {
            panelNav.Height = buttonPanelNoticias.Height;
            panelNav.Top = buttonPanelNoticias.Top;
            panelNav.Left = buttonPanelNoticias.Left;
            buttonPanelNoticias.BackColor = Color.FromArgb(46, 131, 242);

            cargar_Form(new NoticiasForm());
        }

        private void buttonPanelEjecutables_Leave(object sender, EventArgs e)
        {
            buttonPanelEjecutables.BackColor = Color.FromArgb(75, 148, 242);
        }

        private void buttonPanelTareas_Leave(object sender, EventArgs e)
        {
            buttonPanelTareas.BackColor = Color.FromArgb(75, 148, 242);
        }

        private void buttonPanelNoticias_Leave(object sender, EventArgs e)
        {
            buttonPanelNoticias.BackColor = Color.FromArgb(75, 148, 242);
        }


    }
}