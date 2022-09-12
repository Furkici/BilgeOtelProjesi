namespace Win_UI
{
    partial class Room
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOdaDurumu = new System.Windows.Forms.ComboBox();
            this.cmbOdaTipi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOdaID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTatilPaketiFiyat = new System.Windows.Forms.TextBox();
            this.txtTatilPaketiID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Fiyat";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(155, 178);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtFiyat.TabIndex = 25;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(105, 257);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(100, 49);
            this.btnListele.TabIndex = 23;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(146, 351);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(78, 27);
            this.btnSil.TabIndex = 22;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(230, 351);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(78, 27);
            this.btnGüncelle.TabIndex = 21;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(262, 257);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 49);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "Yeni Oda Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Oda Durumu";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader8});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(388, 14);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(734, 399);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Oda ID";
            this.columnHeader1.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Oda Tipi";
            this.columnHeader2.Width = 132;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Oda Durumu";
            this.columnHeader3.Width = 188;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            this.columnHeader4.Width = 96;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Oda Özellikleri";
            this.columnHeader8.Width = 234;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Oda Tipi";
            // 
            // cmbOdaDurumu
            // 
            this.cmbOdaDurumu.FormattingEnabled = true;
            this.cmbOdaDurumu.Location = new System.Drawing.Point(155, 131);
            this.cmbOdaDurumu.Name = "cmbOdaDurumu";
            this.cmbOdaDurumu.Size = new System.Drawing.Size(100, 24);
            this.cmbOdaDurumu.TabIndex = 18;
            // 
            // cmbOdaTipi
            // 
            this.cmbOdaTipi.FormattingEnabled = true;
            this.cmbOdaTipi.Location = new System.Drawing.Point(155, 82);
            this.cmbOdaTipi.Name = "cmbOdaTipi";
            this.cmbOdaTipi.Size = new System.Drawing.Size(100, 24);
            this.cmbOdaTipi.TabIndex = 24;
            this.cmbOdaTipi.SelectedIndexChanged += new System.EventHandler(this.cmbOdaTipi_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Oda ID";
            // 
            // txtOdaID
            // 
            this.txtOdaID.Location = new System.Drawing.Point(146, 312);
            this.txtOdaID.Name = "txtOdaID";
            this.txtOdaID.Size = new System.Drawing.Size(162, 22);
            this.txtOdaID.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(102, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Yeni Oda Eklerken ID zorunlu degildir.";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tatil Paketleri Fiyat Güncellemesi";
            // 
            // txtTatilPaketiFiyat
            // 
            this.txtTatilPaketiFiyat.Location = new System.Drawing.Point(365, 622);
            this.txtTatilPaketiFiyat.Name = "txtTatilPaketiFiyat";
            this.txtTatilPaketiFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtTatilPaketiFiyat.TabIndex = 34;
            // 
            // txtTatilPaketiID
            // 
            this.txtTatilPaketiID.Location = new System.Drawing.Point(365, 581);
            this.txtTatilPaketiID.Name = "txtTatilPaketiID";
            this.txtTatilPaketiID.Size = new System.Drawing.Size(100, 22);
            this.txtTatilPaketiID.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 584);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tatil Paketi ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 622);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Fiyat:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 668);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 33);
            this.button2.TabIndex = 41;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(623, 511);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(452, 237);
            this.listView2.TabIndex = 43;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tatil Paketi ID";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fiyat";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Türü";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(40, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 31);
            this.button1.TabIndex = 44;
            this.button1.Text = "Hızlı Bakış Sayfasına Git";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 22);
            this.textBox1.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = "Oda Özellikleri";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(211, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 31);
            this.button3.TabIndex = 47;
            this.button3.Text = "Müşteri Kayıtları";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 813);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTatilPaketiID);
            this.Controls.Add(this.txtTatilPaketiFiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtOdaID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.cmbOdaTipi);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOdaDurumu);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Name = "Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOdaDurumu;
        private System.Windows.Forms.ComboBox cmbOdaTipi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOdaID;
        private System.Windows.Forms.Label label8;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTatilPaketiFiyat;
        private System.Windows.Forms.TextBox txtTatilPaketiID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
    }
}