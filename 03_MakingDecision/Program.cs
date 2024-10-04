using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.WriteLine("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else 
            //{ 
            //    Console.WriteLine("Şifre Yanlış");
            //}


            //string capital, country;
            //Console.Write("Başkenti giriniz : ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz : ");
            //country = Console.ReadLine();

            //if (capital == "Ankara" & country == "Türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi");
            //}

            //int number;
            //Console.Write("Sayı giriniz : ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 6)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.Write("Sayı yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result;

            //Console.Write("Sınav 1 :");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2 :");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3 :");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine($"Sınavların ortalaması {average}");

            //if (average > 0 & average < 49)
            //{
            //    result = "Sonuç vasat";
            //}

            //else if (average >= 49   & average < 69)
            //{
            //    result = "Sonuç orta";
            //}
            //else if (average >= 69 & average < 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //else if (average >= 84 & average <=100)
            //{
            //    result = "Sonuç çok iyi";
            //}
            //else
            //{
            //    result = "Hata! Girilen notları tekrar kontrol ediniz.";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Şehir giriniz : ");
            //city = Console.ReadLine();

            //if (city == "Adana" | city == "Ankara" | city == "Kayseri" | city == "İstanbul")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.Write("Kullanıcı adınızı giriniz : ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı adı hatalı");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}

            #endregion

            #region Mod Islemleri

            //int number;
            //number = 27;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen birinci sayıyı giriniz : ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sayıyı giriniz : ");
            //int num2 = int.Parse(Console.ReadLine());

            //int result = num1 % num2;
            //Console.WriteLine($"1. Sayının 2.Sayıya bölümünden kalan {result}");

            //Console.Write("Tek sayı mı çift sayı mı olduğunu öğrenmek istediğiniz sayıyı giriniz :  ");
            //int number = int.Parse(Console.ReadLine());

            //if (number < 0)
            //{
            //    Console.WriteLine("Hata! Negatif bir sayı girdiniz.");
            //}
            //else if (number % 2 == 0) 
            //{
            //    Console.WriteLine("Girilen sayı çift sayıdır");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen sayı tek sayıdır");
            //}

            #endregion

            #region Char Degiskenler Ile Karar Yapilari
            //char team;
            //Console.Write("Takım sembolünü giriniz : ");
            //team = Char.Parse(Console.ReadLine());

            //if(team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else
            //{
            //    Console.WriteLine("Hata"); 
            //}

            #endregion

            #region Ornek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******\n");
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("1 - Çorbalar");
            //Console.WriteLine("2 - Ana Yemekler");
            //Console.WriteLine("3 - Pizzalar");
            //Console.WriteLine("4 - İçecekler");
            //Console.WriteLine("5 - Tatlılar");
            //Console.WriteLine("--------------------------------\n");

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi : ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine("\n-------Çorbalar--------\n");
            //    Console.WriteLine("1 - Mercimek");
            //    Console.WriteLine("2 - Ezogelin");
            //    Console.WriteLine("3 - Domates");
            //    Console.WriteLine("4 - Brokoli");
            //    Console.WriteLine("\n-------Çorbalar--------\n");
            //}
            //else if(menuItem == "2")
            //{
            //    Console.WriteLine("\n--------Ana Yemekler--------\n");
            //    Console.WriteLine("1 - Kremalı Mantarlı Makarna");
            //    Console.WriteLine("2 - Kızartma Tabağı");
            //    Console.WriteLine("3 - Tavuk Pilav");
            //    Console.WriteLine("4 - Nohut Pilav");
            //    Console.WriteLine("\n--------Ana Yemekler--------\n");
            //}
            //else if (menuItem == "3")
            //{
            //    Console.WriteLine("\n--------Pizzalar--------\n");
            //    Console.WriteLine("1 - Karışık");
            //    Console.WriteLine("2 - Meksika");
            //    Console.WriteLine("3 - Marhgerita");
            //    Console.WriteLine("\n--------Pizzalar--------\n");
            //}
            //else if (menuItem == "4")
            //{
            //    Console.WriteLine("\n--------İçecekler--------\n");
            //    Console.WriteLine("1 - Su");
            //    Console.WriteLine("2 - Kola");
            //    Console.WriteLine("3 - Ayran");
            //    Console.WriteLine("\n--------İçecekler--------\n");
            //}
            //else if (menuItem == "5")
            //{
            //    Console.WriteLine("\n--------Tatlılar--------\n");
            //    Console.WriteLine("1 - Suffle");
            //    Console.WriteLine("2 - Baklava");
            //    Console.WriteLine("3 - Waffle");
            //    Console.WriteLine("\n--------Tatlılar--------\n");
            //}
            //else
            //{
            //    Console.WriteLine("Hata! Yanlış tuşlama yaptınız");
            //}


            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız : ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuze"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı veri girişi"); break;
            //}
            #endregion

            #region Switch Case Hesap Makinesi

            //int num1, num2, result;
            //char operation;

            //Console.Write("Birinci sayıyı giriniz : ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz : ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Yapılacak işlemi giriniz : ");
            //operation = Convert.ToChar(Console.ReadLine());

            //switch (operation)
            //{
            //    case '+': 
            //        result = num1 + num2;
            //        Console.WriteLine($"{num1} {operation} {num2} = {result}");
            //        break;

            //    case '-':
            //        result = num1 - num2;
            //        Console.WriteLine($"{num1} {operation} {num2} = {result}");
            //        break;

            //    case '*':
            //        result = num1 * num2;
            //        Console.WriteLine($"{num1} {operation} {num2} = {result}");
            //        break;

            //    case '/':
            //        result = num1 / num2;
            //        Console.WriteLine($"{num1} {operation} {num2} = {result}");
            //        break;
            //}

            #endregion

            Console.Read();
        }
    }
}
