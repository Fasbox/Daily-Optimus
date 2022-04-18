namespace TrackerUI
{
    partial class NoticiasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoticiasForm));
            this.labelNoticias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNoticias
            // 
            this.labelNoticias.AutoSize = true;
            this.labelNoticias.Font = new System.Drawing.Font("Solid Soldier", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNoticias.Location = new System.Drawing.Point(26, 19);
            this.labelNoticias.Name = "labelNoticias";
            this.labelNoticias.Size = new System.Drawing.Size(71, 16);
            this.labelNoticias.TabIndex = 1;
            this.labelNoticias.Text = "Noticias";
            // 
            // NoticiasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNoticias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoticiasForm";
            this.Text = "Daily Optimus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNoticias;
    }
}