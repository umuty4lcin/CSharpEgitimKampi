using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region YazdirmaKomutlari


            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");


            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Afiyet Olsun *****");  

            #endregion

            #region String Degiskenler

            //string name;

            //name = "Umut";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Göktuğ";
            //customerSurname = "Yavuz";
            //customerPhone = "+90 500 111 22 33";
            //customerEmail = "goktugyvz@gmail.com";
            //district = "Kağıthane";
            //city = "İstanbul";


            //Console.WriteLine("**** Rezervasyon Kartı ****\n");
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim : " + customerPhone);
            //Console.WriteLine("Email Adresi : " + customerEmail);
            //Console.WriteLine("Adres : " + district + "/" + city);
            //Console.WriteLine("-----------------------------------");





            #endregion

            #region Int Degiskenler

            int number = 24;
            Console.WriteLine(number);

            int hamburgerPrice = 350;
            int cokePrice = 40;
            int waterPrice = 15;
            int friesPrice = 60;
            int pizzaPrice = 275;
            int lemonadePrice = 45;


            Console.WriteLine("***** Restoram Menü *****\n");

            Console.WriteLine("----- Hamburger Fiyatı : " + hamburgerPrice + "TL");
            Console.WriteLine("----- Pizza Fiyatı : " + pizzaPrice + "TL");
            Console.WriteLine("----- Kızartma Fiyatı : " + friesPrice + "TL");
            Console.WriteLine("----- Limonata Fiyatı : " + lemonadePrice + "TL");
            Console.WriteLine("----- Su Fiyatı : " + waterPrice + "TL");
            Console.WriteLine("----- Kola Fiyatı : " + cokePrice + "TL");

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;
            int generalTotal = 0;


            int hamburgerCount = 3;
            int cokeCount = 1;
            int waterCount = 3;
            int friesCount = 1;
            int pizzaCount = 1;
            int lemonadeCount = 2;

            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalFriesPrice = friesPrice * friesCount;
            totalCokePrice = cokePrice * cokeCount;
            totalWaterPrice = waterPrice * waterCount;
            totalLemonadePrice = lemonadePrice * lemonadeCount;
            generalTotal = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine("***** Hesap *****");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Hamburger Tutarı : " + totalHamburgerPrice + "TL");
            Console.WriteLine("Pizza Tutarı : " + totalPizzaPrice + "TL");
            Console.WriteLine("Kızartma Tutarı : " + totalFriesPrice + "TL");
            Console.WriteLine("Limonata Tutarı : " + totalLemonadePrice + "TL");
            Console.WriteLine("Su Tutarı : " + totalWaterPrice + "TL");
            Console.WriteLine("Kola Tutarı : " + totalCokePrice + "TL\n");
            Console.WriteLine("Genel Toplam : " + generalTotal + "TL");
            #endregion

            Console.Read();
        }
    }
}


