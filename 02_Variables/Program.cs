using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Degiskenler
            //double number;
            //number = 6.56;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Lisetesi *****\n");

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.25;
            //orangePrice = 22.5;
            //strawberryPrice = 45;
            //potatoPrice = 12.75;
            //tomatoPrice = 6.65;

            //Console.WriteLine("------- Elma birim fiyatı : " + applePrice + "TL");
            //Console.WriteLine("------- Portakal birim fiyatı : " + orangePrice + "TL");
            //Console.WriteLine("------- Çilek birim fiyatı : " + strawberryPrice + "TL");
            //Console.WriteLine("------- Patates birim fiyatı : " + potatoPrice + "TL");
            //Console.WriteLine("------- Domates birim fiyatı : " + tomatoPrice + "TL");
            //Console.WriteLine();
            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;

            //appleGram = 1.250;
            //orangeGram = 2.250;
            //strawGram = 0.750;
            //potatoGram = 3.650;
            //tomatoGram = 4.112;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawTotalPrice = strawberryPrice * strawGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;
            //double totalPrice=0;

            //Console.WriteLine("Alınan Ürün : Elma     - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + "  - Toplam tutar: " + appleTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün : Portakal - " + "Birim Fiyat: " + orangePrice +"  - Gramaj: " + orangeGram + "  - Toplam tutar: " + orangeTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün : Çilek    - " + "Birim Fiyat: " + strawberryPrice + "    - Gramaj: " + strawGram + "  - Toplam tutar: " + strawTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün : Patates  - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + "  - Toplam tutar: " + potatoTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün : Domates  - " + "Birim Fiyat: " + tomatoPrice + "  - Gramaj: " + tomatoGram + " - Toplam tutar: " + tomatoTotalPrice + " TL");

            //totalPrice = appleTotalPrice + orangeTotalPrice + strawberryPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("\n\n");
            //Console.WriteLine("Toplam tutar : " + totalPrice + " TL");

            #endregion

            #region Char Degiskenler

            //char symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girisleri String Degiskenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****\n");

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIDNumber;

            //Console.Write("Yolcunun Kimlik Numarası : ");
            //passengerIDNumber = Console.ReadLine();

            //Console.Write("Yolcu Adı : ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı : ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcunun Yaşı : ");
            //passengerAge = Console.ReadLine();

            //Console.Write("İlçe Bilgisi : ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi : ");
            //passengerCity = Console.ReadLine();


            //Console.WriteLine($"Yolcu Kimlik Numarası : {passengerIDNumber} / Yolcu Adı ve Soyadı : {passengerName} {passengerSurname} / Yolcu Yaşı : {passengerAge} / Yolcu Adresi : {passengerDistrict}/{passengerCity}");


            #endregion

            #region Klavyeden Tam Sayi Girisleri ve Donusumler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12500;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Aldığınız ayakkabı sayısını giriniz : ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız bilgisayar sayısını giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız sandalye sayısını giriniz : ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız tv sayısını giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());


            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvCount;
            //Console.WriteLine("\nToplam Ödenecek Tutar : " + totalPrice);

            #endregion


            #region Klavyeden Ondalikli Sayi Islemleri

            //double exam1, exam2, exam3;
            //Console.Write("İlk sınav notunu giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("İkinci sınav notunu giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Üçüncü sınva notunu giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //double averageExams = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("\nSınav notu ortalamanız : " + averageExams);

            #endregion

            #region Klavyeden Karakter Girisi

            //char gender;

            //Console.Write("Lütfen Cinsiyet Seçiniz : ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("\nSeçilen Cinsiyet : " + gender);
            
            #endregion

            Console.Read();

        }
    }
}
