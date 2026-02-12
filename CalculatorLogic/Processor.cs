using System;
using System.Collections.Generic;
using System.Globalization;

namespace CalculatorLogic
{
    /// <summary>
    /// Основной класс логики калькулятора.
    /// Реализует вычисления через Обратную Польскую Запись (RPN).
    /// </summary>
    public class Processor
    {
        /// <summary>
        /// Метод для вычисления математического выражения, записанного в виде строки.
        /// </summary>
        /// <param name="expression">Строка с выражением (например, "10 + 2 * (3 - 1)")</param>
        /// <returns>Результат вычисления типа double</returns>
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
                // Пробрасываем ошибку выше, чтобы её поймать в Form1
                throw new DivideByZeroException("Деление на ноль невозможно!");
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка в выражении: " + ex.Message);
            }
        }

        /// <summary>
        /// Приватный метод: определяет приоритет операций.
        /// </summary>
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
        /// Алгоритм "Сортировочная станция"
        /// Преобразует инфиксную запись (2 + 2) в постфиксную (2 2 +).
        /// </summary>
        private string GetReversePolishNotation(string input)
        {
            string output = string.Empty;
            Stack<char> operStack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                // Пропускаем пробелы
                if (IsSpace(input[i])) continue;

                // Если цифра или точка - читаем число целиком
                if (Char.IsDigit(input[i]) || input[i] == ',' || input[i] == '.')
                {
                    while (!IsSpace(input[i]) && !IsOperator(input[i]))
                    {
                        output += input[i];
                        i++;
                        if (i == input.Length) break;
                    }
                    output += " ";
                    i--;
                }
                // Если оператор или скобка
                else if (IsOperator(input[i]))
                {
                    if (input[i] == '(')
                    {
                        operStack.Push(input[i]);
                    }
                    else if (input[i] == ')')
                    {
                        char s = operStack.Pop();
                        while (s != '(')
                        {
                            output += s.ToString() + ' ';
                            s = operStack.Pop();
                        }
                    }
                    else // Обычные операторы
                    {
                        if (operStack.Count > 0)
                        {
                            if (GetPriority(input[i]) <= GetPriority(operStack.Peek()))
                            {
                                output += operStack.Pop().ToString() + " ";
                            }
                        }
                        operStack.Push(char.Parse(input[i].ToString()));
                    }
                }
            }

            // Выталкиваем оставшиеся операторы
            while (operStack.Count > 0)
            {
                output += operStack.Pop() + " ";
            }

            return output;
        }

        /// <summary>
        /// Вычисление результата на основе RPN строки.
        /// </summary>
        private double CalculateRPN(string input) 
        {
            double result = 0;
            Stack<double> temp = new Stack<double>();

            // Заменяем точки на запятые (или наоборот, зависит от настроек системы), 
            // чтобы double.Parse не упал
            input = input.Replace('.', ',');

            string[] strArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in strArr)
            {
                if (double.TryParse(s, out double num))
                {
                    temp.Push(num);
                }
                else
                {
                    // Если стек пуст, значит операторов больше чем чисел
                    if (temp.Count < 2) throw new Exception("Неверное количество аргументов");

                    double num2 = temp.Pop();
                    double num1 = temp.Pop();

                    switch (s)
                    {
                        case "+": result = num1 + num2; break;
                        case "-": result = num1 - num2; break;
                        case "*": result = num1 * num2; break;
                        case "/":
                            if (num2 == 0) throw new DivideByZeroException();
                            result = num1 / num2;
                            break;
                    }
                    temp.Push(result);
                }
            }

            if (temp.Count > 0)
                return temp.Peek();
            else
                throw new Exception("Пустой стек вычислений");
        }

        // Вспомогательные методы
        private bool IsSpace(char c) => c == ' ';
        private bool IsOperator(char c) => "+-/*()".IndexOf(c) != -1;
    }
}