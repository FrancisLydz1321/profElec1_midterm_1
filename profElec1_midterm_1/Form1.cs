using System.Configuration;

namespace profElec1_midterm_1
{
    public partial class Form1 : Form
    {

        double firstNum, secondNum;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "7";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "8";
            }
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "9";
            }
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "4";
            }
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "6";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "3";
            }
        }

        private void btn0_Click_1(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            operation = "+";
            txtDisplay.Text = "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            operation = "-";
            txtDisplay.Text = "";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            operation = "*";
            txtDisplay.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            operation = "/";
            txtDisplay.Text = "";
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(-1 * q);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

            string first, second;

            first = Convert.ToString(firstNum);
            second = Convert.ToString(secondNum);

            first = "";
            second = "";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            secondNum = double.Parse(txtDisplay.Text);

            switch(operation)
            {
                case "+":
                    txtDisplay.Text = (firstNum + secondNum).ToString();

                    break;
                case "-":
                    txtDisplay.Text = (firstNum - secondNum).ToString();

                    break;
                case "*":
                    txtDisplay.Text = (firstNum * secondNum).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (firstNum / secondNum).ToString();
                    break;

                default: break;
            }
        }
    }
}
