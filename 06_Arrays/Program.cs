﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Ornekleri
            //degiskenTuru[] DiziAdi = new DegiskenTuru[ElemanSayisi]
            //
            //string[] colors = new string[4];
            //colors[0] = "Red";
            //colors[1] = "Yellow";
            //colors[2] = "White";
            //colors[3] = "Blue";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";
            //Console.WriteLine(cities[5]);

            //int[] numbers = new int[10];

            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;

            //numbers[7] = 748;
            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);


            #endregion

            #region Dizideki Tum Elemanlari Listeleme

            //string[] colors = { "Yellow", "Red", "White", "Blue", "Green", "Orange", "Pink" };

            //for(int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0];

            //for (int i = 1;i<myArray.Length;i++)
            //{
            //    if(myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }

            //}
            //Console.WriteLine(maxNumber);


            //Array Sort

            //int[] numberArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //for (int j = 0; j < numberArray.Length; j++)
            //{
            //    int maxValue = numberArray[0];
            //    int temp;

            //    for (int i = 1; i < numberArray.Length; i++)
            //    {
            //        if (maxValue > numberArray[i])
            //        {
            //            temp = numberArray[i];
            //            numberArray[i] = maxValue;
            //            numberArray[i - 1] = temp;
            //        }
            //        else
            //        {
            //            maxValue = numberArray[i];
            //        }
            //    }

            //}

            //for (int i = 0; i < numberArray.Length; i++)
            //{
            //    Console.WriteLine(numberArray[i]);
            //}

            //Array Sort 

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region Dizi Metotlari

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "buse");
            //Console.WriteLine(index);

            //int[] numbers = { 45,85,96,63,74,10,25,22,36};
            //Console.WriteLine($"Dizinin en büyük elemanı : {numbers.Max()}, Dizinin en küçük elemanı : {numbers.Min()}");

            #endregion

            #region Kullanicidan Deger Alma 

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. şehri giriniz : ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine("\n\n---------------------------------");

            //for(int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };
            
            //Console.WriteLine("Çift Sayılar\n");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("\n\nTek Sayılar\n");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            #endregion

            Console.Read();

        }
    }
}
