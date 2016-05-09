using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public enum State
    {
        WaitingForFirstNumber,
        WaitingForSecondNumber,
        WaitingForResult,
        WaitingForOperation
    }

    public partial class Form1 : Form
    {
        double firstNumber = 0;
        double secondNumber = 0;
        double result = 0;
        double sign;
        // string state = "init";
        string operation = "";
        double memoryNumber = 0;
        State state;


        public decimal MemoryStore { get; private set; }

        public Form1()
        {
            InitializeComponent();
            state = State.WaitingForFirstNumber;
        }

        private void pad_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (state)
            {
                case State.WaitingForFirstNumber:
                    state = State.WaitingForOperation;
                    break;
                case State.WaitingForSecondNumber:
                    state = State.WaitingForResult;
                    display.Text = "";
                    break;
            }
            if (btn.Text == ".")
            {
                if (!display.Text.Contains("."))
                    display.Text += btn.Text;
            }
            else
                display.Text += btn.Text;
        }

    private void operation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            firstNumber = double.Parse(display.Text);
            state = State.WaitingForSecondNumber;
            operation = btn.Text;

        }

        private void operationResult_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(display.Text);

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;

                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "sqrt":
                    result = Math.Sqrt(firstNumber);
                    break;
                case "%":
                    result = (secondNumber * firstNumber) / 100;
                    break;
                case "1/x":
                    result = (1 / firstNumber);
                    break;
               

            }


            display.Text = result.ToString();
        }

        private void operationClear_Click(object sender, EventArgs e)
        {
            Button operationClearButton = sender as Button;
            string operationClear = operationClearButton.Text;

            switch (operationClear)
            {
                case "C":
                    display.Text = "";
                    result = 0;
                    secondNumber = 0;
                    firstNumber = 0;
                    break;
                case "CE":
                    display.Text = "";
                    break;
            }
        }

        private void operationMemory_Click(object sender, EventArgs e)
        {
            Button operationMemoryButton = sender as Button;
            string operationMemory = operationMemoryButton.Text;

            switch (operationMemory)
            {
                case "MC":
                    memoryNumber = 0;
                    break;
                case "MR":
                    display.Text = memoryNumber.ToString();
                    break;
                case "MS":

                    memoryNumber = double.Parse(display.Text);
                    display.Text = "";
                    break;
                case "M+":
                    memoryNumber = memoryNumber + double.Parse(display.Text);
                    break;
            }
            display.Text = memoryNumber.ToString();
        }

       
        private void display_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                char ch = e.KeyChar;
                if (!char.IsDigit(ch) && ch != 8)
                {
                    e.Handled = true;
                }

            }
        }

        private void display_KeyPress(object sender, EventArgs e)
        {

        }

        private void operationBack_Click(object sender, EventArgs e)
        { 
            int lenght = display.TextLength - 1;
            string text = display.Text;
            display.Clear();
            for (int i = 0; i < lenght; i++)
                display.Text = display.Text + text[i];

        }

        private void operationDot_Click(object sender, EventArgs e)
       
        {
            Button btn = sender as Button;
            if (!display.Text.Contains(","))
            {
                display.Text += btn.Text;
            }





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Click(object sender, EventArgs e)
        {
            double sign = double.Parse(this.display.Text);
            sign *= -1;
            this.display.Text=sign.ToString();
        }
    }
    }
    
    







