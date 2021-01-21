using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + "  " + musteri.Ad + "  " + "Eklendi.");
        }
        public void Listele(Musteri[] musteri)
        {
            Console.WriteLine("----------------- Müşteri Listesi -----------------");
            foreach (Musteri item in musteri)
            {
                Console.WriteLine(item.Id + "  " + item.Ad + "  " + item.Soyad);

            }
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + "  " + musteri.Ad + "  " + "Silindi.");
        }
    }
}
