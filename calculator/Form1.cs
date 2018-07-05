using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calculator.Controller;

namespace calculator
{
    public partial class Form1 : Form
    {
        Numbers number = new Numbers();
        string operation = "";
        public static int FirstNumber;
        int Result;
        public Form1()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, EventArgs e)
        {
             
            Table.Text += number.CallOne();
        }

        private void Second_Click(object sender, EventArgs e)
        {
            Table.Text += number.CallTwo();
        }

        private void Third_Click(object sender, EventArgs e)
        {
            Table.Text += number.CallThree();
        }

        private void Four_Click(object sender, EventArgs e)
        {
            Table.Text += number.CallFour();
        }

        private void Five_Click(object sender, EventArgs e)
        {
            Table.Text += number.CallFive();
        }

        private void Six_Click(object sender, EventArgs e)
        {
            Table.Text += number.CallSix();
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            Table.Text += number.CallSeven();
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            Table.Text += number.CallEight();
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            Table.Text += number.CallNine();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            Table.Text += number.CallZero();
        }
        
        private void Plus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(Table.Text);
           

            Table.Text += "+";
            Table.Text = "";
            operation = "+";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(Table.Text);
            

            Table.Text += "-";
            Table.Text = "";
            operation = "-";

        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(Table.Text);
       

            Table.Text += "*";
            Table.Text = "";

            operation = "*";

        }

        private void Devide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(Table.Text);
          

            Table.Text += "/";
            Table.Text = "";
            operation = "/";

        }

        private void Equal_Click(object sender, EventArgs e)
        {
                    int SecondNumber;
            
            SecondNumber = Convert.ToInt32(Table.Text);
            //MessageBox.Show(SecondNumber.ToString());
            switch (operation)
            {
                case "+":
                    Result=(FirstNumber + SecondNumber);
                    FirstNumber = Result;
                    break;
                case "-":
                    Result=FirstNumber - SecondNumber;
                    break;
                case "*":
                    Result=FirstNumber* SecondNumber;
                    break;
                case "/":
                    Result = FirstNumber / SecondNumber;
                    break;
            }
            Table.Text = Result.ToString();

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Table.Text = " ";
        }

    }
}
