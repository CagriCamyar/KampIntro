﻿using System;
using System.Runtime.Serialization.Formatters;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
             string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
             string kurs3 = "Java";*/

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs", "Java", "Python", "C++" };
            Console.WriteLine(kurslar.Length);

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Foreach Bitti");

            Console.WriteLine("Sayfa Sonu");


        }
    }

}
