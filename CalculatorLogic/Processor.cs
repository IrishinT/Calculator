using System;
using System.Collections.Generic;
using System.Globalization;

namespace CalculatorLogic
{
    public class Processor
    {
        public double Calculate(string expression)
        {
            try
            {
                // 1. Преобразуем в RPN
                string rpnExpression = GetReversePolishNotation(expression);
                // 2. Считаем результат
                return CalculateRPN(rpnExpression);
            }
            catch (DivideByZeroException)
            {
                throw new DivideByZeroException("Деление на ноль невозможно!");
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка: " + ex.Message);
            }
        }

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

        private string GetReversePolishNotation(string input)
        {
            string output = string.Empty;
            Stack<char> operStack = new Stack<char>();

            // Удаляем все пробелы, чтобы упростить разбор унарного минуса
            input = input.Replace(" ", "");

            for (int i = 0; i < input.Length; i++)
            {
                // Проверяем, является ли текущий символ минусом, который обозначает отрицательное число (унарный минус)
                // Это так, если:
                // 1. Минус стоит в самом начале строки (i == 0)
                // 2. Или перед минусом стоит открывающая скобка '('
                // 3. Или перед минусом стоит любой другой оператор (кроме закрывающей скобки)
                bool isUnaryMinus = false;
                if (input[i] == '-')
                {
                    if (i == 0) isUnaryMinus = true;
                    else if (input[i - 1] == '(') isUnaryMinus = true;
                    else if (IsOperator(input[i - 1]) && input[i - 1] != ')') isUnaryMinus = true;
                }

                // Если это цифра, или разделитель, или мы определили, что это унарный минус -> читаем как число
                if (Char.IsDigit(input[i]) || input[i] == ',' || input[i] == '.' || isUnaryMinus)
                {
                    // Читаем число целиком
                    // Если это унарный минус, добавляем его и идем к следующему символу (цифре)
                    if (isUnaryMinus)
                    {
                        output += input[i];
                        i++;
                    }

                    // Читаем оставшиеся цифры числа
                    while (i < input.Length && (Char.IsDigit(input[i]) || input[i] == ',' || input[i] == '.'))
                    {
                        output += input[i];
                        i++;
                    }

                    output += " ";
                    i--; // Возвращаемся на шаг назад, так как цикл for сам сделает i++
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
                        while (operStack.Count > 0 && GetPriority(input[i]) <= GetPriority(operStack.Peek()))
                        {
                            output += operStack.Pop().ToString() + " ";
                        }
                        operStack.Push(input[i]);
                    }
                }
            }

            while (operStack.Count > 0)
            {
                output += operStack.Pop() + " ";
            }

            return output;
        }

        private double CalculateRPN(string input)
        {
            double result = 0;
            Stack<double> temp = new Stack<double>();

            // Разбиваем строку по пробелам
            string[] strArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in strArr)
            {
                // Пробуем распарсить число. 
                // Используем InvariantCulture, чтобы '5.5' читалось корректно вне зависимости от настроек ПК.
                // Replace(',', '.') нужен на случай, если пользователь ввел запятую.
                string normalString = s.Replace(',', '.');

                if (double.TryParse(normalString, NumberStyles.Any, CultureInfo.InvariantCulture, out double num))
                {
                    temp.Push(num);
                }
                else
                {
                    // Если это не число, значит оператор. Для бинарного оператора нужно 2 числа в стеке.
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
                        default:
                            throw new Exception("Неизвестная операция: " + s);
                    }
                    temp.Push(result);
                }
            }

            if (temp.Count > 0)
                return temp.Peek();
            else
                throw new Exception("Пустой стек вычислений");
        }

        private bool IsOperator(char c) => "+-/*()".IndexOf(c) != -1;
    }
}