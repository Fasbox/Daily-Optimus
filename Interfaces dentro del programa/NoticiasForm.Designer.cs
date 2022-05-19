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
            this.listBoxNews = new System.Windows.Forms.ListBox();
            this.labelInfoNews = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNoticias
            // 
            this.labelNoticias.AutoSize = true;
            this.labelNoticias.Font = new System.Drawing.Font("Solid Soldier", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNoticias.ForeColor = System.Drawing.Color.White;
            this.labelNoticias.Location = new System.Drawing.Point(26, 19);
            this.labelNoticias.Name = "labelNoticias";
            this.labelNoticias.Size = new System.Drawing.Size(71, 16);
            this.labelNoticias.TabIndex = 1;
            this.labelNoticias.Text = "Noticias";
            // 
            // listBoxNews
            // 
            this.listBoxNews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(131)))), ((int)(((byte)(242)))));
            this.listBoxNews.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxNews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxNews.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxNews.ForeColor = System.Drawing.Color.White;
            this.listBoxNews.FormattingEnabled = true;
            this.listBoxNews.ItemHeight = 22;
            this.listBoxNews.Location = new System.Drawing.Point(26, 80);
            this.listBoxNews.Name = "listBoxNews";
            this.listBoxNews.Size = new System.Drawing.Size(710, 418);
            this.listBoxNews.TabIndex = 2;
            // 
            // labelInfoNews
            // 
            this.labelInfoNews.AutoSize = true;
            this.labelInfoNews.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInfoNews.ForeColor = System.Drawing.Color.White;
            this.labelInfoNews.Location = new System.Drawing.Point(26, 49);
            this.labelInfoNews.Name = "labelInfoNews";
            this.labelInfoNews.Size = new System.Drawing.Size(178, 22);
            this.labelInfoNews.TabIndex = 4;
            this.labelInfoNews.Text = "Noticias de tu interés.";
            // 
            // NoticiasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(131)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.labelInfoNews);
            this.Controls.Add(this.listBoxNews);
            this.Controls.Add(this.labelNoticias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoticiasForm";
            this.Text = "Daily Optimus";
            this.Load += new System.EventHandler(this.NoticiasForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNoticias;
        private ListBox listBoxNews;
        private Label labelInfoNews;
    }
}