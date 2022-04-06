using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class Fiyat 
    {
        public static int fiyat { get; set; }

        public static int fiyatHesapla()
        {
            int toplam = 0;
            for (int i = 0; i < Secim.dizi2.Count; i++)
            {
                toplam += Int32.Parse((string)Secim.dizi2[i]);
            }
            return toplam;
        }
    }
}
