using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 43652189;
            musteri1.MusteriAd = "Sefa";
            musteri1.MusteriSoyad = "Demirkıran";
            musteri1.Yas = 26;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1654132168;
            musteri2.MusteriAd = "Ezgi";
            musteri2.MusteriSoyad = "Dörtköşe";
            musteri2.Yas = 26;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 165415315;
            musteri3.MusteriAd = "Eyüp";
            musteri3.MusteriSoyad = "Demirkıran";
            musteri3.Yas = 27;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 1541225124;
            musteri4.MusteriAd = "Büşra";
            musteri4.MusteriSoyad = "Filoğlu";
            musteri4.Yas = 26;

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1, musteri2, musteri3, musteri4);

            musteriManager.MusteriListele(musteri2, musteri1, musteri3, musteri4);

            musteriManager.MusteriSil(musteri4);



        }
    }
}
