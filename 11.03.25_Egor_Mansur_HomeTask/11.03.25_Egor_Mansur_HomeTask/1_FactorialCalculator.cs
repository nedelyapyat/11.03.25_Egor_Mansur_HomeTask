using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._03._25_Egor_Mansur_HomeTask
{/// <summary>
 /// Класс для вычисления факториала числа.
 /// </summary>
    public class FactorialCalculator
    {
        /// <summary>
        /// Функция для вычисления факториала числа с помощью рекурсии.
        /// </summary>
        /// <param name="n">Целое число, для которого нужно вычислить факториал.</param>
        /// <returns>Факториал числа n.</returns>
        public int CalculateFactorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * CalculateFactorial(n - 1);
        }
    }
}
