using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._03._25_Egor_Mansur_HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FactorialCalculator factorialCalculator = new FactorialCalculator();
            Console.WriteLine("1) Факториал 5: " + factorialCalculator.CalculateFactorial(5));

            MultiplicationTablePrinter multiplicationTablePrinter = new MultiplicationTablePrinter();
            Console.WriteLine("2) Таблица умножения для 3:");
            multiplicationTablePrinter.PrintTable(3);

            ArithmeticOperationsExecutor arithmeticOperationsExecutor = new ArithmeticOperationsExecutor();
            var operations = arithmeticOperationsExecutor.ExecuteOperations(10, 2);
            Console.WriteLine($"3) Сумма: {operations.sum}, Разность: {operations.difference}, Произведение: {operations.product}, Частное: {operations.quotient}");

            CircleAreaCalculator circleAreaCalculator = new CircleAreaCalculator();
            Console.WriteLine("4) Площадь круга с радиусом 3: " + circleAreaCalculator.CalculateArea(3));

            StringToNumberConverter stringToNumberConverter = new StringToNumberConverter();
            Console.WriteLine("5) Преобразование строки '123.45': " + stringToNumberConverter.ConvertToNumber("123.45"));

            FaultyAdditionExecutor faultyAdditionExecutor = new FaultyAdditionExecutor();
            Console.WriteLine("6) Результат сложения с ошибкой: " + faultyAdditionExecutor.ExecuteAddition(10, 5));

            ProductWithLocalFunctionExecutor productWithLocalFunctionExecutor = new ProductWithLocalFunctionExecutor();
            Console.WriteLine("7) Произведение 3 и 4: " + productWithLocalFunctionExecutor.ExecuteProduct(3, 4));

            PowerCalculator powerCalculator = new PowerCalculator();
            Console.WriteLine("8) 2 в степени 3: " + powerCalculator.CalculatePower(2, 3));

            Console.ReadKey();
        }
    }
}
