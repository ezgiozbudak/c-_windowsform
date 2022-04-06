
namespace Menu
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSos3 = new System.Windows.Forms.CheckBox();
            this.cbSos2 = new System.Windows.Forms.CheckBox();
            this.cbSos1 = new System.Windows.Forms.CheckBox();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.tbToplam = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMeze = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSos3);
            this.groupBox1.Controls.Add(this.cbSos2);
            this.groupBox1.Controls.Add(this.cbSos1);
            this.groupBox1.Location = new System.Drawing.Point(57, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cbSos3
            // 
            this.cbSos3.AutoSize = true;
            this.cbSos3.Location = new System.Drawing.Point(6, 65);
            this.cbSos3.Name = "cbSos3";
            this.cbSos3.Size = new System.Drawing.Size(74, 17);
            this.cbSos3.TabIndex = 3;
            this.cbSos3.Text = "Acılı Ezme";
            this.cbSos3.UseVisualStyleBackColor = true;
            this.cbSos3.CheckedChanged += new System.EventHandler(this.cbSos3_CheckedChanged);
            // 
            // cbSos2
            // 
            this.cbSos2.AutoSize = true;
            this.cbSos2.Location = new System.Drawing.Point(6, 42);
            this.cbSos2.Name = "cbSos2";
            this.cbSos2.Size = new System.Drawing.Size(95, 17);
            this.cbSos2.TabIndex = 3;
            this.cbSos2.Text = "Havuç Tarator";
            this.cbSos2.UseVisualStyleBackColor = true;
            this.cbSos2.CheckedChanged += new System.EventHandler(this.cbSos2_CheckedChanged);
            // 
            // cbSos1
            // 
            this.cbSos1.AutoSize = true;
            this.cbSos1.Location = new System.Drawing.Point(6, 19);
            this.cbSos1.Name = "cbSos1";
            this.cbSos1.Size = new System.Drawing.Size(122, 17);
            this.cbSos1.TabIndex = 3;
            this.cbSos1.Text = "Kırmızı Biber Salatası";
            this.cbSos1.UseVisualStyleBackColor = true;
            this.cbSos1.CheckedChanged += new System.EventHandler(this.cbSos1_CheckedChanged);
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Location = new System.Drawing.Point(298, 329);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(75, 23);
            this.btnSatinAl.TabIndex = 3;
            this.btnSatinAl.Text = "Satın Al";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // tbToplam
            // 
            this.tbToplam.Location = new System.Drawing.Point(298, 267);
            this.tbToplam.Name = "tbToplam";
            this.tbToplam.ReadOnly = true;
            this.tbToplam.Size = new System.Drawing.Size(100, 20);
            this.tbToplam.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(298, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 199);
            this.listBox1.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // lblMeze
            // 
            this.lblMeze.AutoSize = true;
            this.lblMeze.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeze.Location = new System.Drawing.Point(54, 28);
            this.lblMeze.Name = "lblMeze";
            this.lblMeze.Size = new System.Drawing.Size(71, 15);
            this.lblMeze.TabIndex = 7;
            this.lblMeze.Text = "Mezeler:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(295, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ürünler:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(678, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMeze);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbToplam);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbSos3;
        private System.Windows.Forms.CheckBox cbSos2;
        private System.Windows.Forms.CheckBox cbSos1;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.TextBox tbToplam;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Label lblMeze;
        private System.Windows.Forms.Label label1;
    }
}