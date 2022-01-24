using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _11_структуры
{
    class Program
    {
        static void Main(string[] args)
        {
            double k = 0, b = 0;
            WriteLine("Введите коэффициенты уравнения вида 0 = kx + b :");
            BK:
            try
            {
            Write("k = ");
            k = Convert.ToDouble(ReadLine());
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                goto BK;
            }
            BB:
            try
            {
                Write("b = ");
                b = Convert.ToDouble(ReadLine());
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                goto BB;
            }
            LineUr answ = new LineUr(k, b);
            answ.Root();
            ReadKey();
        }
    }
}
