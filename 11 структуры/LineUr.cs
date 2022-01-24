using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_структуры
{
    struct LineUr
    {
        private readonly double k;
        private readonly double b;
        private string answer;
        public LineUr(double k, double b)
        {
            this.k = k;
            this.b = b;
            answer = "";
        }
        public void Root()
        {
            if (k == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Уравнение с заданными параметрами имеет бесконечное количество решений.");
                }
                else
                {
                    Console.WriteLine("Уравнение с заданными параметрами не имеет решений в вещетвенных числах.");
                }
            }
            else
            {
                answer = string.Format("{0:f6}", (-b / k));
                Console.WriteLine($"Решение уравнения 0 = ({k})x + ({b}) найдено. x = {answer} ");
            }
        }
    }
}
