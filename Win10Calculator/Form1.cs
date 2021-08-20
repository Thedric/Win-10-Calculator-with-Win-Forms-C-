using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private char operation='\0';
        private double result = 0.0D;
        bool enterValue = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RESULTbutton.PerformClick();

            }else if(e.KeyCode == Keys.Escape)
            {
                CEbutton.PerformClick();
            }
        }

        private void RESULTbutton_Click(object sender, EventArgs e)
        {
            if (this.UserInput.Text == string.Empty)
            {
                this.UserInput.Text = this.result.ToString();
            }
            switch (operation)
            {
                case '+':
                    this.result += Double.Parse(this.UserInput.Text);
                    this.Label1.Text += " " + this.UserInput.Text + " ";
                    this.UserInput.Text = result.ToString();
                    this.operation = '!';
                    break;
                case '*':
                    this.result *= Double.Parse(this.UserInput.Text);
                    this.Label1.Text += " " + this.UserInput.Text + " ";
                    this.UserInput.Text = result.ToString();
                    enterValue = false;
                    this.operation = '!';
                    break;
                case '/':
                    this.result /= Double.Parse(this.UserInput.Text);
                    this.Label1.Text += " " + this.UserInput.Text + " ";
                    this.UserInput.Text = result.ToString();
                    enterValue = false;
                    this.operation = '!';
                    break;
                case '-':
                    this.result -= Double.Parse(this.UserInput.Text);
                    this.Label1.Text += " " + this.UserInput.Text + " ";
                    this.UserInput.Text = result.ToString();

                    this.UserInput.Text = result.ToString();
                    this.operation = '!';
                    break;
                default:
                    break;

            }

        }


        private void CEbutton_Click(object sender, EventArgs e)
        {
            this.UserInput.Text = "0";
            this.Label1.Text = string.Empty;
            result = 0.0d;
            this.enterValue = false;
        }



        private void DELbutton_Click(object sender, EventArgs e)
        {
            if (this.UserInput.Text == string.Empty)
            {
                return;
            }

            if (this.UserInput.Text.Length == 1)
            {
                this.UserInput.Text = string.Empty;
            }
            else
            {
                this.UserInput.Text = this.UserInput.Text.Substring(0, this.UserInput.Text.Length-1);
            }
        }

        private void DIVIDEbutton_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                return;
            }
            if (this.result != 0)
            {

                RESULTbutton.PerformClick();
                enterValue = true;
                this.operation = '/';
                this.Label1.Text = this.result + " " + this.operation + " ";


            }
            else
            {
                this.operation = '/';
                this.result = Double.Parse(this.UserInput.Text);
                this.Label1.Text = this.result + " " + this.operation;
                enterValue = true;

            }
        }

        private void SEVENbutton_Click(object sender, EventArgs e)
        {
            if (enterValue)
            {
                this.UserInput.Text = "";
            }
            InsertTextValue("7");
            enterValue = false;

        }

        private void EIGHTbutton_Click(object sender, EventArgs e)
        {
            if (enterValue)
            {
                this.UserInput.Text = "";
            }
            InsertTextValue("8");
            enterValue = false;

        }

        private void NINEbutton_Click(object sender, EventArgs e)
        {
            if (enterValue)
            {
                this.UserInput.Text = "";
            }
            InsertTextValue("9");
            enterValue = false;

        }

        private void MULTbutton_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                return;
            }
            if (this.result != 0)
            {

                RESULTbutton.PerformClick();
                this.operation = '*';
                enterValue = true;

                this.Label1.Text = this.result + " " + this.operation + " ";


            }
            else
            {
                this.operation = '*';
                this.result = Double.Parse(this.UserInput.Text);
                enterValue = true;
                this.Label1.Text = this.result + " " + this.operation;
            }

        }

        private void FOURbutton_Click(object sender, EventArgs e)
        {
            if (enterValue)
            {
                this.UserInput.Text = "";
            }
            InsertTextValue("4");
            enterValue = false;

        }

        private void FIVEbutton_Click(object sender, EventArgs e)
        {
            if (enterValue)
            {
                this.UserInput.Text = "";
            }
            InsertTextValue("5");
            enterValue = false;

        }

        private void SIXbutton_Click(object sender, EventArgs e)
        {
            if (enterValue)
            {
                this.UserInput.Text = "";
            }
            InsertTextValue("6");
            enterValue = false;

        }

        private void SUBbutton_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                return;
            }
            if (this.result != 0)
            {
                
                RESULTbutton.PerformClick();
                this.operation = '-';
                enterValue = true;

                this.Label1.Text = this.result + " " + this.operation + " ";


            }
            else
            {
                this.operation = '-';
                this.result = Double.Parse(this.UserInput.Text);
                enterValue = true;
                this.Label1.Text = this.result + " " + this.operation;
            }
        }

        private void ONEbutton_Click(object sender, EventArgs e)
        {
            if (enterValue)
            {
                this.UserInput.Text = "";
            }
            InsertTextValue("1");
            enterValue = false;

        }

        private void TWObutton_Click(object sender, EventArgs e)
        {
            if (enterValue)
            {
                this.UserInput.Text = "";
            }
            InsertTextValue("2");
            enterValue = false;

        }

        private void THREEbutton_Click(object sender, EventArgs e)
        {
            if (enterValue)
            {
                this.UserInput.Text = "";
            }
            InsertTextValue("3");
            enterValue = false;

        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                return;
            }
            if (this.result != 0)
            {


                RESULTbutton.PerformClick();
                this.operation = '+';
                enterValue = true;

                this.Label1.Text = this.result + " " + this.operation + " ";
            }
            else
            {
                this.operation = '+';
                this.result = Double.Parse(this.UserInput.Text);
                enterValue = true;
                this.Label1.Text = this.result + " " + this.operation;
            }
        }


        private void ZERObutton_Click(object sender, EventArgs e)
        {
            if (enterValue)
            {
                this.UserInput.Text = "";
            }
            InsertTextValue("0");
            enterValue = false;
        }
        private void InsertTextValue(string s)
        {
            if(this.UserInput.Text == "0")
            {
                this.UserInput.Text = s;
            }
            else
            {
                this.UserInput.Text += s;
            }
        }
        private void DOTbutton_Click(object sender, EventArgs e)
        {
            if (!this.UserInput.Text.Contains("."))
            {
                InsertTextValue(".");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DIVINVERSECbutton_Click(object sender, EventArgs e)
        {
            if(CheckInput())
            {
                return;
            }
            this.operation = 'x';
            this.result = 1/Double.Parse(this.UserInput.Text);
            this.Label1.Text = "1/(" + this.UserInput.Text + ")";
            this.UserInput.Text = this.result.ToString();
        }

        private bool CheckInput()
        {
            return this.UserInput.Text == string.Empty;
            
        }
    }
}
