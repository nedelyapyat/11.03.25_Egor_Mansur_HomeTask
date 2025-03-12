using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._03._25_Egor_Mansur_HomeTask
{/// <summary>
 /// Класс для вывода таблицы умножения.
 /// </summary>
    public class MultiplicationTablePrinter
    {
        /// <summary>
        /// Функция для вывода таблицы умножения для заданного числа.
        /// </summary>
        /// <param name="number">Число, для которого нужно вывести таблицу умножения.</param>
        public void PrintTable(int number)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}
