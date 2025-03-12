using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._03._25_Egor_Mansur_HomeTask
{/// <summary>
 /// Класс для вычисления площади круга.
 /// </summary>
    public class CircleAreaCalculator
    {
        /// <summary>
        /// Функция для вычисления площади круга по заданному радиусу.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        /// <returns>Площадь круга.</returns>
        public double CalculateArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

}
