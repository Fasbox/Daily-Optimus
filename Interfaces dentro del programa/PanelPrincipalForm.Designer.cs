namespace TrackerUI
{
    partial class PanelPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPrincipalForm));
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNav = new System.Windows.Forms.Panel();
            this.buttonPanelNoticias = new System.Windows.Forms.Button();
            this.buttonPanelTareas = new System.Windows.Forms.Button();
            this.buttonPanelEjecutables = new System.Windows.Forms.Button();
            this.panelMostrarUsuario = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMostrarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(148)))), ((int)(((byte)(242)))));
            this.panelOpciones.Controls.Add(this.pictureBox1);
            this.panelOpciones.Controls.Add(this.panelNav);
            this.panelOpciones.Controls.Add(this.buttonPanelNoticias);
            this.panelOpciones.Controls.Add(this.buttonPanelTareas);
            this.panelOpciones.Controls.Add(this.buttonPanelEjecutables);
            this.panelOpciones.Controls.Add(this.panelMostrarUsuario);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpciones.Location = new System.Drawing.Point(0, 0);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(186, 577);
            this.panelOpciones.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrackerUI.Properties.Resources.logo_size_invert1;
            this.pictureBox1.Location = new System.Drawing.Point(-15, 394);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.panelNav.Location = new System.Drawing.Point(1, 218);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(10, 100);
            this.panelNav.TabIndex = 1;
            // 
            // buttonPanelNoticias
            // 
            this.buttonPanelNoticias.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanelNoticias.FlatAppearance.BorderSize = 0;
            this.buttonPanelNoticias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPanelNoticias.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPanelNoticias.ForeColor = System.Drawing.Color.White;
            this.buttonPanelNoticias.Image = ((System.Drawing.Image)(resources.GetObject("buttonPanelNoticias.Image")));
            this.buttonPanelNoticias.Location = new System.Drawing.Point(0, 286);
            this.buttonPanelNoticias.Name = "buttonPanelNoticias";
            this.buttonPanelNoticias.Size = new System.Drawing.Size(186, 42);
            this.buttonPanelNoticias.TabIndex = 1;
            this.buttonPanelNoticias.Text = "Noticias";
            this.buttonPanelNoticias.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonPanelNoticias.UseVisualStyleBackColor = true;
            this.buttonPanelNoticias.Click += new System.EventHandler(this.buttonPanelNoticias_Click);
            this.buttonPanelNoticias.Leave += new System.EventHandler(this.buttonPanelNoticias_Leave);
            // 
            // buttonPanelTareas
            // 
            this.buttonPanelTareas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanelTareas.FlatAppearance.BorderSize = 0;
            this.buttonPanelTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPanelTareas.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPanelTareas.ForeColor = System.Drawing.Color.White;
            this.buttonPanelTareas.Image = ((System.Drawing.Image)(resources.GetObject("buttonPanelTareas.Image")));
            this.buttonPanelTareas.Location = new System.Drawing.Point(0, 244);
            this.buttonPanelTareas.Name = "buttonPanelTareas";
            this.buttonPanelTareas.Size = new System.Drawing.Size(186, 42);
            this.buttonPanelTareas.TabIndex = 1;
            this.buttonPanelTareas.Text = "Tareas";
            this.buttonPanelTareas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonPanelTareas.UseVisualStyleBackColor = true;
            this.buttonPanelTareas.Click += new System.EventHandler(this.buttonPanelTareas_Click);
            this.buttonPanelTareas.Leave += new System.EventHandler(this.buttonPanelTareas_Leave);
            // 
            // buttonPanelEjecutables
            // 
            this.buttonPanelEjecutables.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanelEjecutables.FlatAppearance.BorderSize = 0;
            this.buttonPanelEjecutables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPanelEjecutables.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPanelEjecutables.ForeColor = System.Drawing.Color.White;
            this.buttonPanelEjecutables.Image = global::TrackerUI.Properties.Resources.Ejecutables_Icono;
            this.buttonPanelEjecutables.Location = new System.Drawing.Point(0, 202);
            this.buttonPanelEjecutables.Name = "buttonPanelEjecutables";
            this.buttonPanelEjecutables.Size = new System.Drawing.Size(186, 42);
            this.buttonPanelEjecutables.TabIndex = 1;
            this.buttonPanelEjecutables.Text = "Ejecutables";
            this.buttonPanelEjecutables.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonPanelEjecutables.UseVisualStyleBackColor = true;
            this.buttonPanelEjecutables.Click += new System.EventHandler(this.buttonPanelEjecutables_Click);
            this.buttonPanelEjecutables.Leave += new System.EventHandler(this.buttonPanelEjecutables_Leave);
            // 
            // panelMostrarUsuario
            // 
            this.panelMostrarUsuario.Controls.Add(this.labelUsername);
            this.panelMostrarUsuario.Controls.Add(this.pictureBoxUsuario);
            this.panelMostrarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMostrarUsuario.Location = new System.Drawing.Point(0, 0);
            this.panelMostrarUsuario.Name = "panelMostrarUsuario";
            this.panelMostrarUsuario.Size = new System.Drawing.Size(186, 202);
            this.panelMostrarUsuario.TabIndex = 1;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(44, 118);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(96, 18);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "User Name";
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsuario.Image")));
            this.pictureBoxUsuario.Location = new System.Drawing.Point(22, 12);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(142, 94);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUsuario.TabIndex = 1;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(148)))), ((int)(((byte)(242)))));
            this.headerPanel.Controls.Add(this.buttonClose);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(186, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(771, 27);
            this.headerPanel.TabIndex = 1;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseUp);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(148)))), ((int)(((byte)(242)))));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(719, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(52, 27);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.Leave += new System.EventHandler(this.buttonClose_Leave);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_Leave);
            this.buttonClose.MouseHover += new System.EventHandler(this.buttonClose_MouseHover);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(148)))), ((int)(((byte)(242)))));
            this.panelMain.Controls.Add(this.labelBienvenida);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(186, 27);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(771, 550);
            this.panelMain.TabIndex = 2;
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.Font = new System.Drawing.Font("Solid Soldier", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBienvenida.ForeColor = System.Drawing.Color.White;
            this.labelBienvenida.Location = new System.Drawing.Point(14, 141);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(743, 192);
            this.labelBienvenida.TabIndex = 0;
            this.labelBienvenida.Text = "BIENVENIDO A\r\nDAILY OPTIMUS\r\n¿QUÉ DESEA HACER HOY?";
            this.labelBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 577);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.panelOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PanelPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Optimus";
            this.panelOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMostrarUsuario.ResumeLayout(false);
            this.panelMostrarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelOpciones;
        private Panel panelMostrarUsuario;
        private PictureBox pictureBoxUsuario;
        private Button buttonPanelEjecutables;
        private Label labelUsername;
        private Button buttonPanelNoticias;
        private Button buttonPanelTareas;
        private Panel panelNav;
        private Panel headerPanel;
        private Panel panelMain;
        private Button buttonClose;
        private PictureBox pictureBox1;
        private Label labelBienvenida;
    }
}