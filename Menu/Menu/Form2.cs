using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            Ekle();
            tbToplam.Text = Fiyat.fiyatHesapla().ToString();
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public  void Ekle()
        {

            for (int i = 0; i < Secim.dizi.Count; i++)
            {
                listBox1.Items.Add(Secim.dizi[i] + " " + Secim.dizi2[i] + " tl");
                
            }

        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Ürünleri satın almak istiyor musunuz?","Bildirim" ,MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show("Satın alındı");
            }
            else
            {

                listBox1.Items.Clear();
                tbToplam.Text = "";
                cbSos1.Enabled = false;
                cbSos2.Enabled = false;
                cbSos3.Enabled = false;
            }


        }

       
        private void cbSos1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSos1.Checked) sosekle(cbSos1);
            else sosCikar(cbSos1);

        }
        public void sosekle(CheckBox a)
        {
            int yeniToplam = Int32.Parse(tbToplam.Text) + 15;
            tbToplam.Text = yeniToplam.ToString();
            listBox1.Items.Add(a.Text);
        }

        public void sosCikar(CheckBox a)
        {
            int yeniToplam = Int32.Parse(tbToplam.Text) - 15;
            tbToplam.Text = yeniToplam.ToString();
            listBox1.Items.Remove(a.Text);
        }

        private void cbSos2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSos2.Checked) sosekle(cbSos2);
            else sosCikar(cbSos2);
        }

        private void cbSos3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSos3.Checked) sosekle(cbSos3);
            else sosCikar(cbSos3);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a;
            a = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(a);
            int yeniToplam = Int32.Parse(tbToplam.Text) - Int32.Parse((string)Secim.dizi2[a]);
            tbToplam.Text = yeniToplam.ToString();
            
        }
    }
}
