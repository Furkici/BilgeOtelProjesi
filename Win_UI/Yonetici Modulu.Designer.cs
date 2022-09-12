namespace Win_UI
{
    partial class Yonetici_Modulu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.çalışanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resepsiyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hIZLIBAKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonOluşturYENİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriKayıtlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanlarToolStripMenuItem,
            this.hIZLIBAKIŞToolStripMenuItem,
            this.müşteriKayıtlarıToolStripMenuItem,
            this.rezervasyonlarToolStripMenuItem,
            this.rezervasyonOluşturYENİToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1092, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // çalışanlarToolStripMenuItem
            // 
            this.çalışanlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resepsiyonToolStripMenuItem,
            this.odaToolStripMenuItem});
            this.çalışanlarToolStripMenuItem.Name = "çalışanlarToolStripMenuItem";
            this.çalışanlarToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.çalışanlarToolStripMenuItem.Text = "CRUD işlemleri";
            this.çalışanlarToolStripMenuItem.Click += new System.EventHandler(this.çalışanlarToolStripMenuItem_Click);
            // 
            // resepsiyonToolStripMenuItem
            // 
            this.resepsiyonToolStripMenuItem.Name = "resepsiyonToolStripMenuItem";
            this.resepsiyonToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.resepsiyonToolStripMenuItem.Text = "Çalışan";
            this.resepsiyonToolStripMenuItem.Click += new System.EventHandler(this.resepsiyonToolStripMenuItem_Click);
            // 
            // odaToolStripMenuItem
            // 
            this.odaToolStripMenuItem.Name = "odaToolStripMenuItem";
            this.odaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.odaToolStripMenuItem.Text = "Oda ve Tatil Paketi";
            this.odaToolStripMenuItem.Click += new System.EventHandler(this.odaToolStripMenuItem_Click);
            // 
            // hIZLIBAKIŞToolStripMenuItem
            // 
            this.hIZLIBAKIŞToolStripMenuItem.Name = "hIZLIBAKIŞToolStripMenuItem";
            this.hIZLIBAKIŞToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.hIZLIBAKIŞToolStripMenuItem.Text = "Çalışanların Listesi";
            this.hIZLIBAKIŞToolStripMenuItem.Click += new System.EventHandler(this.hIZLIBAKIŞToolStripMenuItem_Click);
            // 
            // rezervasyonlarToolStripMenuItem
            // 
            this.rezervasyonlarToolStripMenuItem.Name = "rezervasyonlarToolStripMenuItem";
            this.rezervasyonlarToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.rezervasyonlarToolStripMenuItem.Text = "Rezervasyonlar";
            this.rezervasyonlarToolStripMenuItem.Click += new System.EventHandler(this.rezervasyonlarToolStripMenuItem_Click);
            // 
            // rezervasyonOluşturYENİToolStripMenuItem
            // 
            this.rezervasyonOluşturYENİToolStripMenuItem.Name = "rezervasyonOluşturYENİToolStripMenuItem";
            this.rezervasyonOluşturYENİToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.rezervasyonOluşturYENİToolStripMenuItem.Text = "Rezervasyon Oluştur(YENİ";
            this.rezervasyonOluşturYENİToolStripMenuItem.Click += new System.EventHandler(this.rezervasyonOluşturYENİToolStripMenuItem_Click);
            // 
            // müşteriKayıtlarıToolStripMenuItem
            // 
            this.müşteriKayıtlarıToolStripMenuItem.Name = "müşteriKayıtlarıToolStripMenuItem";
            this.müşteriKayıtlarıToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.müşteriKayıtlarıToolStripMenuItem.Text = "Müşteri Kayıtları";
            this.müşteriKayıtlarıToolStripMenuItem.Click += new System.EventHandler(this.müşteriKayıtlarıToolStripMenuItem_Click);
            // 
            // Yonetici_Modulu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 538);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Yonetici_Modulu";
            this.Text = "Yonetici_Modulu";
            this.Load += new System.EventHandler(this.Yonetici_Modulu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çalışanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resepsiyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hIZLIBAKIŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonOluşturYENİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriKayıtlarıToolStripMenuItem;
    }
}