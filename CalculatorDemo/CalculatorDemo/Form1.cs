using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorDemo
{
    public partial class Form1 : Form
    {
        public string num1 = "";
        public string num2 = "";
        public string operate = "";
        public double result = 0.0;
        public bool isInputDone = false;
        public bool isOperationSelected = false;
        public string temp = "";
        public int count = 0;
        public string operant = "";

        public Form1()
        {
            InitializeComponent();
            button_add.Click += Button_add_Click;
            button_minus.Click += Button_minus_Click;
            button_multiply.Click += Button_multiply_Click;
            button_divide.Click += Button_divide_Click;
            button_equal.Click += Button_equal_Click;
            button_square.Click += Button_square_Click;
        }

        private void Button_square_Click(object sender, EventArgs e)
        {
            // do not have enough time to do this
        }

        private void Button_equal_Click(object sender, EventArgs e)
        {
            if(operant == "add")
            {
                result = Calculator.Add(Convert.ToDouble(num1),Convert.ToDouble(num2));
            }

            else if (operant == "minus")
            {
                result = Calculator.Subtract(Convert.ToDouble(num1), Convert.ToDouble(num2));
            }

            else if (operant == "multiply")
            {
                result = Calculator.Multiply(Convert.ToDouble(num1), Convert.ToDouble(num2));
            }

            else if (operant == "divide")
            {
                result = Calculator.Divide(Convert.ToDouble(num1), Convert.ToDouble(num2));
            }

            textBox1.Text = result.ToString();
            num1 = result.ToString();
            num2 = "";
            isOperationSelected = false;
            isInputDone = false;
            

        }

        private void Button_divide_Click(object sender, EventArgs e)
        {
            operant = "divide";
            if (isInputDone == true)
            {
                result = Calculator.Divide(Convert.ToDouble(num1), Convert.ToDouble(num2));
                textBox1.Text = result.ToString();
                num1 = result.ToString();
                num2 = "";
                isOperationSelected = false;
                count = 1;
            }
        }

        private void Button_multiply_Click(object sender, EventArgs e)
        {
            operant = "multiply";
            if (isInputDone == true)
            {
                result = Calculator.Multiply(Convert.ToDouble(num1), Convert.ToDouble(num2));
                textBox1.Text = result.ToString();
                num1 = result.ToString();
                num2 = "";
                isOperationSelected = false;
                count = 1;
            }
        }

        private void Button_minus_Click(object sender, EventArgs e)
        {
            operant = "minus";
            if (isInputDone == true)
            {
                result = Calculator.Subtract(Convert.ToDouble(num1), Convert.ToDouble(num2));
                textBox1.Text = result.ToString();
                num1 = result.ToString();
                num2 = "";
                isOperationSelected = false;
                count = 1;
            }
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            operant = "add";
            // should be put in specific button
            if (isInputDone == true)
            {
                result = Calculator.Add(Convert.ToDouble(num1), Convert.ToDouble(num2));
                textBox1.Text = result.ToString();
                num1 = result.ToString();
                num2 = "";
                isOperationSelected = false;
                count = 1;
            }
        }

        private void button_zero_Click(object sender, EventArgs e)
        {
            
            Button tempBtn = (Button)sender;
            // 1. start to input a value
            if (isOperationSelected == false && num2 == "" && count == 0)
            {
                textBox1.Text += tempBtn.Text;
                isInputDone = false;
                num1 = textBox1.Text;
            }
       
            // 2. operator selected, ready to intake another number
            else if (isOperationSelected == true && num2 == "")
            {
                textBox1.Text += tempBtn.Text;
                num2 = textBox1.Text;
                isInputDone = true;
                count = 1;
            }

            // 2. When the selection is not done and still need input
            else if (isOperationSelected == true && num2 != "")
            {
                textBox1.Text += tempBtn.Text;
                isInputDone = true;
                num2 = textBox1.Text;
                count = 1;
            }

            // 3. When you get a result and need to input another number
            else if (isOperationSelected == false && num1 != "" && num2 == "")
            {
                textBox1.Clear();
                textBox1.Text += tempBtn.Text;
                num2 = textBox1.Text;
                isInputDone = true;
                count = 2;
            }
            else if (isOperationSelected == false && num1 != "" && num2 != "")
            {
                textBox1.Text += tempBtn.Text;
                num2 = textBox1.Text;
                isInputDone = true;
                count = 2;
            }

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            num1 = "";
            num2 = "";
            count = 0;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            isOperationSelected = true;
            textBox1.Clear();
            textBox1.Text = null;
            count = 1;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
