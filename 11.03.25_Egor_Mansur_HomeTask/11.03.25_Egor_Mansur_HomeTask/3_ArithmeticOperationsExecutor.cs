using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._03._25_Egor_Mansur_HomeTask
{/// <summary>
 /// Класс для выполнения основных арифметических операций.
 /// </summary>
    public class ArithmeticOperationsExecutor
    {
        /// <summary>
        /// Функция для выполнения основных арифметических операций с двумя числами.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <returns>Результаты основных арифметических операций: сумма, разность, произведение и частное.</returns>
        public (double sum, double difference, double product, double quotient) ExecuteOperations(double a, double b)
        {
            double sum = a + b;
            double difference = a - b;
            double product = a * b;
            double quotient = b != 0 ? a / b : double.NaN; // Обработка деления на ноль

            return (sum, difference, product, quotient);
        }
    }

}
