using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._03._25_Egor_Mansur_HomeTask
{/// <summary>
 /// Класс для возведения числа в целую степень.
 /// </summary>
    public class PowerCalculator
    {
        /// <summary>
        /// Функция для возведения числа в целую степень.
        /// </summary>
        /// <param name="baseNumber">Основание степени.</param>
        /// <param name="exponent">Показатель степени.</param>
        /// <returns>Результат возведения в степень.</returns>
        public double CalculatePower(double baseNumber, int exponent)
        {
            double result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }
            return result;
        }
    }
}
