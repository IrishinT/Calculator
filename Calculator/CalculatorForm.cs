using System;
using System.Windows.Forms;
using CalculatorLogic;
namespace Calculator
{
    /// <summary>
    /// Главная форма приложения "Калькулятор".
    /// Реализует взаимодействие с пользователем и вызов бизнес-логики.
    /// </summary>
    public partial class CalculatorForm : Form
    {
        /// <summary>
        /// Экземпляр класса процессора для выполнения вычислений.
        /// </summary>
        private readonly Processor _processor;

        /// <summary>
        /// Конструктор формы. Инициализирует компоненты и привязывает события.
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();

            // Инициализация логики
            _processor = new Processor();

            // Настройка заголовка
            this.Text = "Калькулятор";

            // Автоматическая привязка событий ко всем кнопкам на форме
            AttachButtonEvents();

            this.ActiveControl = txtDisplay;
            txtDisplay.KeyDown += TxtDisplay_KeyDown;
        }

        /// <summary>
        /// Обрабатывает нажатие клавиш в поле ввода.
        /// При нажатии Enter выполняет вычисление выражения.
        /// </summary>
        /// <param name="sender">Источник события (txtDisplay).</param>
        /// <param name="e">Аргументы события клавиатуры.</param>
        private void TxtDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // чтобы не было звука "бип"
                CalculateResult();
            }
        }

        /// <summary>
        /// Метод загрузки формы. 
        /// </summary>
        /// <param name="sender"> Источник события. </param>
        /// <param name="e"> Аргументы события. </param>

        private void AttachButtonEvents()
        {
            // Рекурсивный поиск кнопок внутри всех контейнеров
            foreach (Control c in this.Controls)
            {
                ProcessControl(c);
            }
        }

        /// <summary>
        /// Вспомогательный метод для рекурсивного обхода контейнеров.
        /// </summary>
        /// <param name="c"> Элемент управления для проверки. </param>
        private void ProcessControl(Control c)
        {
            if (c.HasChildren)
            {
                foreach (Control child in c.Controls)
                {
                    ProcessControl(child);
                }
            }

            if (c is Button btn)
            {
                btn.Click -= Button_Click_Universal;
                btn.Click += Button_Click_Universal;
            }
        }

        /// <summary>
        /// Единый обработчик для всех кнопок.
        /// </summary>
        private void Button_Click_Universal(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            string text = btn.Text;

            if (text == "×") text = "*";
            if (text == "÷") text = "/";

            switch (text)
            {
                case "=":
                    CalculateResult();
                    break;

                case "C":
                    txtDisplay.Clear();
                    break;

                case "<-":
                case "Back":
                case "Del": 
                    RemoveLastChar();
                    break;

                default:
                    InsertText(text);
                    break;
            }

            // Возвращаем фокус в поле, чтобы можно было продолжить печатать с клавиатуры
            txtDisplay.Focus();
            // Ставим курсор в конец строки
            txtDisplay.SelectionStart = txtDisplay.Text.Length;
        }

        private void InsertText(string text)
        {
            // Вставка текста там, где стоит курсор
            int selectionIndex = txtDisplay.SelectionStart;
            txtDisplay.Text = txtDisplay.Text.Insert(selectionIndex, text);
            txtDisplay.SelectionStart = selectionIndex + text.Length;
        }

        private void RemoveLastChar()
        {
            if (txtDisplay.Text.Length > 0)
            {
                int cursorPosition = txtDisplay.SelectionStart;

                // Если курсор стоит не в начале
                if (cursorPosition > 0)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(cursorPosition - 1, 1);
                    txtDisplay.SelectionStart = cursorPosition - 1;
                }
                // Если курсор почему-то в конце или начале 
                else
                {
                    txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                    txtDisplay.SelectionStart = txtDisplay.Text.Length;
                }
            }
        }

        /// <summary>
        /// Вызов логики и сохранение в историю.
        /// </summary>
        private void CalculateResult()
        {
            string expression = txtDisplay.Text;
            if (string.IsNullOrWhiteSpace(expression)) return;

            try
            {
                // Вызываем метод из Processor.cs
                double result = _processor.Calculate(expression);

                // Показываем результат
                txtDisplay.Text = result.ToString();
                txtDisplay.SelectionStart = txtDisplay.Text.Length;

                string historyLine = $"{expression} = {result}";
                if (lstHistory != null)
                {
                    lstHistory.Items.Add(historyLine);
                    lstHistory.TopIndex = lstHistory.Items.Count - 1; // Прокрутка вниз
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("На ноль делить нельзя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDisplay.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDisplay.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void generalSplitContainer_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
