namespace HastaneOtomasyon
{
    partial class Doktorlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktorlar));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dOSYAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDoktorlar = new System.Windows.Forms.Button();
            this.btnDoktorGuncelle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDoktorSil = new System.Windows.Forms.TextBox();
            this.btnDoktorSilme = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDoktorArama = new System.Windows.Forms.Button();
            this.txtDoktorAra = new System.Windows.Forms.TextBox();
            this.btnDoktorEkle = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dOSYAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dOSYAToolStripMenuItem
            // 
            this.dOSYAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çIKIŞToolStripMenuItem});
            this.dOSYAToolStripMenuItem.Name = "dOSYAToolStripMenuItem";
            this.dOSYAToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.dOSYAToolStripMenuItem.Text = "DOSYA";
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 292);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnDoktorlar
            // 
            this.btnDoktorlar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoktorlar.BackgroundImage")));
            this.btnDoktorlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktorlar.Location = new System.Drawing.Point(23, 339);
            this.btnDoktorlar.Name = "btnDoktorlar";
            this.btnDoktorlar.Size = new System.Drawing.Size(125, 76);
            this.btnDoktorlar.TabIndex = 12;
            this.btnDoktorlar.UseVisualStyleBackColor = true;
            this.btnDoktorlar.Click += new System.EventHandler(this.btnDoktorlar_Click);
            // 
            // btnDoktorGuncelle
            // 
            this.btnDoktorGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoktorGuncelle.BackgroundImage")));
            this.btnDoktorGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktorGuncelle.Location = new System.Drawing.Point(595, 234);
            this.btnDoktorGuncelle.Name = "btnDoktorGuncelle";
            this.btnDoktorGuncelle.Size = new System.Drawing.Size(109, 62);
            this.btnDoktorGuncelle.TabIndex = 17;
            this.btnDoktorGuncelle.UseVisualStyleBackColor = true;
            this.btnDoktorGuncelle.Click += new System.EventHandler(this.btnDoktorGuncelle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Location = new System.Drawing.Point(601, 339);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(103, 71);
            this.btnCikis.TabIndex = 16;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDoktorSil);
            this.groupBox2.Controls.Add(this.btnDoktorSilme);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(537, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 68);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doktor Silme";
            // 
            // txtDoktorSil
            // 
            this.txtDoktorSil.Location = new System.Drawing.Point(6, 32);
            this.txtDoktorSil.MaxLength = 11;
            this.txtDoktorSil.Name = "txtDoktorSil";
            this.txtDoktorSil.Size = new System.Drawing.Size(115, 20);
            this.txtDoktorSil.TabIndex = 9;
            this.txtDoktorSil.Text = "Doktor No";
            // 
            // btnDoktorSilme
            // 
            this.btnDoktorSilme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoktorSilme.BackgroundImage")));
            this.btnDoktorSilme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktorSilme.Location = new System.Drawing.Point(133, 10);
            this.btnDoktorSilme.Name = "btnDoktorSilme";
            this.btnDoktorSilme.Size = new System.Drawing.Size(70, 52);
            this.btnDoktorSilme.TabIndex = 10;
            this.btnDoktorSilme.UseVisualStyleBackColor = true;
            this.btnDoktorSilme.Click += new System.EventHandler(this.btnDoktorSilme_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDoktorArama);
            this.groupBox1.Controls.Add(this.txtDoktorAra);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(537, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 58);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Arama";
            // 
            // btnDoktorArama
            // 
            this.btnDoktorArama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoktorArama.BackgroundImage")));
            this.btnDoktorArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktorArama.Location = new System.Drawing.Point(133, 9);
            this.btnDoktorArama.Name = "btnDoktorArama";
            this.btnDoktorArama.Size = new System.Drawing.Size(70, 44);
            this.btnDoktorArama.TabIndex = 10;
            this.btnDoktorArama.UseVisualStyleBackColor = true;
            this.btnDoktorArama.Click += new System.EventHandler(this.btnDoktorArama_Click);
            // 
            // txtDoktorAra
            // 
            this.txtDoktorAra.Location = new System.Drawing.Point(12, 24);
            this.txtDoktorAra.MaxLength = 11;
            this.txtDoktorAra.Name = "txtDoktorAra";
            this.txtDoktorAra.Size = new System.Drawing.Size(115, 20);
            this.txtDoktorAra.TabIndex = 9;
            this.txtDoktorAra.Text = "Doktor Adı";
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoktorEkle.BackgroundImage")));
            this.btnDoktorEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktorEkle.Location = new System.Drawing.Point(215, 336);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(128, 76);
            this.btnDoktorEkle.TabIndex = 19;
            this.btnDoktorEkle.UseVisualStyleBackColor = true;
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.BackgroundImage")));
            this.btnAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnasayfa.Location = new System.Drawing.Point(406, 339);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(125, 71);
            this.btnAnasayfa.TabIndex = 18;
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // Doktorlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(784, 427);
            this.Controls.Add(this.btnDoktorEkle);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnDoktorGuncelle);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDoktorlar);
            this.Name = "Doktorlar";
            this.Text = "Doktorlar";
            this.Load += new System.EventHandler(this.Doktorlar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dOSYAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDoktorlar;
        private System.Windows.Forms.Button btnDoktorGuncelle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDoktorSil;
        private System.Windows.Forms.Button btnDoktorSilme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDoktorArama;
        private System.Windows.Forms.TextBox txtDoktorAra;
        private System.Windows.Forms.Button btnDoktorEkle;
        private System.Windows.Forms.Button btnAnasayfa;
    }
}