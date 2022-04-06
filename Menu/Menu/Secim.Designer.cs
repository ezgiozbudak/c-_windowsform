
namespace Menu
{
    partial class Secim
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.tbFiyat = new System.Windows.Forms.TextBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tavukÇeşitleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etÇeşitleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balıkÇesitleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çorbaÇeşitleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salataÇeşitleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.5082F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.35519F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFiyat, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbFiyat, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSec, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbAd, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEkle, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 77);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.90909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.09091F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 220);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Liberation Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(219, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(116, 51);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Yemek İsmi:\r\n(Her menü 3 ürünlüdür)";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(219, 144);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(63, 15);
            this.lblFiyat.TabIndex = 2;
            this.lblFiyat.Text = "Fiyat :";
            // 
            // tbFiyat
            // 
            this.tbFiyat.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbFiyat.Location = new System.Drawing.Point(368, 147);
            this.tbFiyat.Name = "tbFiyat";
            this.tbFiyat.ReadOnly = true;
            this.tbFiyat.Size = new System.Drawing.Size(177, 22);
            this.tbFiyat.TabIndex = 4;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(551, 3);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(75, 23);
            this.btnSec.TabIndex = 5;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // tbAd
            // 
            this.tbAd.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAd.Location = new System.Drawing.Point(368, 3);
            this.tbAd.Name = "tbAd";
            this.tbAd.ReadOnly = true;
            this.tbAd.Size = new System.Drawing.Size(177, 22);
            this.tbAd.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(551, 147);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Sepete Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tavukÇeşitleriToolStripMenuItem,
            this.etÇeşitleriToolStripMenuItem,
            this.balıkÇesitleriToolStripMenuItem,
            this.çorbaÇeşitleriToolStripMenuItem,
            this.salataÇeşitleriToolStripMenuItem,
            this.sepetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tavukÇeşitleriToolStripMenuItem
            // 
            this.tavukÇeşitleriToolStripMenuItem.Name = "tavukÇeşitleriToolStripMenuItem";
            this.tavukÇeşitleriToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.tavukÇeşitleriToolStripMenuItem.Text = "Tavuk Çeşitleri";
            // 
            // etÇeşitleriToolStripMenuItem
            // 
            this.etÇeşitleriToolStripMenuItem.Name = "etÇeşitleriToolStripMenuItem";
            this.etÇeşitleriToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.etÇeşitleriToolStripMenuItem.Text = "Et Çeşitleri";
            // 
            // balıkÇesitleriToolStripMenuItem
            // 
            this.balıkÇesitleriToolStripMenuItem.Name = "balıkÇesitleriToolStripMenuItem";
            this.balıkÇesitleriToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.balıkÇesitleriToolStripMenuItem.Text = "Balık Çeşitleri";
            // 
            // çorbaÇeşitleriToolStripMenuItem
            // 
            this.çorbaÇeşitleriToolStripMenuItem.Name = "çorbaÇeşitleriToolStripMenuItem";
            this.çorbaÇeşitleriToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.çorbaÇeşitleriToolStripMenuItem.Text = "Çorba Çeşitleri";
            // 
            // salataÇeşitleriToolStripMenuItem
            // 
            this.salataÇeşitleriToolStripMenuItem.Name = "salataÇeşitleriToolStripMenuItem";
            this.salataÇeşitleriToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.salataÇeşitleriToolStripMenuItem.Text = "Salata Çeşitleri";
            // 
            // sepetToolStripMenuItem
            // 
            this.sepetToolStripMenuItem.Name = "sepetToolStripMenuItem";
            this.sepetToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.sepetToolStripMenuItem.Text = "Sepet";
            this.sepetToolStripMenuItem.Click += new System.EventHandler(this.sepetToolStripMenuItem_Click);
            // 
            // Secim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Secim";
            this.Text = "Secim";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox tbFiyat;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tavukÇeşitleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etÇeşitleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balıkÇesitleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çorbaÇeşitleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salataÇeşitleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepetToolStripMenuItem;
    }
}