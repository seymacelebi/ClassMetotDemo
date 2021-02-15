using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Şeyma";
            musteri1.Soyad = "Çelebi";
            musteri1.Adres = "İstanbul";
            musteri1.TelNo = 1111111110;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Aleyna";
            musteri2.Soyad = "Bulu";
            musteri2.Adres = "İstanbul";
            musteri2.TelNo = 1141111110;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Esma";
            musteri3.Soyad = "Çelebi";
            musteri3.Adres = "İstanbul";
            musteri3.TelNo = 11415110;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme(musteri1);
            musteriManager.MusteriEkleme(musteri2);
            musteriManager.MusteriEkleme(musteri3);
            Console.WriteLine();

            musteriManager.MusteriSilme(musteri1);
            musteriManager.MusteriSilme(musteri2);
            musteriManager.MusteriSilme(musteri3);
            Console.WriteLine();

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id" + musteri.Id);
                Console.WriteLine("Müşteri Adı:" + musteri.Ad);
                Console.WriteLine("Müşteri Soyadı:" + musteri.Soyad);
                Console.WriteLine("Müşteri Adresi:" + musteri.Adres);
                Console.WriteLine("Müşteri Telefon:" + musteri.TelNo);

                Console.WriteLine();
            }

        }
    }
}
