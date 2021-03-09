// author : Bombong Nur Margo Seto (20.11.3358)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            int selectMenu = SelectMenu();
            if (selectMenu < 1 || selectMenu > 4)
            {
                Console.WriteLine();
                Console.WriteLine("Maaf, menu yang pilih tidak tersedia");
                ExitProgram();
            }

            Console.WriteLine();
            Console.Write("Masukan nilai a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Masukan nilai b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (selectMenu == 1) Console.WriteLine($"Hasil pengurangan {a} - {b} = {pengurangan(a, b)}");
            else if (selectMenu == 2) Console.WriteLine($"Hasil penambahan {a} + {b} = {penambahan(a, b)}");
            else if (selectMenu == 3) Console.WriteLine($"Hasil pembagian {a} / {b} = {pembagian(a, b)}");
            else Console.WriteLine($"Hasil perkalian {a} * {b} = {perkalian(a, b)}");

            ExitProgram();
        }

        static int SelectMenu()
        {
            Console.WriteLine("Pilih menu calculator");

            Console.WriteLine();
            Console.WriteLine("1. pengurangan");
            Console.WriteLine("2. Penambahan");
            Console.WriteLine("3. Pembagian");
            Console.WriteLine("4. Perkalian");

            Console.WriteLine();
            Console.Write("Pilih [1...4]: ");

            return int.Parse(Console.ReadLine());
        }

        static int Penambahan(int a, int b) => a + b;

        static int Pengurangan(int a, int b) => a - b;

        static int Perkalian(int a, int b) => a * b;

        static double Pembagian(int a, int b) => (double) a / b;

        static void ExitProgram()
        {
            Console.WriteLine();
            Console.WriteLine("Tekan sembarang key untuk keluar");
            Console.ReadKey();

            Environment.Exit(0);
        }
    }
}