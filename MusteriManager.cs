using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi:" +" "+ musteri.Ad );
            //Console.WriteLine("Müşteri Eklendi:" +" "+ musteri.Soyad );
            //Console.WriteLine("Müşteri Eklendi:" + " " + musteri.Adres );
            //Console.WriteLine("Müşteri Eklendi:" + " " + musteri.TelNo );
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi- " + musteri.Ad);
        }
        public void MusteriListeleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listesi: " + musteri.Ad);
        }
    }
}
