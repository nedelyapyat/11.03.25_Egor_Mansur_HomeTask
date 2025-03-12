using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._03._25_Egor_Mansur_HomeTask
{/// <summary>
 /// Класс для выполнения сложения с намеренной логической ошибкой.
 /// </summary>
    public class FaultyAdditionExecutor
    {
        /// <summary>
        /// Функция с намеренной логической ошибкой для демонстрации процесса отладки.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <returns>Результат сложения двух чисел.</returns>
        public int ExecuteAddition(int a, int b)
        {
            return a - b; // Ошибка: вместо сложения выполняется вычитание
        }
    }
}
