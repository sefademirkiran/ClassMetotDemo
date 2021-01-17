using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(params Musteri[] musteriler)
        {
            Console.WriteLine("Müşteri Eklendi : \n");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " - " + musteri.MusteriAd + " - " + musteri.MusteriSoyad + " - " + musteri.Yas);
            }
            Console.WriteLine("----------------------------------------------");
        }

        public void MusteriSil(params Musteri[] musteriler)
        {
            Console.WriteLine("Müşteri Silindi : \n");
            foreach (var musteri in musteriler)

            {
                Console.WriteLine(musteri.Id + " - " + musteri.MusteriAd + " - " + musteri.MusteriSoyad + " - " + musteri.Yas);
            }
            Console.WriteLine("************************************************");
        }
        public void MusteriListele(params Musteri[] musteriler)
        {
            Console.WriteLine("Müşteri Listelendi : \n");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " - " + musteri.MusteriAd + " - " + musteri.MusteriSoyad + " - " + musteri.Yas);
            }
            Console.WriteLine("-------------------------------------------------");
        }

    }
}
