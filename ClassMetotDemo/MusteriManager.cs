using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle (Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + "Listeye eklendi");
        }



        public void Sil (Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " Id ye ait müsteri silidi");

        }



        public void Listele(Musteri musteri)
        {

            Console.WriteLine("Eklenen müşteriler listelendi!");
            Console.WriteLine("-" + musteri.Adi);

        }




    }
    }

