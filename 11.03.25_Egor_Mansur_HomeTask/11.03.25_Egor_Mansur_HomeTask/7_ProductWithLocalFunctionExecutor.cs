using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._03._25_Egor_Mansur_HomeTask
{/// <summary>
 /// Класс для вычисления произведения чисел с использованием локальной функции.
 /// </summary>
    public class ProductWithLocalFunctionExecutor
    {
        /// <summary>
        /// Функция для вычисления произведения чисел.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <returns>Произведение чисел.</returns>
        public int ExecuteProduct(int a, int b)
        {
            int Multiply(int x, int y)
            {
                return x * y;
            }
            return Multiply(a, b);
        }
    }
}
