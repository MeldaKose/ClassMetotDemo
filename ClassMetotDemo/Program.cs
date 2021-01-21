using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Melda";
            musteri1.Soyad = "Köse";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Aleyna";
            musteri2.Soyad = "Köse";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Nihal";
            musteri3.Soyad = "Akdeniz";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri2);
            musteriManager.Sil(musteri1);
            musteriManager.Listele(musteriler);
        }
    }
}
