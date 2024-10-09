using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yildiz olusturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana 10 tane yildiz olusturma
            //for (int i = 1;i<= 10;i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region 10x10 yildiz olusturma
            //for ( int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Dik ucgen yildiz

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Dik Ucgen

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Yansima Dik Ucgen
            //for (int i = 5; i>= 0; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 5;k>= i; k--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            #endregion

            #region Dik ve ters ucgen beraber
            //for(int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int k = 4; k >= 1; k--)
            //{
            //    for(int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Dilimi
            //üst kısım
            //int n = 5;
            //for(int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            ////alt kısım
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for(int j = n - 1; j > 0 ; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for(int k = 1;k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Piramit 

            //int n = 5;
            //for (int i = 1;i<= n;i++)
            //{
            //    //boşluklar
            //    for (int j = n; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i -1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters piramit

            //int n = 5;

            //for (int i = n; i >= 1; i--)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for(int k = 1; k <= 2*i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            Console.Read();
        }
    }
}
