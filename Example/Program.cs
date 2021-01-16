using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {

           Urun urun1 = new Urun();
            urun1.ÜrünAdı = "Kızma Bilader";
            urun1.ÜrünFiyatı = 49;
            urun1.ÜrünİndirimliFiyatı= 29;

            Urun urun2 = new Urun();
            urun2.ÜrünAdı = "amiral battı";
            urun2.ÜrünFiyatı = 69;
            urun2.ÜrünİndirimliFiyatı = 39;

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.ÜrünAdı +":"+ urun.ÜrünFiyatı+ "indirimli fiyat" + urun.ÜrünİndirimliFiyatı);
            }
            

            
        }
    }

    class Urun
    {
        public string ÜrünAdı { get; set; }
        public int ÜrünFiyatı { get; set; }
        public int ÜrünİndirimliFiyatı { get; set; }
    }
}
