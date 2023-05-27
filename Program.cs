using System;

namespace metotlar_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            //int outsayi yaparak fonksiyonun dışında da tanımlayabiliriz
            bool sonuc = int.TryParse(sayi, out int outsayi);
            if(sonuc)
            {
                Console.WriteLine("Başarili");
                Console.WriteLine(outsayi);
            }
            else{
                Console.WriteLine("Başarısız");
            }
            Metotlar instance = new Metotlar();
            instance.topla(4,5,out int toplamSonuc);
            Console.WriteLine(toplamSonuc); 

            //Metot Aşırı yükleme - Overloading

            int ifade = 999;
            instance.EkranaYazdir(ifade);

            //Metot imzası
            //Metot adı +parametre sayısı + parametre
            instance.EkranaYazdir("salih","muhammed");
        }
    }
    class Metotlar
    {
        public void topla(int a, int b,out int toplam )
        {
            toplam = a+b;
        }
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
          public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
         public void EkranaYazdir(string veri, string veri2)
        {
            Console.WriteLine(veri + veri2);
        }

    }
}