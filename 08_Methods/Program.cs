using System;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Parametresiz Void Metotlar

            //()
            //Geriye deger dondurmeyen metotlar
            //Customer --> Listele, ekle, sil, guncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 5;
            //    int y = 10;
            //    int total = x + y;
            //    Console.WriteLine("Toplam: " + total);
            //}

            //Sum();



            #endregion

            #region String Parametreli Void Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomrtCard(string name, string surName)
            //{
            //    Console.WriteLine($"Müşteri: {name} {surName}"); 
            //}

            //CustomrtCard("Ali", "Yıldız");

            #endregion

            #region Int Parametreli Void Metotlar

            //void Sum(int num1, int num2, int num3)
            //{
            //    int total = num1 + num2 + num3;
            //    Console.WriteLine($"Total : {total}");
            //}

            //Sum(5, 10, 15);


            #endregion

            #region Deger Donduren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";

            //    return name + " " + surName;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Deger Donduren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = $"Ülke : {countryName} \nBaşkent : {capital} \nBayrak Rengi : {flagColor}";
            //    return cardInfo;
            //}

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı - Beyaz"));

            #endregion

            #region Deger Donduren Int Parametreli Metotlar

            //int Sum(int num1, int num2)
            //{
            //    int result = num1 + num2;
            //    return result;
            //}

            //Console.WriteLine(Sum(55, 45));

            #endregion

            #region Ornek Uygulama
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3)/3;
                if (result >= 50)
                {
                    return $"{student} isimli öğrenci geçti. Ortalama : {result}";
                }
                else
                {
                    return $"{student} isimli öğrenci kaldı. Ortalama : {result}";
                }
            }

            Console.WriteLine(ExamResult("Ali", 50, 60, 70));
            Console.WriteLine(ExamResult("Ayşe", 30, 40, 50));

            #endregion

            Console.Read();



        }
    }
}
