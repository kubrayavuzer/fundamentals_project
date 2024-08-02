
using System;


namespace Fundamentals_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RASTGELE SAYI BULMA OYUNU

            //rastgele sayı girişi iste
            Random random = new Random();
            int hedef = random.Next(1, 100);
            int can = 5;
            Console.WriteLine("Rastgele sayı bulma oyununa hoş geldiniz! Lütfen bir sayı giriniz.");
            Console.WriteLine("Bu oyunda 5 canınız bulunmaktadır. Tahmin edeceğiniz sayı 1 ve 100 arasında olmalıdır.");

            while (can > 0)
            {
                Console.WriteLine("Tahmininizi giriniz: ");
                string cikis = Console.ReadLine();


                if (int.TryParse(cikis, out int tahmin)) 
                {


                    if (tahmin < 1 || tahmin > 100)
                    {
                        Console.WriteLine("1 ile 100 arasında bir sayı giriniz.");
                    }

                    else if (tahmin == hedef)
                    {
                        Console.WriteLine("Doğru tahmin!");
                        break;
                    }
                    else if (tahmin < hedef)
                    {
                        Console.WriteLine("Daha büyük bir sayı giriniz!");

                    }
                    else
                    {
                        Console.WriteLine("Daha küçük bir sayı giriniz!");

                    }

                    can--;
                    Console.WriteLine($"Kalan canınız: {can}");
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
                }

            }
            if (can == 0)
            {
                Console.WriteLine($"Kaybettiniz! Doğru sayı: {hedef}");
            }

            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
            }

            Console.WriteLine("-------------------------------------------------");


            //Hesap Makinesi

            Console.WriteLine("Hesap makinesine hoş geldiniz!");
            Console.WriteLine("Lütfen ilk sayıyı giriniz.");
            //Dönüşüm yapıldı
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("Toplama için + \nÇıkarma için - \nÇarpma için *\nBölme için / \n ifadelerinden birini seçiniz");
            //kullanıcının yapmak istediği matematiksel işlemi belirtmek için bir karakter girmesini sağla
            char islem = Convert.ToChar(Console.ReadLine());

            double sonuc = 0;
            bool islemyap = true;


            switch (islem)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("Toplama işlemi seçtiniz.");
                    Console.WriteLine($"Sonuç: {sonuc}");
                    break;

                case '-':
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine("Çıkarma işlemi seçtiniz.");
                    Console.WriteLine($"Sonuç: {sonuc}");
                    break;

                case '*':
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine("Çarpma işlemi seçtiniz.");
                    Console.WriteLine($"Sonuç: {sonuc}");
                    break;

                case '/':

                    if (sayi2 == 0)
                    {
                        Console.WriteLine("0 a bölünme hatası");
                    }
                    else 
                    {
                        sonuc = (double)sayi1 / sayi2;
                        Console.WriteLine("Bölme işlemi seçtiniz.");
                    }

                    
                    break;

                default:
                    Console.WriteLine("Geçersiz işlem!");
                    islemyap = false;
                    break;

            }

            Console.WriteLine("-------------------------------------------------");

            //Kullanıcıdan notlarının girişini iste

            Console.WriteLine("Harf notu hesaplamak için 3 adet notunuzu giriniz.");

            Console.WriteLine("Lütfen ilk ders notunuzu giriniz.");
            //alınan sayıyı double türüne dönüştür
            double not1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lütfen ikinci ders notunuzu giriniz.");
            double not2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lütfen üçüncü notunuzu giriniz.");
            double not3 = Convert.ToDouble(Console.ReadLine());

            //Notların geçerliliği kontrol edilir
            if (not1 < 0 || not2 > 100 || not2 < 0 || not2 > 100 || not3 < 0 || not3 > 100)
            {
                Console.WriteLine("Notlarınızı 0 ile 100 arasında giriniz!");
                return;
            }

            //Notların ortalamasını hesaplama
            double ortalama = (not1 + not2 + not3) / 3.0;
            Console.WriteLine($"Notlarınızın ortlaması: {ortalama}");

            //Harf notu belirleme

            string harfNotu;

            if (ortalama >= 90)
                harfNotu = "AA";
            else if (ortalama >= 85)
                harfNotu = "BA";
            else if (ortalama >= 80)
                harfNotu = "BB";
            else if (ortalama >= 75)
                harfNotu = "CB";
            else if (ortalama >= 70)
                harfNotu = "CC";
            else if (ortalama >= 65)
                harfNotu = "DC";
            else if (ortalama >= 60)
                harfNotu = "DD";
            else if (ortalama >= 55)
                harfNotu = "FD";
            else
                harfNotu = "FF";

            //Harf notunu yazdır

            Console.WriteLine($"Harf notu: {harfNotu}");

        }

    }


}



