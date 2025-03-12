using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._03._25_Egor_Mansur_HomeTask
{/// <summary>
 /// Класс для преобразования строки в число.
 /// </summary>
    public class StringToNumberConverter
    {
        /// <summary>
        /// Функция для попытки преобразования строки в число.
        /// </summary>
        /// <param name="input">Строка, которую нужно преобразовать в число.</param>
        /// <returns>Преобразованное число или null в случае неудачного преобразования.</returns>
        public double? ConvertToNumber(string input)
        {
            if (double.TryParse(input, out double result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Ошибка: не удалось преобразовать строку в число.");
                return null;
            }
        }
    }
}
