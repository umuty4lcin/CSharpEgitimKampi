using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Dongusu

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 32, 66, 84, 67, 11, 23, 48 };
            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int[] numbers = { 45, 32, 66, 84, 67, 11, 23, 48, 568, 777, 69853 };

            //int total = 0;
            //foreach(int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine(numbers[2]);

            //string word = "hello world :)";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Ornek Sinav Sistemi Uygulamasi

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****\n\n");
            Console.WriteLine("---------------------------------------------");

            //Sinifdali öğrenci sayısını kullanıcıdan alma
            Console.Write("Sınıfınızda kaç öğrenci var : ");
            int studentCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");

            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];


            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin adını giriniz : ");
                
                studentNames[i] = Console.ReadLine();
                Console.WriteLine();

                double totalExemResult = 0;

                //Her öğrenci için 3 sınav notu girişi

                for(int j = 0; j<3; j++)
                {

                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notu giriniz : ");
                    totalExemResult += Convert.ToDouble(Console.ReadLine());
                }

                studentExamAvg[i] = totalExemResult/3;
                Console.WriteLine("-----------------------------------------------\n");
            }

            for (int k = 0; k < studentCount; k++)
            {
                if(studentExamAvg[k] < 0 || studentExamAvg[k] > 100)
                {
                    Console.WriteLine($"{studentNames[k]} isimli öğrencinin notlarında hatalı giriş olmuştur!");
                }

                else if(studentExamAvg[k] < 50)
                {
                    Console.WriteLine($"{studentNames[k]} adlı öğrencinin sınav notu ortalaması : {studentExamAvg[k]} ders durumu : kaldı ");
                }
                else
                {
                    Console.WriteLine($"{studentNames[k]} adlı öğrencinin sınav notu ortalaması : {studentExamAvg[k]} ders durumu : geçti ");

                }
            }

            #endregion

            Console.Read();
        }
    }
}
