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
            historyTextBox = new TextBox();
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
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(489, 450);
            tabControl.TabIndex = 0;
            // 
            // calculatorTab
            // 
            calculatorTab.Controls.Add(generalSplitContainer);
            calculatorTab.Location = new Point(4, 24);
            calculatorTab.Name = "calculatorTab";
            calculatorTab.Padding = new Padding(3);
            calculatorTab.Size = new Size(481, 422);
            calculatorTab.TabIndex = 0;
            calculatorTab.Text = "Калькулятор";
            calculatorTab.UseVisualStyleBackColor = true;
            // 
            // generalSplitContainer
            // 
            generalSplitContainer.Dock = DockStyle.Fill;
            generalSplitContainer.FixedPanel = FixedPanel.Panel2;
            generalSplitContainer.Location = new Point(3, 3);
            generalSplitContainer.Name = "generalSplitContainer";
            generalSplitContainer.Orientation = Orientation.Horizontal;
            // 
            // generalSplitContainer.Panel1
            // 
            generalSplitContainer.Panel1.Controls.Add(promptText);
            generalSplitContainer.Panel1.Padding = new Padding(10, 15, 10, 10);
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
            generalSplitContainer.Panel2.Padding = new Padding(10);
            generalSplitContainer.Size = new Size(475, 416);
            generalSplitContainer.SplitterDistance = 100;
            generalSplitContainer.TabIndex = 0;
            // 
            // promptText
            // 
            promptText.AutoSize = true;
            promptText.Dock = DockStyle.Fill;
            promptText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            promptText.Location = new Point(10, 15);
            promptText.Name = "promptText";
            promptText.Size = new Size(0, 21);
            promptText.TabIndex = 0;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonClear.Location = new Point(286, 219);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 59);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonEval
            // 
            buttonEval.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEval.Location = new Point(367, 219);
            buttonEval.Name = "buttonEval";
            buttonEval.Size = new Size(75, 59);
            buttonEval.TabIndex = 16;
            buttonEval.Text = "=";
            buttonEval.UseVisualStyleBackColor = true;
            // 
            // buttonDiv
            // 
            buttonDiv.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDiv.Location = new Point(367, 89);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(75, 59);
            buttonDiv.TabIndex = 15;
            buttonDiv.Text = "÷";
            buttonDiv.UseVisualStyleBackColor = true;
            // 
            // buttonMul
            // 
            buttonMul.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonMul.Location = new Point(286, 89);
            buttonMul.Name = "buttonMul";
            buttonMul.Size = new Size(75, 59);
            buttonMul.TabIndex = 14;
            buttonMul.Text = "×";
            buttonMul.UseVisualStyleBackColor = true;
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonMinus.Location = new Point(367, 24);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(75, 59);
            buttonMinus.TabIndex = 13;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPlus.Location = new Point(286, 24);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(75, 59);
            buttonPlus.TabIndex = 12;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            // 
            // buttonClBracket
            // 
            buttonClBracket.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonClBracket.Location = new Point(367, 154);
            buttonClBracket.Name = "buttonClBracket";
            buttonClBracket.Size = new Size(75, 59);
            buttonClBracket.TabIndex = 11;
            buttonClBracket.Text = ")";
            buttonClBracket.UseVisualStyleBackColor = true;
            // 
            // buttonOpBracket
            // 
            buttonOpBracket.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOpBracket.Location = new Point(286, 154);
            buttonOpBracket.Name = "buttonOpBracket";
            buttonOpBracket.Size = new Size(75, 59);
            buttonOpBracket.TabIndex = 10;
            buttonOpBracket.Text = "(";
            buttonOpBracket.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button0.Location = new Point(106, 219);
            button0.Name = "button0";
            button0.Size = new Size(75, 59);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(187, 154);
            button3.Name = "button3";
            button3.Size = new Size(75, 59);
            button3.TabIndex = 8;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(106, 154);
            button2.Name = "button2";
            button2.Size = new Size(75, 59);
            button2.TabIndex = 7;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(25, 154);
            button1.Name = "button1";
            button1.Size = new Size(75, 59);
            button1.TabIndex = 6;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button6.Location = new Point(187, 89);
            button6.Name = "button6";
            button6.Size = new Size(75, 59);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button5.Location = new Point(106, 89);
            button5.Name = "button5";
            button5.Size = new Size(75, 59);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.Location = new Point(25, 89);
            button4.Name = "button4";
            button4.Size = new Size(75, 59);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button7.Location = new Point(25, 24);
            button7.Name = "button7";
            button7.Size = new Size(75, 59);
            button7.TabIndex = 0;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button9.Location = new Point(187, 24);
            button9.Name = "button9";
            button9.Size = new Size(75, 59);
            button9.TabIndex = 2;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button8.Location = new Point(106, 24);
            button8.Name = "button8";
            button8.Size = new Size(75, 59);
            button8.TabIndex = 1;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // historyTab
            // 
            historyTab.Controls.Add(panel1);
            historyTab.Location = new Point(4, 24);
            historyTab.Name = "historyTab";
            historyTab.Padding = new Padding(3);
            historyTab.Size = new Size(481, 422);
            historyTab.TabIndex = 1;
            historyTab.Text = "История";
            historyTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(historyTextBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 416);
            panel1.TabIndex = 0;
            // 
            // historyTextBox
            // 
            historyTextBox.AcceptsReturn = true;
            historyTextBox.BackColor = Color.White;
            historyTextBox.Dock = DockStyle.Fill;
            historyTextBox.ForeColor = Color.Black;
            historyTextBox.HideSelection = false;
            historyTextBox.ImeMode = ImeMode.Disable;
            historyTextBox.Location = new Point(0, 0);
            historyTextBox.Multiline = true;
            historyTextBox.Name = "historyTextBox";
            historyTextBox.ReadOnly = true;
            historyTextBox.ScrollBars = ScrollBars.Vertical;
            historyTextBox.Size = new Size(475, 416);
            historyTextBox.TabIndex = 0;
            historyTextBox.TabStop = false;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 450);
            Controls.Add(tabControl);
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
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage historyTab;
        private Panel panel1;
        private TextBox historyTextBox;
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
    }
}
