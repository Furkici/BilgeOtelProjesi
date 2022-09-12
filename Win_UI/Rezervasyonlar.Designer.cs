namespace Win_UI
{
    partial class Rezervasyonlar
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader15});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1799, 385);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "RezervasyonID";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giris Tarihi";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cıkıs Tarihi";
            this.columnHeader3.Width = 145;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gun Sayısı";
            this.columnHeader4.Width = 133;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Rezervasyon Tarihi";
            this.columnHeader5.Width = 151;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tatil Paketi ID";
            this.columnHeader6.Width = 117;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Oda ID";
            this.columnHeader7.Width = 123;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Müşteri ID";
            this.columnHeader8.Width = 82;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Toplam Fiyat";
            this.columnHeader9.Width = 102;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Musteri Adı";
            this.columnHeader10.Width = 101;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Musteri Soyadı";
            this.columnHeader11.Width = 116;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "TCKN";
            this.columnHeader12.Width = 152;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Oda Tipi";
            this.columnHeader13.Width = 122;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Tatil Paketi Tipi";
            this.columnHeader15.Width = 143;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(23, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Resepsiyon Modülü";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Rezervasyonlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1885, 771);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Rezervasyonlar";
            this.Text = "Rezervasyonlar";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button2;
    }
}