namespace TrackerUI
{
    partial class EjecutablesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EjecutablesForm));
            this.labelEjecutables = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panelContener = new System.Windows.Forms.Panel();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEjecutables
            // 
            this.labelEjecutables.AutoSize = true;
            this.labelEjecutables.Font = new System.Drawing.Font("Solid Soldier", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEjecutables.ForeColor = System.Drawing.Color.White;
            this.labelEjecutables.Location = new System.Drawing.Point(39, 18);
            this.labelEjecutables.Name = "labelEjecutables";
            this.labelEjecutables.Size = new System.Drawing.Size(106, 16);
            this.labelEjecutables.TabIndex = 0;
            this.labelEjecutables.Text = "Ejecutables";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(39, 46);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(438, 22);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "Aquí encontrarás las aplicaciones que normalmente usas";
            // 
            // panelContener
            // 
            this.panelContener.Location = new System.Drawing.Point(39, 90);
            this.panelContener.Name = "panelContener";
            this.panelContener.Size = new System.Drawing.Size(740, 360);
            this.panelContener.TabIndex = 3;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(127)))), ((int)(((byte)(219)))));
            this.buttonAgregar.FlatAppearance.BorderSize = 0;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAgregar.ForeColor = System.Drawing.Color.White;
            this.buttonAgregar.Location = new System.Drawing.Point(230, 468);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(146, 38);
            this.buttonAgregar.TabIndex = 4;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonGenerar
            // 
            this.buttonGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(127)))), ((int)(((byte)(219)))));
            this.buttonGenerar.FlatAppearance.BorderSize = 0;
            this.buttonGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerar.ForeColor = System.Drawing.Color.White;
            this.buttonGenerar.Location = new System.Drawing.Point(418, 468);
            this.buttonGenerar.Name = "buttonGenerar";
            this.buttonGenerar.Size = new System.Drawing.Size(146, 38);
            this.buttonGenerar.TabIndex = 5;
            this.buttonGenerar.Text = "Generar";
            this.buttonGenerar.UseVisualStyleBackColor = false;
            this.buttonGenerar.Click += new System.EventHandler(this.buttonGenerar_Click);
            // 
            // EjecutablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(131)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.buttonGenerar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.panelContener);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelEjecutables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EjecutablesForm";
            this.Text = "Daily Optimus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EjecutablesForm_FormClosing);
            this.Load += new System.EventHandler(this.EjecutablesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelEjecutables;
        private Label labelInfo;
        private Panel panelContener;
        private Button buttonAgregar;
        private Button buttonGenerar;
    }
}