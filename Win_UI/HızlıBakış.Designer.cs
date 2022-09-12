namespace Win_UI
{
    partial class HızlıBakış
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.columnHeader7});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(52, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1084, 360);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "GOREV";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ADI";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SOYADI";
            this.columnHeader4.Width = 147;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Bütün Çalışanları Gör";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yaş";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Saat Sayısı";
            this.columnHeader6.Width = 103;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Vardiya";
            this.columnHeader7.Width = 106;
            // 
            // HızlıBakış
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 762);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "HızlıBakış";
            this.Text = "HızlıBakış";
            this.Load += new System.EventHandler(this.HızlıBakış_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}