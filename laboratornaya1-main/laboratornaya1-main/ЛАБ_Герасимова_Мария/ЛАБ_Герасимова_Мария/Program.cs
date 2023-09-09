using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛАБ_Герасимова_Мария
{
    class Program
    {
        static void Main(string[] args)
            
        {
            sbyte a = 100;
            sbyte b = Math.Abs(a);
            Console.WriteLine(a);

            sbyte d = 90;
            sbyte f = 91;
            sbyte maximum = Math.Max(d, f);
            Console.WriteLine(d);
            Console.WriteLine(f);

            double x = 9;
            double koren = Math.Sqrt(x);
            Console.WriteLine(x);

            double y = 3.5;
            double tselaya_chast = Math.Truncate(y);
            Console.WriteLine(y);

            //Задание номер 4
            //Вычислить целочисленный остаток от деления ыыедённого значения на 8 двумя способами.


            //1 способ

            double num1 = Int32.Parse(Console.ReadLine());
            double num2 = 8;

            var formula =num1 % num2 ;

            Console.WriteLine($"Остаток от деления : {formula}");

            //2 способ

            int value1= Int32.Parse(Console.ReadLine());
            int value2 = 8;
            int ostatok;
            int chastnoe;

            chastnoe = Math.DivRem(value1, value2, out ostatok);
            Console.WriteLine($"Значение 1 и 2 : ({value1}, {value2}), остаток от деления : {ostatok}, частное : {chastnoe}");


            Console.ReadKey();

        }

    }
}
