namespace TrackerUI
{
    partial class TareasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TareasForm));
            this.labelTareas = new System.Windows.Forms.Label();
            this.labelInfoTareas = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.listBoxTareas = new System.Windows.Forms.ListBox();
            this.richTextBoxTarea = new System.Windows.Forms.RichTextBox();
            this.labelNuevaTarea = new System.Windows.Forms.Label();
            this.labelNuevaTarea2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTareas
            // 
            this.labelTareas.AutoSize = true;
            this.labelTareas.Font = new System.Drawing.Font("Solid Soldier", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTareas.ForeColor = System.Drawing.Color.White;
            this.labelTareas.Location = new System.Drawing.Point(28, 20);
            this.labelTareas.Name = "labelTareas";
            this.labelTareas.Size = new System.Drawing.Size(61, 16);
            this.labelTareas.TabIndex = 1;
            this.labelTareas.Text = "Tareas";
            // 
            // labelInfoTareas
            // 
            this.labelInfoTareas.AutoSize = true;
            this.labelInfoTareas.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInfoTareas.ForeColor = System.Drawing.Color.White;
            this.labelInfoTareas.Location = new System.Drawing.Point(28, 49);
            this.labelInfoTareas.Name = "labelInfoTareas";
            this.labelInfoTareas.Size = new System.Drawing.Size(518, 22);
            this.labelInfoTareas.TabIndex = 3;
            this.labelInfoTareas.Text = "Aquí encontrarás las tareas que hayas agregado hasta el momento.\r\n";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(127)))), ((int)(((byte)(219)))));
            this.buttonAgregar.FlatAppearance.BorderSize = 0;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAgregar.ForeColor = System.Drawing.Color.White;
            this.buttonAgregar.Location = new System.Drawing.Point(344, 481);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(111, 37);
            this.buttonAgregar.TabIndex = 6;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(127)))), ((int)(((byte)(219)))));
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Location = new System.Drawing.Point(196, 481);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(111, 37);
            this.buttonEditar.TabIndex = 7;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(127)))), ((int)(((byte)(219)))));
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(497, 481);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(111, 37);
            this.buttonEliminar.TabIndex = 8;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // listBoxTareas
            // 
            this.listBoxTareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(127)))), ((int)(((byte)(219)))));
            this.listBoxTareas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTareas.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxTareas.ForeColor = System.Drawing.Color.White;
            this.listBoxTareas.FormattingEnabled = true;
            this.listBoxTareas.ItemHeight = 22;
            this.listBoxTareas.Location = new System.Drawing.Point(187, 107);
            this.listBoxTareas.Name = "listBoxTareas";
            this.listBoxTareas.Size = new System.Drawing.Size(432, 264);
            this.listBoxTareas.TabIndex = 9;
            // 
            // richTextBoxTarea
            // 
            this.richTextBoxTarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxTarea.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxTarea.Location = new System.Drawing.Point(247, 406);
            this.richTextBoxTarea.Name = "richTextBoxTarea";
            this.richTextBoxTarea.Size = new System.Drawing.Size(372, 55);
            this.richTextBoxTarea.TabIndex = 10;
            this.richTextBoxTarea.Text = "";
            // 
            // labelNuevaTarea
            // 
            this.labelNuevaTarea.AutoSize = true;
            this.labelNuevaTarea.Font = new System.Drawing.Font("Solid Soldier", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNuevaTarea.ForeColor = System.Drawing.Color.White;
            this.labelNuevaTarea.Location = new System.Drawing.Point(187, 407);
            this.labelNuevaTarea.Name = "labelNuevaTarea";
            this.labelNuevaTarea.Size = new System.Drawing.Size(52, 16);
            this.labelNuevaTarea.TabIndex = 11;
            this.labelNuevaTarea.Text = "Nueva\r\n";
            // 
            // labelNuevaTarea2
            // 
            this.labelNuevaTarea2.AutoSize = true;
            this.labelNuevaTarea2.Font = new System.Drawing.Font("Solid Soldier", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNuevaTarea2.ForeColor = System.Drawing.Color.White;
            this.labelNuevaTarea2.Location = new System.Drawing.Point(187, 430);
            this.labelNuevaTarea2.Name = "labelNuevaTarea2";
            this.labelNuevaTarea2.Size = new System.Drawing.Size(57, 16);
            this.labelNuevaTarea2.TabIndex = 12;
            this.labelNuevaTarea2.Text = "Tarea:";
            // 
            // TareasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(131)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.labelNuevaTarea2);
            this.Controls.Add(this.labelNuevaTarea);
            this.Controls.Add(this.richTextBoxTarea);
            this.Controls.Add(this.listBoxTareas);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.labelInfoTareas);
            this.Controls.Add(this.labelTareas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TareasForm";
            this.Text = "Daily Optimus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TareasForm_FormClosing);
            this.Load += new System.EventHandler(this.TareasForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTareas;
        private Label labelInfoTareas;
        private Button buttonAgregar;
        private Button buttonEditar;
        private Button buttonEliminar;
        private ListBox listBoxTareas;
        private RichTextBox richTextBoxTarea;
        private Label labelNuevaTarea;
        private Label labelNuevaTarea2;
    }
}