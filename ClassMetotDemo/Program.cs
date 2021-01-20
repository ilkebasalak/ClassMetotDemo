using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Dicle";
            musteri1.Yas = 28;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Meri";
            musteri2.Yas = 25;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Büşra";
            musteri3.Yas = 26;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };


            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Yas);
                Console.WriteLine(musteri.Id);

                
                Console.WriteLine("------------------");
            }

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri3);
            musteriManager.Sil(musteri1);
            musteriManager.Listele(musteri2);




            
              
             








        }
    }
}
