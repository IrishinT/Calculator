using System;
using System.Collections.Generic;
using System.Globalization;

namespace CalculatorLogic
{
    /// <summary>
    /// Основной класс логики калькулятора.
    /// Реализует вычисления выражений через преобразование в Обратную Польскую Запись (RPN).
    /// </summary>
    public class Processor
    {
        /// <summary>
        /// Вычисляет математическое выражение, записанное в виде обычной (инфиксной) строки.
        /// </summary>
        /// <param name="expression">Строка с выражением (например, "10 + -2 * (3 - 1)")</param>
        /// <returns>Результат вычисления типа double.</returns>
        /// <exception cref="DivideByZeroException">Выбрасывается при попытке деления на ноль.</exception>
        /// <exception cref="Exception">Выбрасывается при синтаксических ошибках в выражении.</exception>
        public double Calculate(string expression)
        {
            try
            {
                // 1. Преобразуем обычную строку в формат RPN (Обратная польская запись)
                string rpnExpression = GetReversePolishNotation(expression);

                // 2. Считаем результат по RPN
                return CalculateRPN(rpnExpression);
            }
            catch (DivideByZeroException)
            {
                // Пробрасываем конкретную ошибку деления на ноль
                throw new DivideByZeroException("Деление на ноль невозможно!");
            }
            catch (Exception ex)
            {
                // Оборачиваем остальные ошибки
                throw new Exception("Ошибка в выражении: " + ex.Message);
            }
        }

        /// <summary>
        /// Определяет приоритет математических операций.
        /// Чем выше число, тем выше приоритет.
        /// </summary>
        /// <param name="s">Символ оператора.</param>
        /// <returns>Приоритет операции (byte).</returns>
        private byte GetPriority(char s)
        {
            switch (s)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 3;
                case '*': return 4;
                case '/': return 4;
                default: return 5;
            }
        }

        /// <summary>
        /// Преобразует инфиксную запись (2 + 2) в постфиксную (2 2 +).
        /// Алгоритм "Сортировочная станция" (Shunting-yard algorithm).
        /// Корректно обрабатывает унарный минус (отрицательные числа).
        /// </summary>
        /// <param name="input">Исходная строка выражения.</param>
        /// <returns>Строка выражения в формате RPN.</returns>
        private string GetReversePolishNotation(string input)
        {
            string output = string.Empty;
            Stack<char> operStack = new Stack<char>();

            // Удаляем все пробелы для упрощения анализа предыдущих символов
            input = input.Replace(" ", "");

            for (int i = 0; i < input.Length; i++)
            {
                // Проверка на унарный минус (отрицательное число).
                // Минус считается частью числа, если:
                // 1. Он стоит в самом начале выражения.
                // 2. Перед ним стоит открывающая скобка '('.
                // 3. Перед ним стоит любой другой оператор (например, 5 * -2).
                bool isUnaryMinus = false;
                if (input[i] == '-')
                {
                    if (i == 0) isUnaryMinus = true;
                    else if (input[i - 1] == '(') isUnaryMinus = true;
                    else if (IsOperator(input[i - 1]) && input[i - 1] != ')') isUnaryMinus = true;
                }

                // Если это цифра, разделитель дроби или унарный минус -> начинаем читать число
                if (Char.IsDigit(input[i]) || input[i] == ',' || input[i] == '.' || isUnaryMinus)
                {
                    // Если это минус, сразу добавляем его в вывод и сдвигаемся к следующей цифре
                    if (isUnaryMinus)
                    {
                        output += input[i];
                        i++;
                    }

                    // Читаем число до конца (пока идут цифры или точки/запятые)
                    while (i < input.Length && (Char.IsDigit(input[i]) || input[i] == ',' || input[i] == '.'))
                    {
                        output += input[i];
                        i++;
                    }

                    output += " "; // Добавляем пробел-разделитель после числа
                    i--; // Возвращаемся на шаг назад, так как цикл for сделает инкремент
                }
                // Если это оператор или скобка
                else if (IsOperator(input[i]))
                {
                    if (input[i] == '(')
                    {
                        operStack.Push(input[i]);
                    }
                    else if (input[i] == ')')
                    {
                        // Выталкиваем все из стека до открывающей скобки
                        if (operStack.Count == 0) throw new Exception("Нарушен баланс скобок");
                        char s = operStack.Pop();

                        while (s != '(')
                        {
                            output += s.ToString() + ' ';
                            if (operStack.Count == 0) throw new Exception("Нарушен баланс скобок");
                            s = operStack.Pop();
                        }
                    }
                    else // Обычные операторы (+ - * /)
                    {
                        // Выталкиваем операторы с большим или равным приоритетом
                        while (operStack.Count > 0 && GetPriority(input[i]) <= GetPriority(operStack.Peek()))
                        {
                            output += operStack.Pop().ToString() + " ";
                        }
                        operStack.Push(input[i]);
                    }
                }
            }

            // Выталкиваем оставшиеся операторы из стека
            while (operStack.Count > 0)
            {
                output += operStack.Pop() + " ";
            }

            return output;
        }

        /// <summary>
        /// Вычисляет результат выражения, записанного в формате RPN.
        /// </summary>
        /// <param name="input">Строка в формате Обратной Польской Записи.</param>
        /// <returns>Результат вычисления (double).</returns>
        private double CalculateRPN(string input)
        {
            double result = 0;
            Stack<double> temp = new Stack<double>();

            // Разбиваем строку на элементы по пробелам
            string[] strArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in strArr)
            {
                // Приводим разделитель к точке для корректного парсинга в InvariantCulture
                string normalString = s.Replace(',', '.');

                // Пытаемся распарсить как число
                if (double.TryParse(normalString, NumberStyles.Any, CultureInfo.InvariantCulture, out double num))
                {
                    temp.Push(num);
                }
                else
                {
                    // Если это оператор, берем два последних числа из стека
                    if (temp.Count < 2) throw new Exception("Неверное количество аргументов для операции " + s);

                    double num2 = temp.Pop(); // Второе число (правый операнд)
                    double num1 = temp.Pop(); // Первое число (левый операнд)

                    switch (s)
                    {
                        case "+": result = num1 + num2; break;
                        case "-": result = num1 - num2; break;
                        case "*": result = num1 * num2; break;
                        case "/":
                            if (num2 == 0) throw new DivideByZeroException();
                            result = num1 / num2;
                            break;
                        default:
                            throw new Exception("Неизвестная операция: " + s);
                    }
                    temp.Push(result); // Результат кладем обратно в стек
                }
            }

            if (temp.Count > 0)
                return temp.Peek(); // Возвращаем итоговый результат
            else
                throw new Exception("Пустой стек вычислений (пустое выражение)");
        }

        /// <summary>
        /// Проверяет, является ли символ допустимым математическим оператором или скобкой.
        /// </summary>
        /// <param name="c">Проверяемый символ.</param>
        /// <returns>True, если символ является оператором, иначе False.</returns>
        private bool IsOperator(char c) => "+-/*()".IndexOf(c) != -1;
    }
}