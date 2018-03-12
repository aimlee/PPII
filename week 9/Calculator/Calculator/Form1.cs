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
    public partial class Form1 : Form
    {
        double firstNumber = 0, secondNumber = 0, result = 0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }
       

        public static double factorial(double n)
        {
            
            for (double i = n-1; i >= 1; --i)
            {

                n=n*i;
            }
            return n;
            }

    

        private void button11_Click(object sender, EventArgs e)
        {
            if (display.Text == "")
                display.Text = "0.";
            else
                display.Text = display.Text + ".";
        }

        private void button33_Click(object sender, EventArgs e)
        {
           MC = double.Parse(display.Text) + MC;
        }


        private void backspace_Click(object sender, EventArgs e)
        {
            if (display.Text != "")
            {
                display.Text = display.Text.Remove(display.Text.Length - 1);
            }
        }

       


    
       
        private void button_Click(object sender, EventArgs e)
        {
            
            Button bu = sender as Button;
            display.Text = display.Text + bu.Text;
            
        }
       

        private void operation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            firstNumber = double.Parse(display.Text);
            operation = btn.Text;
            switch (operation)
            {
                case "+":
                    
                    display.Text = "";
                    break;
                case "-":
                    
                    display.Text = "";
                    break;
                case "*":
                    display.Text = "";
                    break;
                case "/":
                    display.Text = "";
                    break;
                case "mod":
                    display.Text = "";
                    break;
                case "+/-":
                    display.Text = (-1*firstNumber).ToString();
                    break;
                case "x^( 1/y)":
                    display.Text = firstNumber.ToString();
                    break;
                case "x^y":
                    display.Text = firstNumber.ToString();
                    break;
                case "√":
                    display.Text = Math.Sqrt(firstNumber).ToString();
                    break;
                case "sin":
                    display.Text = Math.Sin(firstNumber).ToString();
                    break;
                case "cos":
                    display.Text = Math.Cos(firstNumber).ToString();
                    break;
                case "x^2":
                    display.Text = Math.Pow(firstNumber,2).ToString();
                    break;
                case "ln":
                    display.Text = Math.Log(firstNumber, Math.E).ToString();
                    break;
                case "!":
                    display.Text = factorial(firstNumber).ToString();
                    break;
                case "10^x":
                    display.Text = Math.Pow(10,firstNumber).ToString();
                    break;
                case "log":
                    display.Text = Math.Log(firstNumber).ToString();
                    break;
             

            }
            
            

            
        }

        

        private void result_Click(object sender, EventArgs e)
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
               case "mod":
                    result = firstNumber % secondNumber;
                    break;
            }
            display.Text = result.ToString();
        }
        public static double MC;
        private void MS_Click(object sender, EventArgs e)
        {
            
            MC = double.Parse(display.Text);
        }
        private void MC_Click(object sender, EventArgs e)
        {

            MC = 0;
        }

        private void MR_Click(object sender, EventArgs e)
        {
            display.Text = MC.ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            MC = MC - double.Parse(display.Text);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            display.Text = "";
            firstNumber = 0;
            secondNumber = 0;
            result = 0;
            operation = "";
        }
        private void CE_Click(object sender, EventArgs e)
        {
            display.Text = "";
            
            secondNumber = 0;
            result = 0;
            
        }
    }
}
