﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasCalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10; //deklarasi variabel a, dengan nilai awal 10
            //var b = 6; //deklarasi variabel  b, dengan nilai awal 6

            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine()); //proses casting

            Console.Write("Inputkan nilai b = ");
            var b = Convert.ToInt32(Console.ReadLine()); //proses casting

            Console.WriteLine(); //tambahkan baris kosong

            Console.Title = "Aplikasi Calculator Versi Console";
            Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pengurangan(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}

