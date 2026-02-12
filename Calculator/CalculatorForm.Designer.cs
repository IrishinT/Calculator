
namespace Calculator
{
    partial class CalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            calculatorTab = new TabPage();
            generalSplitContainer = new SplitContainer();
            txtDisplay = new TextBox();
            promptText = new Label();
            buttonClear = new Button();
            buttonEval = new Button();
            buttonDiv = new Button();
            buttonMul = new Button();
            buttonMinus = new Button();
            buttonPlus = new Button();
            buttonClBracket = new Button();
            buttonOpBracket = new Button();
            button0 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button7 = new Button();
            button9 = new Button();
            button8 = new Button();
            historyTab = new TabPage();
            panel1 = new Panel();
            lstHistory = new ListBox();
            tabControl.SuspendLayout();
            calculatorTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)generalSplitContainer).BeginInit();
            generalSplitContainer.Panel1.SuspendLayout();
            generalSplitContainer.Panel2.SuspendLayout();
            generalSplitContainer.SuspendLayout();
            historyTab.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(calculatorTab);
            tabControl.Controls.Add(historyTab);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(559, 600);
            tabControl.TabIndex = 0;
            // 
            // calculatorTab
            // 
            calculatorTab.Controls.Add(generalSplitContainer);
            calculatorTab.Location = new Point(4, 29);
            calculatorTab.Margin = new Padding(3, 4, 3, 4);
            calculatorTab.Name = "calculatorTab";
            calculatorTab.Padding = new Padding(3, 4, 3, 4);
            calculatorTab.Size = new Size(551, 567);
            calculatorTab.TabIndex = 0;
            calculatorTab.Text = "Калькулятор";
            calculatorTab.UseVisualStyleBackColor = true;
            // 
            // generalSplitContainer
            // 
            generalSplitContainer.Dock = DockStyle.Fill;
            generalSplitContainer.FixedPanel = FixedPanel.Panel2;
            generalSplitContainer.IsSplitterFixed = true;
            generalSplitContainer.Location = new Point(3, 4);
            generalSplitContainer.Margin = new Padding(3, 4, 3, 4);
            generalSplitContainer.Name = "generalSplitContainer";
            generalSplitContainer.Orientation = Orientation.Horizontal;
            // 
            // generalSplitContainer.Panel1
            // 
            generalSplitContainer.Panel1.BackColor = Color.WhiteSmoke;
            generalSplitContainer.Panel1.Controls.Add(txtDisplay);
            generalSplitContainer.Panel1.Controls.Add(promptText);
            generalSplitContainer.Panel1.Padding = new Padding(11, 20, 10, 10);
            generalSplitContainer.Panel1.Paint += generalSplitContainer_Panel1_Paint;
            // 
            // generalSplitContainer.Panel2
            // 
            generalSplitContainer.Panel2.Controls.Add(buttonClear);
            generalSplitContainer.Panel2.Controls.Add(buttonEval);
            generalSplitContainer.Panel2.Controls.Add(buttonDiv);
            generalSplitContainer.Panel2.Controls.Add(buttonMul);
            generalSplitContainer.Panel2.Controls.Add(buttonMinus);
            generalSplitContainer.Panel2.Controls.Add(buttonPlus);
            generalSplitContainer.Panel2.Controls.Add(buttonClBracket);
            generalSplitContainer.Panel2.Controls.Add(buttonOpBracket);
            generalSplitContainer.Panel2.Controls.Add(button0);
            generalSplitContainer.Panel2.Controls.Add(button3);
            generalSplitContainer.Panel2.Controls.Add(button2);
            generalSplitContainer.Panel2.Controls.Add(button1);
            generalSplitContainer.Panel2.Controls.Add(button6);
            generalSplitContainer.Panel2.Controls.Add(button5);
            generalSplitContainer.Panel2.Controls.Add(button4);
            generalSplitContainer.Panel2.Controls.Add(button7);
            generalSplitContainer.Panel2.Controls.Add(button9);
            generalSplitContainer.Panel2.Controls.Add(button8);
            generalSplitContainer.Panel2.Padding = new Padding(11, 13, 11, 13);
            generalSplitContainer.Size = new Size(545, 559);
            generalSplitContainer.SplitterDistance = 164;
            generalSplitContainer.SplitterWidth = 1;
            generalSplitContainer.TabIndex = 0;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.WhiteSmoke;
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Dock = DockStyle.Bottom;
            txtDisplay.Font = new Font("Segoe UI", 30F);
            txtDisplay.ForeColor = Color.Black;
            txtDisplay.Location = new Point(11, 87);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(524, 67);
            txtDisplay.TabIndex = 1;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // promptText
            // 
            promptText.AutoSize = true;
            promptText.Dock = DockStyle.Fill;
            promptText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            promptText.Location = new Point(11, 20);
            promptText.Name = "promptText";
            promptText.Size = new Size(0, 28);
            promptText.TabIndex = 0;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonClear.Location = new Point(327, 292);
            buttonClear.Margin = new Padding(3, 4, 3, 4);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(86, 79);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonEval
            // 
            buttonEval.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEval.Location = new Point(419, 292);
            buttonEval.Margin = new Padding(3, 4, 3, 4);
            buttonEval.Name = "buttonEval";
            buttonEval.Size = new Size(86, 79);
            buttonEval.TabIndex = 16;
            buttonEval.Text = "=";
            buttonEval.UseVisualStyleBackColor = true;
            // 
            // buttonDiv
            // 
            buttonDiv.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDiv.Location = new Point(419, 119);
            buttonDiv.Margin = new Padding(3, 4, 3, 4);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(86, 79);
            buttonDiv.TabIndex = 15;
            buttonDiv.Text = "÷";
            buttonDiv.UseVisualStyleBackColor = true;
            // 
            // buttonMul
            // 
            buttonMul.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonMul.Location = new Point(327, 119);
            buttonMul.Margin = new Padding(3, 4, 3, 4);
            buttonMul.Name = "buttonMul";
            buttonMul.Size = new Size(86, 79);
            buttonMul.TabIndex = 14;
            buttonMul.Text = "×";
            buttonMul.UseVisualStyleBackColor = true;
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonMinus.Location = new Point(419, 32);
            buttonMinus.Margin = new Padding(3, 4, 3, 4);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(86, 79);
            buttonMinus.TabIndex = 13;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPlus.Location = new Point(327, 32);
            buttonPlus.Margin = new Padding(3, 4, 3, 4);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(86, 79);
            buttonPlus.TabIndex = 12;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            // 
            // buttonClBracket
            // 
            buttonClBracket.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonClBracket.Location = new Point(419, 205);
            buttonClBracket.Margin = new Padding(3, 4, 3, 4);
            buttonClBracket.Name = "buttonClBracket";
            buttonClBracket.Size = new Size(86, 79);
            buttonClBracket.TabIndex = 11;
            buttonClBracket.Text = ")";
            buttonClBracket.UseVisualStyleBackColor = true;
            // 
            // buttonOpBracket
            // 
            buttonOpBracket.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOpBracket.Location = new Point(327, 205);
            buttonOpBracket.Margin = new Padding(3, 4, 3, 4);
            buttonOpBracket.Name = "buttonOpBracket";
            buttonOpBracket.Size = new Size(86, 79);
            buttonOpBracket.TabIndex = 10;
            buttonOpBracket.Text = "(";
            buttonOpBracket.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button0.Location = new Point(121, 292);
            button0.Margin = new Padding(3, 4, 3, 4);
            button0.Name = "button0";
            button0.Size = new Size(86, 79);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(214, 205);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 79);
            button3.TabIndex = 8;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(121, 205);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 79);
            button2.TabIndex = 7;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(29, 205);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 79);
            button1.TabIndex = 6;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button6.Location = new Point(214, 119);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 79);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button5.Location = new Point(121, 119);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 79);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.Location = new Point(29, 119);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 79);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button7.Location = new Point(29, 32);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(86, 79);
            button7.TabIndex = 0;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button9.Location = new Point(214, 32);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(86, 79);
            button9.TabIndex = 2;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button8.Location = new Point(121, 32);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(86, 79);
            button8.TabIndex = 1;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // historyTab
            // 
            historyTab.Controls.Add(panel1);
            historyTab.Location = new Point(4, 29);
            historyTab.Margin = new Padding(3, 4, 3, 4);
            historyTab.Name = "historyTab";
            historyTab.Padding = new Padding(3, 4, 3, 4);
            historyTab.Size = new Size(551, 567);
            historyTab.TabIndex = 1;
            historyTab.Text = "История";
            historyTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(lstHistory);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(545, 559);
            panel1.TabIndex = 0;
            // 
            // lstHistory
            // 
            lstHistory.Dock = DockStyle.Fill;
            lstHistory.FormattingEnabled = true;
            lstHistory.Location = new Point(0, 0);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(545, 559);
            lstHistory.TabIndex = 0;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 600);
            Controls.Add(tabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CalculatorForm";
            Text = "Калькулятор";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            calculatorTab.ResumeLayout(false);
            generalSplitContainer.Panel1.ResumeLayout(false);
            generalSplitContainer.Panel1.PerformLayout();
            generalSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)generalSplitContainer).EndInit();
            generalSplitContainer.ResumeLayout(false);
            historyTab.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private TabControl tabControl;
        private TabPage historyTab;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private TabPage calculatorTab;
        private SplitContainer generalSplitContainer;
        private Label promptText;
        private Button button2;
        private Button button1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button7;
        private Button button9;
        private Button button8;
        private Button buttonPlus;
        private Button buttonClBracket;
        private Button buttonOpBracket;
        private Button button0;
        private Button button3;
        private Button buttonClear;
        private Button buttonEval;
        private Button buttonDiv;
        private Button buttonMul;
        private Button buttonMinus;
        private TextBox txtDisplay;
        private ListBox lstHistory;
    }
}
