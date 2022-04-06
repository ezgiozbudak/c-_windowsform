using System;
using System.Collections;
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
    public partial class Secim : Form
    {
        public int secim;
        public int deger;
        Form2 fm = new Form2();
        
        public static ArrayList dizi = new ArrayList();
        public static ArrayList dizi2 = new ArrayList();
        public Secim()
        {
            InitializeComponent();
        }
        /*
         * 
         * 
         * -------------------Bilgi------------------
         *  İlk olarak menüden çeşitlerden birine tıklanır, yemek isimleri texboxuna 
         *  1-3 arası sayı girilir. Eğer satın alınmak istiyorsa sepete ekle butonuna basılır. Ürünler seçildikten 
         *  sonra menüden sepete tıklanır. Ürünler listboxta sıralanır. Meze eklenmek istenyiorsa tik işaretlenir.
         *  Checkbox tikliyse fiyat eklenir , silinirse fiyat silinir. Listboxta ürünü tıklayıp farenin sağ tuşuna 
         *  basılırsa sil komutu çıkar . Silmek istenen ürün listeden çıkarılır.
         *  
         *  
         *  
         */
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) 
        {
            tbAd.ReadOnly = false;
            tbFiyat.ReadOnly = false;

            string itemText = e.ClickedItem.Text;


            switch (itemText)
            {
                case "Tavuk Çeşitleri":
                    secim = 1;
                    break;

                case "Et Çeşitleri":
                    secim = 2;
                    break;

                case "Balık Çeşitleri":
                    secim = 3;
                    break;

                case "Çorba Çeşitleri":
                    secim = 4;
                    break;

                case "Salata Çeşitleri":
                    secim = 5;
                    break;
            }
        }
        enum Tavuk
        {
            Tavuk_Tantuni = 1,
            Tavuk_Doner,
            Tavuk_Sis
        }
        enum Et
        {
            Beyti=1,
            Et_Doner,
            Kofte
        }
        enum Balik
        {
            Cipura = 1,
            Hamsi,
            Levrek
        }
        enum Corba
        {
            Ezogelin = 1,
            Mercimek_Corbasi,
            Yayla_Corbası
        }
        enum Salata
        {
            Coban_Salatasi = 1,
            Mevsim_Salata,
            Yesil_Salata
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
          
            try
            {
                deger = Int32.Parse(tbAd.Text);
                Hata();
            }
            catch (Exception)
            {
                MessageBox.Show("Rakam Giriniz!");
                tbFiyat.Text = "";
                
            }
            
            if(secim == 1)
            {
                Fiyat.fiyat = 25;
                fiyatYaz();
                tbAd.Text = Enum.GetName(typeof(Tavuk) , deger);
                if (deger == 1) pictureBox1.Image = Properties.Resources.tavuk_tantuni;
                else if (deger == 2) pictureBox1.Image = Properties.Resources.tavuk_doner;
                else if (deger == 3) pictureBox1.Image = Properties.Resources.tavuk_sis;
            }
            else if (secim == 2)
            {
                Fiyat.fiyat = 40;
                fiyatYaz();
                tbAd.Text = Enum.GetName(typeof(Et), deger);
                if (deger == 1) pictureBox1.Image = Properties.Resources.beyti;
                else if (deger == 2) pictureBox1.Image = Properties.Resources.etDöner;
                else if (deger == 3) pictureBox1.Image = Properties.Resources.kofte;
            }
            else if (secim == 3)
            {
                Fiyat.fiyat = 28;
                fiyatYaz();
                tbAd.Text = Enum.GetName(typeof(Balik), deger);
                if (deger == 1) pictureBox1.Image = Properties.Resources.cipura;
                else if (deger == 2) pictureBox1.Image = Properties.Resources.hamsi;
                else if (deger == 3) pictureBox1.Image = Properties.Resources.levrek;
            }
            else if (secim == 4)
            {
                Fiyat.fiyat = 15;
                fiyatYaz();
                tbAd.Text = Enum.GetName(typeof(Corba), deger);
                if (deger == 1) pictureBox1.Image = Properties.Resources.ezogelin_corba_tarifi;
                else if (deger == 2) pictureBox1.Image = Properties.Resources.mercimek;
                else if (deger == 3) pictureBox1.Image = Properties.Resources.yaylacorbasi;
            }
            else if (secim == 5)
            {
                Fiyat.fiyat = 10;
                fiyatYaz();
                tbAd.Text = Enum.GetName(typeof(Salata), deger);
                if (deger == 1) pictureBox1.Image = Properties.Resources.cobanSalata;
                else if (deger == 2) pictureBox1.Image = Properties.Resources.mevsimSalata;
                else if (deger == 3) pictureBox1.Image = Properties.Resources.yesilSalata;
            }
        }

    
        public void Hata()
        {
            if (deger > 3) { MessageBox.Show("1-3 arası sayı giriniz."); secim = 0; }
               
        }
        public void fiyatYaz()
        {
            tbFiyat.Text = Fiyat.fiyat.ToString();
        }
        private void sepetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm.Show();
           
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            dizi.Add(tbAd.Text);
            tbAd.Text = "";
            dizi2.Add(tbFiyat.Text);
            tbFiyat.Text = "";

        }
    }
}
