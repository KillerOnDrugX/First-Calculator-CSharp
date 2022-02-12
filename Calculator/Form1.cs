//Zahir Mohamed - 201806552

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
        public Form1()
        {
            InitializeComponent();
        }

        float num1, ans;
        int count;
        string curCalc = "";

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text!="0")
            {
                txtDisplay.Text = txtDisplay.Text + 0;
            }            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 8;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            curCalc = num1 + " " + "+ ";
            label1.Text = curCalc;
            count = 2;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                num1 = float.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                curCalc = num1 + " " + "- ";
                label1.Text = curCalc;
                count = 1;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            curCalc = num1 + " " + "× ";
            label1.Text = curCalc;
            count = 3;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            curCalc = num1 + " " + "÷ ";
            label1.Text = curCalc;
            count = 4;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + 9;
        }

        private void btnClearAllC_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            count = 0;
            ans = 0;
            num1 = 0;
            curCalc = "";
            label1.Text = "";
        }

        private void btnClearCurrentCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            int c = txtDisplay.TextLength;
            int flag = 0;
            string text = txtDisplay.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ",")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                txtDisplay.Text = txtDisplay.Text + ",";
            }
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            curCalc = num1 + " " + "^ ";
            label1.Text = curCalc;
            count = 5;
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text!="")
            {
                num1 = float.Parse(txtDisplay.Text);
                curCalc = "√" + num1 + " =";
                label1.Text = curCalc;
                txtDisplay.Text = Math.Sqrt(num1).ToString();
            }
                     
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text!="")
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            
        }

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    curCalc += float.Parse(txtDisplay.Text) + " = ";
                    ans = num1 - float.Parse(txtDisplay.Text);
                    label1.Text = curCalc;
                    curCalc = "";
                    txtDisplay.Text = ans.ToString();
                    break;
                case 2:
                    curCalc += float.Parse(txtDisplay.Text) + " = ";
                    ans = num1 + float.Parse(txtDisplay.Text);
                    label1.Text = curCalc;
                    curCalc = "";
                    txtDisplay.Text = ans.ToString();
                    break;
                case 3:
                    curCalc += float.Parse(txtDisplay.Text) + " = ";
                    ans = num1 * float.Parse(txtDisplay.Text);
                    label1.Text = curCalc;
                    curCalc = "";
                    txtDisplay.Text = ans.ToString();
                    break;
                case 4:
                    curCalc += float.Parse(txtDisplay.Text) + " = ";
                    ans = num1 / float.Parse(txtDisplay.Text);
                    label1.Text = curCalc;
                    curCalc = "";
                    txtDisplay.Text = ans.ToString();
                    break;
                case 5:
                    curCalc += float.Parse(txtDisplay.Text) + " = ";
                    float temp;
                    temp = float.Parse(txtDisplay.Text);
                    ans = num1;
                    for (float i = temp; i > 1; i--)
                    {
                        ans = ans * num1;
                    }
                    txtDisplay.Text = ans.ToString();
                    label1.Text = curCalc;
                    curCalc = "";
                    break;
                default:
                    break;
            }
        }
    }
}
