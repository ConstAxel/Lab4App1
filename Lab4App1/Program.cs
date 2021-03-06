using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4App1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления следующую формулу: N2=1 + 3 + 5 + ... + (2*N – 1).
            // После добавления к сумме каждого слагаемого выводить текущее значение суммы (в результате будут выведены квадраты всех целых чисел от 1 до N).
            int sum = 0;
            Console.WriteLine("Введите число N> 0:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"N2(Квадрат):{Math.Pow(n, 2)}:");
            Console.WriteLine("Условие:N2 = 1 + 3 + 5 + ... +(2 * N – 1)");
            for (int i = 1; i <= (2 * n - 1); i += 2)   
            {
                
                sum = sum + i;
                Console.WriteLine($"#)Сумма слагаемых:{sum}\t");
            }
            Console.ReadKey();
        }
    }
}
